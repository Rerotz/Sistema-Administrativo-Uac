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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Alumno alumno = new Mantenimiento.Alumno();

            alumno.Show();
        }

        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Docente docente = new Mantenimiento.Docente();

            docente.Show();
        }

        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.Administrativo administrativo = new Mantenimiento.Administrativo();

            administrativo.Show();
        }
    }
}
