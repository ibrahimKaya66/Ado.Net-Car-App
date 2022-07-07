using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
            foreach (var item in Data.ListBrand())
            {
                cbBrand.Items.Add(item);
            }
            foreach (var item in Data.ListFuelType())
            {
                cbFuelType.Items.Add(item);
            }
            foreach (var item in Data.ListGear())
            {
                cbGear.Items.Add(item);
            }
            foreach (var item in Data.ListBodyType())
            {
                cbBodyType.Items.Add(item);
            }
        }
        FrmList fl;
        private void btnSave_Click(object sender, EventArgs e)
        {
            fl = (FrmList)Application.OpenForms["FrmList"];
            if (fl.isInsert)
            {
                Data.InsertCar();
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        //((TextBox)item).Text = string.Empty;

                        (item as TextBox).Text = string.Empty;
                    }
                }
            }
                
            else
            {
                int id = Convert.ToInt32(fl.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Data.Update(id);
            }
            Data.GridFill("");

            MessageBox.Show("Başarılı bir şekilde kayıt edildi.");
    
        }
 
        private void btnList_Click(object sender, EventArgs e)
        {
            fl = (FrmList)Application.OpenForms["FrmList"];
            fl.Show();
            this.Hide();
        }
    }
}
