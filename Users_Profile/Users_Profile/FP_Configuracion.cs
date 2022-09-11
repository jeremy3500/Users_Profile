using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Users_Profile
{
    public partial class FP_Configuracion : Form
    {
        public FP_Configuracion()
        {
            InitializeComponent();
        }

        private void FP_Configuracion_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Utils.MyUser.User;
            txtpass.Text = Utils.MyUser.Password;
            lblcorreo.Text = Utils.MyUser.Email;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Perfil.ActiveForm.Close();
            Menu_Principal frm = new Menu_Principal();
            frm.Show();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult respt = MessageBox.Show("¿Seguro que desea eliminar su cuenta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respt == DialogResult.Yes)
            {
                User_List lista = new User_List();
                lista.cargar_Datos();
                lista.eliminar();
                Perfil.ActiveForm.Close();
                Menu_Principal frm = new Menu_Principal();
                frm.Show();
            }
        }
    }
}
