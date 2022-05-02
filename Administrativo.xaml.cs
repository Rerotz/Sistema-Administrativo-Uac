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

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Administrativo.xaml
    /// </summary>
    public partial class Administrativo : Window
    {
        public Administrativo()
        {
            InitializeComponent();
        }
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Apellidos: " + administrativo.Apellidos + "\nCodigo: " + administrativo.Codigo + "\nCorreo: " +
                    administrativo.Correo + "\nDomicilio: " + administrativo.Domicilio + "\nFechaNac: " + administrativo.FechaNac + "\nLugarNac: " + administrativo.LugarNac
                    + "\nNombres: " + administrativo.Nombres + "\nConocimientos: " + administrativo.Conocimientos + 
                    "\nCualidades: " + administrativo.Cualidades + "\nGanancia: " + administrativo.Ganancia + "\nPuesto: " + administrativo.Puesto.ToString());
            
        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.FechaNac = txtFechaNac.Text.Trim();
            administrativo.LugarNac = txtLugarNac.Text.Trim();
            administrativo.Conocimientos = txtConocimientos.Text.Trim();
            administrativo.Cualidades = txtCualidades.Text.Trim();
            administrativo.Ganancia = txtGanancia.Text.Trim();
            administrativo.Puesto = txtPuesto.Text.Trim();
            MessageBox.Show("Los datos del objeto Alumno fueron registrados correctamente", "Agregar Alumno");
        }
        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Existir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Actualizar());
        }
        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Agregar());
        }
        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Buscar());
        }
        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Eliminar());
        }
        private void btnMetodo7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Listar());
        }
    }
}
