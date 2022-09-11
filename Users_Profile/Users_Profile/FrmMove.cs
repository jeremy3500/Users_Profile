using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Users_Profile
{
    public class FrmMove
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static void MoverFrm(Form pForm)
        {
            ReleaseCapture();
            SendMessage(pForm.Handle, 0x112, 0xf012, 0);
        }
    }
}
