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
    public partial class BusPrice : Form
    {
        MssqlEtc sql = new MssqlEtc();



        public BusPrice()
        {
            InitializeComponent();
            BusFareLoad();


        }

        public void BusFareLoad()
        {
            List<List<string>> fare = new List<List<string>>();

            fare = sql.SelectBusPrice("","","","");

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

            string cityCode = guna2TextBox2.Text;
            string cityName = guna2TextBox3.Text;
            string busClass = guna2TextBox4.Text;
            string busClassName = guna2TextBox5.Text;

            List<List<string>> fare = new List<List<string>>();

            fare = sql.SelectBusPrice(cityCode, cityName, busClass, busClassName);

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

                var citycode = guna2DataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
                var busclass = guna2DataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
                var buscash = guna2DataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
                var buscard = guna2DataGridView2.Rows[rowIndex].Cells[5].Value.ToString();

                sql.UpdateBusPrice(citycode,busclass,buscash,buscard);
                
            }
        }
    }
}
