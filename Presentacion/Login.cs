using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //ReleaseCapture es una función de la biblioteca user32.dll que se utiliza para liberar la captura del mouse.
        //Se usa para permitir que el usuario arrastre la ventana.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        /*
            *SendMessage es una función de la biblioteca user32.dll que se utiliza para enviar mensajes a ventanas
            *de la interfaz de usuario.
            *En este contexto, se puede utilizar para enviar mensajes específicos
            *al sistema operativo como cambiar el tamaño de una ventana.
          
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
         */
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user=txtUser.Text.Trim();
            string pass=txtPass.Text.Trim();
           
            LUsuario usuario = new LUsuario();
            string mensaje;
            
            if (usuario.UserLogin(user, pass, out mensaje))
            {
                // Éxito en el inicio de sesión
                MessageBox.Show(mensaje);
            }
            else
            {
                // Falla en el inicio de sesión
                MessageBox.Show(mensaje);
            }
          
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
           //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
