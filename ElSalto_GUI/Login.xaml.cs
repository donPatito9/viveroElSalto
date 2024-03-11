using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ElSalto_GUI
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Password;

                ElSalto_NEGOCIO.Login.Session session = new ElSalto_NEGOCIO.Login.Session();
                bool res = session.IsValidLogin(username, password);

                if (res)
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {
                    lblMensaje.Content = "El usuario o contraseña es incorrecto";
                }
            }
            catch (Exception)
            {
                lblMensaje.Content = "Ha ocurrido un error";
            }
        }
    }
}

