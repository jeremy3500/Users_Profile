using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users_Profile
{
    public partial class Perfil : Form
    {
        public Perfil() { InitializeComponent(); }
        User_List lista = new User_List();
        private void Perfil_Load(object sender, EventArgs e)
        {
            lista.cargar_Datos();
            lblNAME.Text = Utils.MyUser.User;
        }
        public void abrir_form(Form frm) {
            while (paCentral.Controls.Count >0)
            {
                paCentral.Controls.RemoveAt(0);
            }
            Form formhijo = frm;
            frm.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            paCentral.Controls.Add(formhijo);
            formhijo.Show();
        }
        public void color_selec(Panel pa) { pa.BackColor = Color.FromArgb(117, 97, 73); }
        public void reset_color_select()
        {
            pselecPrincipal.BackColor = Color.FromArgb(58, 74, 94); pselecNotas.BackColor = Color.FromArgb(58, 74, 94);
            pselecAmigos.BackColor = Color.FromArgb(58, 74, 94); pselecConfigu.BackColor = Color.FromArgb(58, 74, 94);
            pselecMensajes.BackColor = Color.FromArgb(58, 74, 94);
        }

        // Eventos Click
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            abrir_form(new FP_Principal());
            reset_color_select(); color_selec(pselecPrincipal);
        }
        private void btnNotas_Click(object sender, EventArgs e)
        {
            abrir_form(new FP_Notas());
            reset_color_select(); color_selec(pselecNotas);
        }
        private void btnAmigos_Click(object sender, EventArgs e)
        {
            abrir_form(new FP_Amigos());
            reset_color_select(); color_selec(pselecAmigos);
        }
        private void btnMensajes_Click(object sender, EventArgs e)
        {
            abrir_form(new FP_Mensajes());
            reset_color_select(); color_selec(pselecMensajes);
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            abrir_form(new FP_Configuracion());
            reset_color_select(); color_selec(pselecConfigu);
        }
        // Cierre de Aplicacion
        private void btnSalir_Click(object sender, EventArgs e) { Application.Exit(); }

        private void paSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) FrmMove.MoverFrm(this);
        }
    }
}
