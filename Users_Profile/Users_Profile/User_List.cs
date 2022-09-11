using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users_Profile
{
    class User_List
    {
        ArrayList list;
        public User_List() { list = new ArrayList(); }
        public void cargar_Datos()
        {
            StreamReader sr = new StreamReader("cuentas.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] dates = line.Split(',');
                list.Add(new Usuario(dates[0], dates[1], dates[2], int.Parse(dates[3])));
            }
            sr.Close();
        }
        public Usuario buscar(string name)
        {
            foreach (Usuario use in list)
                if (use.User == name)
                    return use;
            return null;
        }
        public void new_User(Usuario user) { list.Add(user); }
        public Usuario search_User(int codig)
        {
            foreach (Usuario use in list)
                if (use.Codigo == codig)
                    return use;
            return null;
        }
        public void vista_amigos(Panel pContenedor)
        {
            int x = 10, y = 10;

            foreach (Usuario us in list)
            {
                if (us.Codigo != Utils.MyUser.Codigo)
                {
                    // Creo el Boton +
                    Button btn = new Button();
                    btn.BackColor = Color.Transparent;
                    btn.Dock = DockStyle.Right;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    btn.ForeColor = Color.White;
                    btn.Size = new Size(30, 60);
                    btn.Text = "+";
                    btn.UseVisualStyleBackColor = false;
                    //btn.Click += new EventHandler(agregar_person);
                    // Creo la imagen
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(@"imagenes\icono_user.png");
                    pic.Location = new Point(13, 5);
                    pic.Size = new Size(50, 50);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    // Creo el Titulo
                    Label lblTit = new Label();
                    lblTit.AutoSize = true;
                    lblTit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    lblTit.ForeColor = Color.White;
                    lblTit.Location = new Point(69, 9);
                    lblTit.Size = new Size(90, 25);
                    lblTit.Text = us.User;
                    // Creo la Descripcion
                    Label lblDescription = new Label();
                    lblDescription.AutoSize = true;
                    lblDescription.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    lblDescription.ForeColor = Color.White;
                    lblDescription.Location = new Point(71, 34);
                    lblDescription.Size = new Size(80, 17);
                    lblDescription.Text = us.Email;
                    // Creo el panel
                    Panel pa = new Panel();

                    pa.BackColor = Color.FromArgb(69, 87, 110);
                    pa.Controls.Add(lblDescription);
                    pa.Controls.Add(btn);
                    pa.Controls.Add(lblTit);
                    pa.Controls.Add(pic);
                    pa.Location = new Point(x, y);
                    pa.Size = new Size(300, 60);
                    pContenedor.Controls.Add(pa);
                    y += 70;
                }
            }
        }
        public void eliminar()
        {
            foreach (Usuario us in list)
            {
                if (us.Codigo == Utils.MyUser.Codigo)
                {
                    list.Remove(us); break;
                }
            }
            StreamWriter sw = new StreamWriter("cuentas.txt");
            sw.Write("");
            foreach (Usuario us in list)
                sw.WriteLine("{0},{1},{2},{3}", us.User, us.Email, us.Password, us.Codigo);
            sw.Close();
        }
        public int numero_azar()
        {
            Random rnd = new Random();
            int codigo;
            bool repet;
            do
            {
                repet = false;
                codigo = rnd.Next(1000, 10000);
                if (list.Count >= 1)
                {
                    foreach (Usuario us in list)
                    {
                        if (us.Codigo == codigo) { repet = true; break; }
                    }
                }
            } while (repet);
            return codigo;
        }
    }
}
