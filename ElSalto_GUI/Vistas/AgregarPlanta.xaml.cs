using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ElSalto_GUI.Vistas
{
    /// <summary>
    /// Lógica de interacción para AgregarPlanta.xaml
    /// </summary>
    public partial class AgregarPlanta : Window
    {

        private static Regex s_regex = new Regex("[^0-9]+");

        ElSalto_NEGOCIO.Planta.Planta planta ;

        public AgregarPlanta()
        {
            InitializeComponent();
            Init();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }

        private void Init()
        {
            planta = new ElSalto_NEGOCIO.Planta.Planta();
            this.DataContext = planta;
        }
        private void BtnAgregarPlanta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ElSalto_NEGOCIO.Planta.Planta planta = new ElSalto_NEGOCIO.Planta.Planta
                {
                    //PlantaId = Convert.ToInt32(txtPlantaId.Text);
                    NombreComun = txtNombreComun.Text,
                    NombreCientifico = txtNombreComun.Text,
                    TipoPlanta = cmbTipoPlanta.Text,
                    Descripcion = txtDescripcion.Text,
                    TiempoRiego = Convert.ToInt32(txtTiempoRiego.Text),
                    CantidadAgua = Convert.ToInt32(txtCantidadAgua.Text),
                    Epoca = cmbEpoca.Text,
                    EsVenenosa = (chkEsVenenosa.IsChecked.Value) ? true : false,
                    EsAutoctona = (chkEsAutoctona.IsChecked.Value) ? true : false
                };
                bool response = planta.Create();

                if (response)
                {
                    MessageBox.Show("La Planta fue agregada correctamente");
                    AgregarOtraPlanta();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error Intente nuevamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }

        private void AgregarOtraPlanta()
        {
            string title = "Agregar nuevo Registro";
            string message = "¿Desea agregar nuevo Registro?";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.No)
            {
                this.Close();
            }
        }

        private void LimpiarCampos()
        {

            //txtPlantaId.Text = string.Empty;
            txtNombreComun.Text = string.Empty;
            txtNombreCientifico.Text = string.Empty;
            cmbTipoPlanta.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtTiempoRiego.Text = string.Empty;
            txtCantidadAgua.Text = string.Empty;
            cmbEpoca.Text = string.Empty;
            chkEsAutoctona.IsChecked = false;
            chkEsVenenosa.IsChecked = false;



        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ElSalto_NEGOCIO.Planta.PlantaCollection plantaCollection = new ElSalto_NEGOCIO.Planta.PlantaCollection();

           cmbTipoPlanta.SelectedItem = plantaCollection.ReadAll();

          //cmbEpoca.SelectedItem = plantaCollection.ReadAll();
        }


    }


}


