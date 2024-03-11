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

namespace ElSalto_GUI.Vistas
{
    /// <summary>
    /// Lógica de interacción para ActualizarPlanta.xaml
    /// </summary>
    public partial class ActualizarPlanta : Window
    {
        ElSalto_NEGOCIO.Planta.Planta planta;
        public ActualizarPlanta(int PlantaId)
        {
            InitializeComponent();
            this.Title = string.Format("Actualizar Planta {0}", PlantaId);
            planta = new ElSalto_NEGOCIO.Planta.Planta();
            CargarFormulario(PlantaId);

        }

        private void BnActualizarPlanta_Click(object sender, RoutedEventArgs e)
        {
            // planta.PlantaId = Convert.ToInt32(txtPlantaId.Text);
            planta.NombreComun = txtNombreComun.Text;
            planta.NombreCientifico = txtNombreCientifico.Text;
            planta.TipoPlanta = cmbTipoPlanta.Text;
            planta.Descripcion = txtDescripcion.Text;
            planta.TiempoRiego = Convert.ToInt32(txtTiempoRiego.Text);
            planta.CantidadAgua = Convert.ToInt32(txtCantidadAgua.Text);
            planta.Epoca = cmbEpoca.Text;
            planta.EsVenenosa = (chkEsVenenosa.IsChecked.Value) ? true : false;
            planta.EsAutoctona = (chkEsAutoctona.IsChecked.Value) ? true : false;

            bool response = planta.Update();

            if (response)
            {
                MessageBox.Show(string.Format("Planta {0} ha sido actualizado exitósamente!", planta.PlantaId));
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("No fue posible actualizar el registro {0}", planta.PlantaId));
                this.Close();
            }

        }
        private void CargarFormulario(int PlantaId)
        {
            bool response = planta.Read(PlantaId);

            if (response)
            {
                //txtPlantaId.Text = planta.PlantaId.ToString();
                txtNombreComun.Text = planta.NombreComun;
                txtNombreCientifico.Text = planta.NombreCientifico;
                cmbTipoPlanta.Text = planta.TipoPlanta;
                txtDescripcion.Text = planta.Descripcion;
                txtTiempoRiego.Text = planta.TiempoRiego.ToString();
                txtCantidadAgua.Text = planta.CantidadAgua.ToString();
                cmbEpoca.Text = planta.Epoca; ;
                chkEsAutoctona.IsChecked = planta.EsVenenosa;
                chkEsVenenosa.IsChecked = planta.EsAutoctona;


            }
            else
            {
                MessageBox.Show(string.Format("La Planta {0} no fue encontrada", planta));
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ElSalto_NEGOCIO.Planta.PlantaCollection plantaCollection = new ElSalto_NEGOCIO.Planta.PlantaCollection();

            cmbTipoPlanta.SelectedValue = plantaCollection.ReadAll();
            cmbEpoca.SelectedValue = plantaCollection.ReadAll();
        }
    }
}

