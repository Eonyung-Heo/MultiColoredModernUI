using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.Etc
{
    public partial class InterCityBusPrice : Form
    {
        MssqlEtc sql = new MssqlEtc();

        public InterCityBusPrice()
        {
            InitializeComponent();
            BusFareLoad();
        }

        public void BusFareLoad()
        {
            List<List<string>> fare = new List<List<string>>();

            fare = sql.SelectInterCityBusPrice("", "", "", "");

            if (fare.Count > 0)
            {
                for (int i = 0; i < fare.Count; i++)
                {
                    guna2DataGridView2.Rows.Add(fare[i].ToArray());
                }

            }

        }


        private void guna2TextBox_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView2.Rows.Clear();

            string laneid = guna2TextBox2.Text;
            string laneno = guna2TextBox3.Text;
            string price = guna2TextBox4.Text;
            string citycode = guna2TextBox5.Text;

            List<List<string>> fare = new List<List<string>>();

            fare = sql.SelectInterCityBusPrice(laneid, laneno, price, citycode);

            if (fare.Count > 0)
            {
                for (int i = 0; i < fare.Count; i++)
                {
                    guna2DataGridView2.Rows.Add(fare[i].ToArray());
                }

            }

        }

        private void guna2DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = -1;

            rowIndex = e.RowIndex;

            if (rowIndex > -1)
            {

                var laneid = guna2DataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
                var fareid = guna2DataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
                var fare = guna2DataGridView2.Rows[rowIndex].Cells[3].Value.ToString();

                sql.UpdateInterCityBusPrice(laneid, fareid, fare);

            }
        }

        public void DataGridViewReadOnly()
        {
            guna2DataGridView2.Columns[0].ReadOnly = true;
            guna2DataGridView2.Columns[1].ReadOnly = true;
            guna2DataGridView2.Columns[2].ReadOnly = true;
            guna2DataGridView2.Columns[3].ReadOnly = true;
        }
    }
}
