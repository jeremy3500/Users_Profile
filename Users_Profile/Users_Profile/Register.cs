using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users_Profile
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)  { }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal frm = new Menu_Principal();
            frm.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool error = false;
            Usuario user = new Usuario();
            errorProvider1.SetError(paUser, "");
            errorProvider1.SetError(paEMail, "");
            errorProvider1.SetError(paPass, "");
            errorProvider1.SetError(paConfirmPass, "");

            try { user.User = txtUser.Text; } catch (Exception ex) { errorProvider1.SetError(paUser, ex.Message); error = true; }
            try { user.Email = txtEmail.Text; } catch (Exception ex) { errorProvider1.SetError(paEMail, ex.Message); error = true; }
            try { if (txtPass.Text == "") throw new Exception("Ingrese una contraseña"); } catch (Exception ex) { errorProvider1.SetError(paPass, ex.Message); error = true; }

            try { if (txtPass.Text != txtConfirmPass.Text) throw new Exception("Las contraseñas no coinciden");
                user.Password = txtPass.Text;
            } catch (Exception ex) { errorProvider1.SetError(paConfirmPass, ex.Message); error = true; }

            if (!error)
            {
                if (rbtnAceptTerms.Checked == false) { MessageBox.Show("Debe aceptar los terminos y condiciones.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); error = true; }

                if (!error)
                {
                    User_List lista = new User_List();
                    int codigo = lista.numero_azar();

                    StreamWriter sw = new StreamWriter("cuentas.txt", true);
                    sw.WriteLine("{0},{1},{2},{3}", user.User, user.Email, user.Password, codigo);
                    sw.Close();

                    Utils.MyUser = new Usuario(user.User, user.Email, user.Password, codigo);

                    this.Hide();
                    Perfil frm = new Perfil();
                    frm.Show();
                }
            }
        }
        bool view = false;
        private void picOjo_Click(object sender, EventArgs e)
        {
            if (view)
            {
                picOjo.Image = Image.FromFile(@"imagenes\visualizar.png");
                txtPass.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
                view = false;
            }
            else
            {
                picOjo.Image = Image.FromFile(@"imagenes\no_visualizar.png");
                txtPass.UseSystemPasswordChar = false;
                txtConfirmPass.UseSystemPasswordChar = false;
                view = true;
            }
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) FrmMove.MoverFrm(this);
        }
    }
}
