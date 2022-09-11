using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Users_Profile
{
    public partial class Login : Form
    {
        public Login() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) {
            reset(txtUser, "Username"); reset(txtPass, "Password");
        }
        User_List lista = new User_List();
        public void modifi(TextBox txt) { txt.Clear(); txt.ForeColor = Color.White; } // modifica al dar click al textbox
        public void reset(TextBox txt, string text) { txt.Text = text; txt.ForeColor = Color.DarkGray; } // resetea el textbox
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = "", pass = "";
            bool error = false;
            errorProvider1.SetError(paUser, "");
            errorProvider1.SetError(paPass, "");

            try { if (txtUser.Text == "Username") throw new Exception(); user = txtUser.Text; } catch (Exception) { error = true; }
            try { if (txtPass.Text == "Password") throw new Exception(); pass = txtPass.Text; } catch (Exception) { error = true; }

            if (!error)
            {
                lista.cargar_Datos();
                Usuario us = lista.buscar(user);

                if (us != null)
                {
                    if (us.Password == pass)
                    {
                        Utils.MyUser = us;

                        this.Hide();
                        Perfil form = new Perfil();
                        form.Show();
                    }
                    else MessageBox.Show("Contraseña incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El usuario ingresado no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else MessageBox.Show("Rellene los campos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username") { modifi(txtUser); paUser.BackColor = Color.White; }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") { reset(txtUser, "Username"); paUser.BackColor = Color.DarkGray; }
        }
        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password") { modifi(txtPass); paPass.BackColor = Color.White; }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "") { reset(txtPass, "Password"); paPass.BackColor = Color.DarkGray; }
        }
        bool view = false;
        private void picOjo_Click(object sender, EventArgs e)
        {
            if (view)
            {
                picOjo.Image = Image.FromFile(@"imagenes\visualizar.png");
                txtPass.UseSystemPasswordChar = true;
                view = false;
            }
            else
            {
                picOjo.Image = Image.FromFile(@"imagenes\no_visualizar.png");
                txtPass.UseSystemPasswordChar = false;
                view = true;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal frm = new Menu_Principal();
            frm.Show();
        }

        private void panelCentral_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) FrmMove.MoverFrm(this);
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btnIngresar.PerformClick(); }
        }
    }
}
