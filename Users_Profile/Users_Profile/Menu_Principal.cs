using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Users_Profile
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal() { InitializeComponent(); }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm = new Register();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Principal_Load(object sender, EventArgs e) { }
        private void paSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) FrmMove.MoverFrm(this);
        }
    }
}
