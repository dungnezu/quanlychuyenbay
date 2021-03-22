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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            showcombobox();
            showData();

            cboFrom.Text = "";
            cboTo.Text = "";
            cboSortBy.Text = "Date Time";
            btnCancelFlight.Enabled = false;
            btnEditFlight.Enabled = false;
            kiemtraconfirmed();

        }

        private void kiemtraconfirmed()
        {
            int count = dgvDATA.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvDATA.Rows[i].Cells["Confirmed"].Value.ToString().Equals("False"))
                    {
                        dgvDATA.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvDATA.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void showcombobox()
        {
            //show combobox from Airports list
            BUS_Airports comboFrom = new BUS_Airports();
            DataTable dataFrom= comboFrom.getAirPorts();
            
            if (dataFrom == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cboFrom.DataSource = dataFrom;
                cboFrom.DisplayMember = "IATACode";
                cboFrom.ValueMember = "IATACode";
            }


            //show combobox To Airports list
            BUS_Airports comboTo = new BUS_Airports();
            DataTable dataTo = comboTo.getAirPorts();
            if (dataTo == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                cboTo.DataSource = dataTo;
                cboTo.DisplayMember = "IATACode";
                cboTo.ValueMember = "IATACode";
            }
   
        }

        private void showData()
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules();
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvDATA.DataSource = table;
                dgvDATA.Columns["ID"].Visible = false;
                dgvDATA.Columns["Confirmed"].Visible = false;

                dgvDATA.Sort(dgvDATA.Columns["Date"], System.ComponentModel.ListSortDirection.Descending);
                dgvDATA.Columns[0].DefaultCellStyle.Format = "Custom";
                dgvDATA.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                txtOutbound.Text = "[dd/MM/yyyy]";

           



            }
            
        }
        private void sortData(String type)
        {
            if(type.Equals("Date time")| type.Equals(""))
            {
                dgvDATA.Sort(dgvDATA.Columns["Date"], System.ComponentModel.ListSortDirection.Ascending);
            }
            if (type.Equals("Economy price"))
            {
                dgvDATA.Sort(dgvDATA.Columns["Economyprice"], System.ComponentModel.ListSortDirection.Ascending);
            }
            if (type.Equals("Confirmed"))
            {
                dgvDATA.Sort(dgvDATA.Columns["Confirmed"], System.ComponentModel.ListSortDirection.Ascending);
            }

            
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImportChanges_Click(object sender, EventArgs e)
        {
            
            frmApplyScheduleChange form = new frmApplyScheduleChange();
            form.ShowDialog();
            frmMain_Load(sender, e);
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            
            frmScheduleEdit form = new frmScheduleEdit(edits);
            form.ShowDialog();
            frmMain_Load(sender, e);

        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            BUS_Airports air = new BUS_Airports();
            String iatacode = combo.SelectedValue.ToString();
            cboTo.DataSource = air.getAirPorts1(iatacode);
            cboTo.DisplayMember = "IATACode";
            cboTo.ValueMember = "IATACode";
        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSortBy.Text.Equals("Date time"))
            {
                dgvDATA.Sort(dgvDATA.Columns["Date"], System.ComponentModel.ListSortDirection.Descending);
                kiemtraconfirmed();
            }
             if(cboSortBy.Text.Equals("Economy price"))
            {
                dgvDATA.Sort(dgvDATA.Columns["Economyprice"], System.ComponentModel.ListSortDirection.Descending);
                kiemtraconfirmed();
            }
            
            if (cboSortBy.Text.Equals("Confirmed"))
            {
                dgvDATA.Sort(dgvDATA.Columns["Confirmed"], System.ComponentModel.ListSortDirection.Descending);
                kiemtraconfirmed();
            }
                


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String from = cboFrom.Text;
            String to = cboTo.Text;
            String type = cboSortBy.Text;
            

            if (from.Equals("")& to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]")& txtFlight.Text.Equals("") )
            {
                MessageBox.Show("Không thể tìm kiếm, hãy nhập ít nhất một thông tin để tìm kiếm ");
                sortData(type);
                kiemtraconfirmed();
            }
            else if(from.Equals("")==false & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals("")  )
            {
                TimKiem_From(from, type);
            }
            else if (from.Equals("") & to.Equals("")==false & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals("") )
            {
                TimKiem_To(to, type);
            }
            else if (from.Equals("") & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]")==false & txtFlight.Text.Equals(""))
            {
                String outbound = txtOutbound.Text;
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TimKiem_Outbound(type, ob);
            }
            else if (from.Equals("") & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals("")==false)
            {
                int flightnumber = int.Parse(txtFlight.Text);
                TimKiem_FlightNumber(type, flightnumber);
            }
            else if (from.Equals("") == false & to.Equals("")==false & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals(""))
            {
                TimKiem_FromTo(from, to, type);
            }
            else if (from.Equals("") == false & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]") == false & txtFlight.Text.Equals(""))
            {

                String outbound = txtOutbound.Text;
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TimKiem_FromOutbound(from, type, ob);
            }
            else if (from.Equals("") == false & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals("")==false)
            {

                int flightnumber = int.Parse(txtFlight.Text);
                TimKiem_FromFlightNumber(from, type, flightnumber);
            }
            else if (from.Equals("") & to.Equals("")==false & txtOutbound.Text.Equals("[dd/MM/yyyy]") == false & txtFlight.Text.Equals(""))
            {

                String outbound = txtOutbound.Text;
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TimKiem_ToOutbound(to, type, ob);
            }
            else if (from.Equals("")& to.Equals("") == false & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals("") == false)
            {

                int flightnumber = int.Parse(txtFlight.Text);

                TimKiem_ToFlightNumber(to, type, flightnumber);
            }
            else if (from.Equals("") & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]") == false & txtFlight.Text.Equals("") == false)
            {
                String outbound = txtOutbound.Text;
                int flightnumber = int.Parse(txtFlight.Text);
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TimKiem_FlightnumberOutbound(type, flightnumber, ob);
            }
            else if (from.Equals("") & to.Equals("")==false & txtOutbound.Text.Equals("[dd/MM/yyyy]") == false & txtFlight.Text.Equals("") == false)
            {
                String outbound = txtOutbound.Text;
                int flightnumber = int.Parse(txtFlight.Text);
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TimKiem_ToFlightnumberOutbound(to, type, flightnumber, ob);
            }
            else if (from.Equals("")==false & to.Equals("") & txtOutbound.Text.Equals("[dd/MM/yyyy]") == false & txtFlight.Text.Equals("") == false)
            {
                String outbound = txtOutbound.Text;
                int flightnumber = int.Parse(txtFlight.Text);
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TimKiem_FromFlightnumberOutbound(from, type, flightnumber, ob);
            }
            else if (from.Equals("") == false & to.Equals("") == false & txtOutbound.Text.Equals("[dd/MM/yyyy]") & txtFlight.Text.Equals("") == false)
            {

                int flightnumber = int.Parse(txtFlight.Text);

                TiemKiem_FromToFlightNumber(from, to, type, flightnumber);
            }
            else if (from.Equals("") == false & to.Equals("") == false & txtOutbound.Text.Equals("[dd/MM/yyyy]") == false & txtFlight.Text.Equals(""))
            {


                String outbound = txtOutbound.Text;
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TiemKiem_FromToOutbound(from, to, type, ob);
            }
            else
            {

                String outbound = txtOutbound.Text;
                int flightnumber = int.Parse(txtFlight.Text);
                String ob = outbound[6].ToString() + outbound[7].ToString() + outbound[8].ToString() + outbound[9].ToString() + "-" + outbound[3] + outbound[4] + "-" + outbound[0] + outbound[1];
                TiemKiem_all(from, to, type, flightnumber, ob);
            }


        }

        private void TiemKiem_all(string from, string to, string type, int flightnumber, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules1(from, to, ob, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TiemKiem_FromToOutbound(string from, string to, string type, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules15(from, to, ob);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TiemKiem_FromToFlightNumber(string from, string to, string type, int flightnumber)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules14(from, to, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_FromFlightnumberOutbound(string from, string type, int flightnumber, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules13(from, ob, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_ToFlightnumberOutbound(string to, string type, int flightnumber, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules12(to, ob, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_FlightnumberOutbound(string type, int flightnumber, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules11(ob, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_ToFlightNumber(string to, string type, int flightnumber)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules10(to, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_ToOutbound(string to, string type, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules9(to, ob);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_FromFlightNumber(string from, string type, int flightnumber)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules8(from, flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_FromOutbound(string from, string type, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules7(from, ob);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_FromTo(string from, string to, string type)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules6(from, to);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_FlightNumber(string type, int flightnumber)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules5(flightnumber);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_Outbound(string type, string ob)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules4(ob);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        private void TimKiem_To(string to, string type)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules3(to);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }
            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();

        }

        private void TimKiem_From(string from, string type)
        {
            DataTable table = new DataTable();
            BUS_Schedules schedules = new BUS_Schedules();
            table = schedules.getSchedules2(from);
            if (table == null)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Không có Kết quả");
            }

            dgvDATA.DataSource = table;
            dgvDATA.Columns["ID"].Visible = false;
            dgvDATA.Columns["Confirmed"].Visible = false;
            sortData(type);
            kiemtraconfirmed();
        }

        BUS_Schedules bus_Schedules = new BUS_Schedules();
        private void btnCancelFlight_Click(object sender, EventArgs e)
        {
            if (edits.Confirmed == false)
            {
                DialogResult result1 = MessageBox.Show("Chắc chắn xác nhận lại chuyến bay này", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result1 == DialogResult.Yes)
                {
                    int id = edits.Id;


                    if (bus_Schedules.confirmFlight(id))
                    {
                        MessageBox.Show("Xác nhận thành công");
                        frmMain_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hủy thất bại");
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Chắc chắn hủy chuyến bay này", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int id = edits.Id;


                    if (bus_Schedules.cancelFlight(id))
                    {
                        MessageBox.Show("Hủy thành công");
                        frmMain_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hủy thất bại");
                    }
                }
            }
            
               
            
        }
        DTO_edits edits = new DTO_edits();
        private void dgvDATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvDATA.CurrentCell.RowIndex;
            edits.Id = int.Parse(dgvDATA.Rows[row].Cells["ID"].Value.ToString());
            edits.Date = dgvDATA.Rows[row].Cells["Date"].Value.ToString();
            edits.Time = dgvDATA.Rows[row].Cells["Time"].Value.ToString();
            edits.From = dgvDATA.Rows[row].Cells["FROMS"].Value.ToString();
            edits.To = dgvDATA.Rows[row].Cells["TOS"].Value.ToString();
            edits.AircraftName = dgvDATA.Rows[row].Cells["Aircraft"].Value.ToString();
            edits.Flightnum = int.Parse(dgvDATA.Rows[row].Cells["Flightnumber"].Value.ToString());
            edits.Economy = decimal.Parse(dgvDATA.Rows[row].Cells["Economyprice"].Value.ToString());
            edits.Confirmed = bool.Parse(dgvDATA.Rows[row].Cells["Confirmed"].Value.ToString());
            if (edits.Confirmed==false)
            {
                btnCancelFlight.Text = "Confirm Flight";
                btnCancelFlight.Image = global::GUI.Properties.Resources.icons8_checked_24;
                btnCancelFlight.ImageAlign = ContentAlignment.MiddleLeft;
                btnCancelFlight.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                btnCancelFlight.Text = "Cancel Flight";
                btnCancelFlight.Image = global::GUI.Properties.Resources.icons8_cancel_24;
                btnCancelFlight.ImageAlign = ContentAlignment.MiddleLeft;
                btnCancelFlight.TextAlign = ContentAlignment.MiddleRight;
                
            }

            btnCancelFlight.Enabled = true;
            btnEditFlight.Enabled = true;


        }

        private void txtOutbound_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtOutbound_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void txtOutbound_MouseLeave(object sender, EventArgs e)
        {
            if (txtOutbound.Text == "")
            {
                txtOutbound.Text = "[dd/MM/yyyy]";
            }
        }

        private void dgvDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
