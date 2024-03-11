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
    /// Lógica de interacción para ListarPlantas.xaml
    /// </summary>
    public partial class ListarPlantas : Window
    {
        ElSalto_NEGOCIO.Planta.PlantaCollection plantaCollection;

        public ListarPlantas()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void btnActualizarRegistro_Click(object sender, RoutedEventArgs e)
        {
            var filaSeleccionada = (ElSalto_NEGOCIO.Planta.Planta)dgTodos.SelectedItem;
            ActualizarPlanta actualizarPlanta = new ActualizarPlanta(filaSeleccionada.PlantaId);
            actualizarPlanta.ShowDialog();
            this.Close();
        }

        private void btnEliminarRegistro_Click(object sender, RoutedEventArgs e)
        {
            EliminarRegistroSeleccionado();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            plantaCollection = new ElSalto_NEGOCIO.Planta.PlantaCollection();
            dgTodos.ItemsSource = plantaCollection.ReadAll();
        }

        private void EliminarRegistroSeleccionado()
        {
            var filaSeleccionada = (ElSalto_NEGOCIO.Planta.Planta)dgTodos.SelectedItem;
            int PlantaId = filaSeleccionada.PlantaId;
            string title = "Eliminar Planta";
            string message = string.Format("Estás seguro de eliminar El registro {0}", PlantaId);

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.Yes)
            {
                var res = filaSeleccionada.Delete(PlantaId) ?
                MessageBox.Show(string.Format("Registro {0} eliminado", PlantaId)) :
                MessageBox.Show("Planta no pudo ser eliminada");

                this.Close();
            }

        }
    }
}


