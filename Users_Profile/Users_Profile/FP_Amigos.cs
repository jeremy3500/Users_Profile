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
    public partial class FP_Amigos : Form
    {
        public FP_Amigos()
        {
            InitializeComponent();
        }
        User_List lista = new User_List();
        
        private void FP_Amigos_Load(object sender, EventArgs e)
        {
            lista.cargar_Datos();
            lista.vista_amigos(pContenedor);
        }
    }
}
