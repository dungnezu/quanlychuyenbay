using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmScheduleEdit : Form
    {
       private string from;
        private string to;
        private string air;
        private string date;
        private string time;
        private decimal priceeco;
        private int id;

        public frmScheduleEdit()
        {
            InitializeComponent();
        }
        public frmScheduleEdit(DTO_edits edits) : this()
        {
            from = edits.From;
            to= edits.To;
            air = edits.AircraftName;
            date = edits.Date;
            time = edits.Time;
            priceeco = edits.Economy;
            id = edits.Id;
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void frmScheduleEdit_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            mtxtDate.Mask = "00/00/0000";
            lblFrom.Text = from;
            lblTo.Text = to;
            lblAir.Text = air;
            mtxtDate.Text = date;
            txtTime.Text = time;
            txtEconomyPrice.Text = priceeco.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String date = mtxtDate.Text;
            String time = txtTime.Text;
            Decimal economy = decimal.Parse(txtEconomyPrice.Text);
            BUS_Schedules bus_Schedules = new BUS_Schedules();
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật chuyến bay này", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bus_Schedules.updateFlight(id, date, time, economy))
                {
                    MessageBox.Show(" Cập nhật thành công ");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                
            }
            
        }
    }
}
