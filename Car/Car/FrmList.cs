using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Car
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }
        FrmAdd fa;
        public bool isInsert;
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            if (Application.OpenForms["FrmAdd"] != null)
                fa = (FrmAdd)Application.OpenForms["FrmAdd"];
            else
                fa = new FrmAdd();

            fa.Show();

            // this.Hide();
        }
        string main_param = "",where_param="", order_param="", price_param,year_param,fuel_param,gear_param,km_param, body_param,power_param;

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                order_param = " order by Price desc";
            }
            else if (cbSort.SelectedIndex == 1)
            {
                order_param = " order by Price";
            }
            else if (cbSort.SelectedIndex == 2)
            {
                order_param = " order by Km desc";
            }
            else if (cbSort.SelectedIndex == 3)
            {
                order_param = " order by Km";
            }
            else if (cbSort.SelectedIndex == 4)
            {
                order_param = " order by Year_ desc";
            }
            else if (cbSort.SelectedIndex == 5)
            {
                order_param = " order by Year_";
            }
            main_param =where_param + order_param;
            Data.GridFill(main_param);

        }

        int min_price, max_price, min_year, max_year, min_km, max_km, min_power, max_power;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMinPrice.Text == string.Empty)
                min_price = 0;
            else
                min_price = int.Parse(txtMinPrice.Text);
            if(txtMaxPrice.Text == string.Empty)
                max_price = 80000000;
            else
                max_price = int.Parse(txtMaxPrice.Text);

            if (txtMinYear.Text == string.Empty)
                min_year = 1950;
            else
                min_year = int.Parse(txtMinYear.Text);
            if (txtMaxYear.Text == string.Empty)
                max_year = DateTime.Now.Year;
            else
                max_year = int.Parse(txtMaxYear.Text);

            string in_fuel="";
            if(cbGasoline.Checked == false && cbGasolineLpg.Checked == false && cbDiesel.Checked == false && cbHibrid.Checked == false && cbElectric.Checked == false)
            {
                cbGasoline.Checked = true;
                cbGasolineLpg.Checked = true;
                cbDiesel.Checked = true;
                cbHibrid.Checked = true;
                cbElectric.Checked = true;

            }
            if (cbGasoline.Checked == true)
                in_fuel += "'Benzin',";
            if (cbGasolineLpg.Checked == true)
                in_fuel += "'Benzin&LPG',";
            if (cbDiesel.Checked == true)
                in_fuel += "'Dizel',";
            if (cbHibrid.Checked == true)
                in_fuel += "'Hibrid',";
            if (cbElectric.Checked == true)
                in_fuel += "'Elektrik',";
            in_fuel = in_fuel.Remove(in_fuel.Length - 1, 1);


            string in_gear = "";
            if (cbManuel.Checked == false && cbSemiAutomatic.Checked == false && cbAutomatic.Checked == false)
            {
                cbManuel.Checked = true;
                cbSemiAutomatic.Checked = true;
                cbAutomatic.Checked = true;
            }
            if (cbManuel.Checked == true)
                in_gear += "'Manuel',";
            if (cbSemiAutomatic.Checked == true)
                in_gear += "'Yarı Otomatik',";
            if (cbAutomatic.Checked == true)
                in_gear += "'Otomatik',";
            in_gear = in_gear.Remove(in_gear.Length - 1, 1);


            if (txtMinKm.Text == string.Empty)
                min_km = 0;
            else
                min_km = int.Parse(txtMinKm.Text);
            if (txtMaxKm.Text == string.Empty)
                max_km = 1000000;
            else
                max_km = int.Parse(txtMaxKm.Text);

            string in_body = "";
            if (cbHatchback.Checked == false && cbSuv.Checked == false && cbSedan.Checked == false)
            {
                cbHatchback.Checked = true;
                cbSedan.Checked = true;
                cbSuv.Checked = true;
            }
            if (cbHatchback.Checked == true)
                in_body += "'Hatchback',";
            if (cbSedan.Checked == true)
                in_body += "'Sedan',";
            if (cbSuv.Checked == true)
                in_body += "'SUV',";
            in_body = in_body.Remove(in_body.Length - 1, 1);

            if (txtMinPower.Text == string.Empty)
                min_power = 65;
            else
                min_power = int.Parse(txtMinPower.Text);
            if (txtMaxPower.Text == string.Empty)
                max_power = 6000;
            else
                max_power = int.Parse(txtMaxPower.Text);

            price_param = "where (Price between " + min_price + " and " + max_price+" )";

            year_param = " and (Year_ between " + min_year + " and " + max_year+")";

            fuel_param = " and (Fuel in("+in_fuel+") )";

            gear_param = " and (Gear in(" + in_gear + ") )";


            km_param = " and (Km between " + min_km + " and " + max_km + ")";
            body_param = " and (Body in(" + in_body + ") )";
            power_param = " and (Power_ between " + min_power + " and " + max_power + ")";
            where_param = price_param+year_param+fuel_param+gear_param+km_param+body_param+power_param;
            main_param = where_param + order_param;
            Data.GridFill(main_param);
            Clear();
        }

        private void Clear()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                    (item as TextBox).Text = "";
                if (item is CheckBox)
                    (item as CheckBox).Checked = false;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Data.GridFill("");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Data.Delete(id);
            Data.GridFill("");
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isInsert = false;
            if (Application.OpenForms["FrmAdd"] != null)
                fa = (FrmAdd)Application.OpenForms["FrmAdd"];
            else
                fa = new FrmAdd();

            fa.Show();
            fa.cbBrand.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fa.txtModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fa.txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fa.txtYear.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fa.cbFuelType.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fa.cbGear.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            fa.txtKm.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            fa.cbBodyType.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            fa.txtPower.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            fa.txtColor.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();


        }
    }
}
