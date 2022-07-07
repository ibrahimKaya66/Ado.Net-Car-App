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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FrmList fl;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Data.Login();
            if (txtUser.Text == Data.user && txtPass.Text == Data.pass)
            {
                fl = new FrmList();
                fl.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Data.Login Hatası", "hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
