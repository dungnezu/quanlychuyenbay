using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmApplyScheduleChange : Form
    {
        public frmApplyScheduleChange()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmApplyScheduleChange_Load(object sender, EventArgs e)
        {
            btnImportFile.Enabled = false;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFile_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.FileName = "Select a text file";
            openFileDialog1.Filter = "Text files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.Title = "Open text file";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                btnImportFile.Enabled = true;
                txtFile.Text = openFileDialog1.FileName;
            }
            else
            {
                btnImportFile.Enabled = false;
                txtFile.Text = "";
            }
        }
        DataTable dataTable = new DataTable();
        BUS_Schedules schedules = new BUS_Schedules();
        BUS_Airports airports = new BUS_Airports();
        BUS_Routes routes = new BUS_Routes();
        private DataTable getData()
        {

            String[] data = System.IO.File.ReadAllLines(txtFile.Text);
            String[] data1 = null;
            String[] tieude = { "HoatDong", "Date", "Time", "FliNum", "From", "To", "AirID", "EcoPrice", "Conf" };
            DataTable dt = new DataTable();
            bool kttd = false;
            foreach (String line in data)
            {
                data1 = line.Split(',');
                if (kttd == false)
                {
                    for(int i = 0; i < data1.Count(); i++)
                    {
                        dt.Columns.Add(tieude[i]);
                        kttd = true;
                    }
                    
                }
                dt.Rows.Add(data1);
            }
            return dt;
            
        }
        
        private void btnImportFile_Click(object sender, EventArgs e)
        {
            dataTable = getData();
            import();
        }

        private void import()
        {
            int demADD = 0;
            int demDup = 0;
            int demMiss = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                try
                {
                    //xứ lý ngày
                    DateTime date = DateTime.Parse(row["Date"].ToString());
                    String dates = date.ToString("dd/MM/yyyy");
                    //MessageBox.Show(dates);
                    String date1 = dates[6].ToString() + dates[7].ToString() + dates[8].ToString() + dates[9].ToString() + "-" + dates[3] + dates[4] + "-" + dates[0] + dates[1];
                    // MessageBox.Show(date1);
                    String time = row["Time"].ToString();
                    int FliNum = int.Parse(row["FliNum"].ToString());
                    //lấy id airports
                    String from = row["From"].ToString();
                    int dataFrom = int.Parse(airports.getAirPortsIATACode(from).ToString());
                    String to = row["To"].ToString();
                    int dataTo = int.Parse(airports.getAirPortsIATACode(to).ToString());
                    // lấy id routes
                    int rouId = int.Parse(routes.getRoutesIATACode(dataFrom, dataTo).ToString());
                    int airId = int.Parse(row["AirID"].ToString());
                    decimal ecoprice = decimal.Parse(row["EcoPrice"].ToString());
                    //xử lý confirmed
                    int confirmed = 1;
                    if (row["Conf"].ToString().Equals("CANCELED"))
                    {
                        confirmed = 0;
                    }

                    // MessageBox.Show(date1+" "+time + " " + dataFrom + " " + dataTo + " " + rouId + " " + airId + " " + confirmed.ToString() + " " + ecoprice.ToString());
                    if (row["HoatDong"].ToString().Equals("ADD"))
                    {
                        if (!schedules.getSchedulesTable(date1, FliNum))
                        {
                            if (schedules.addSchedules(date1, time, airId, rouId, ecoprice, confirmed, FliNum))
                            {
                                demADD++;
                            }
                        }
                        else
                        {
                            demDup++;
                        }
                    }
                    else if (row["HoatDong"].ToString().Equals("EDIT"))
                    {
                        if (schedules.editSchedules(date1, time, airId, rouId, ecoprice, confirmed, FliNum))
                        {
                            demADD++;
                        }
                        else
                        {
                            demMiss++;
                        }
                    }
                }
                catch
                {
                    demMiss++;
                }
            }

            lblSucc.Text = demADD.ToString();
            lblRec.Text = demMiss.ToString();
            lblDup.Text = demDup.ToString();
        }

        private void frmApplyScheduleChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
        }
    }
}
