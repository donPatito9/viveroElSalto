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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElSalto_GUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ElSalto_NEGOCIO.Planta.PlantaCollection plantaCollection;
        ElSalto_NEGOCIO.Planta.PlantaReportes plantaReportes;
        //private object windowStartupLocation;

        public MainWindow()
        {
            InitializeComponent();
            plantaCollection = new ElSalto_NEGOCIO.Planta.PlantaCollection();
            //WindowStartupLocation = windowStartupLocation.CenterScreen;

            CargarGrilla();
        }

        private void optAgregarPlanta_Click(object sender, RoutedEventArgs e)
        {
            Vistas.AgregarPlanta agregarPlanta = new Vistas.AgregarPlanta();
            agregarPlanta.ShowDialog();
        }

        private void optListarPlantas_Click(object sender, RoutedEventArgs e)
        {
            Vistas.ListarPlantas listarPlantas = new Vistas.ListarPlantas();
            listarPlantas.ShowDialog();
        }
        private void btnOptInfo_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Informacion informacion = new Vistas.Informacion();
            informacion.ShowDialog();
        }

        private void optReportes_Click(object sender, RoutedEventArgs e)
        {


            ElSalto_NEGOCIO.Planta.PlantaReportes plantaReportes = new ElSalto_NEGOCIO.Planta.PlantaReportes();

            int plantasVenenosas = plantaReportes.ReportePlantaVenenosa();

            //int plantasNoVenenosas = plantaReportes.ReportePlantaNoVenenosa();
            int plantasAutoctonas = plantaReportes.ReportePlantaAutoctona();
            //int plantasNoAutoctonas = plantaReportes.ReportePlantaNoAutoctona();

            string message = string.Format(

                "Plantas Venenosas: {0} \n " +
                "Plantas  Autoctonas: {1}",

                 plantasVenenosas,
                  //plantasNoVenenosas,

                  plantasAutoctonas
            // plantasNoAutoctonas


            );
            MessageBox.Show(message);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgTodos.ItemsSource = plantaCollection.ReadAll();
        }
    }
 
}
