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
    /// Lógica de interacción para Alumno.xaml
    /// </summary>
    public partial class Alumno : Window
    {
        public Alumno()
        {
            InitializeComponent();
        }
        
        static CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apellidos: " + alumno.Apellidos + "\nCodigo: " + alumno.Codigo + "\nCorreo: " +
                alumno.Correo + "\nDomicilio: " + alumno.Domicilio + "\nFechaNac: " + alumno.FechaNac + "\nLugarNac: " + alumno.LugarNac
                + "\nNombres: " + alumno.Nombres + "\nEscuela: " + alumno.Escuela + "\nSeguro: " + alumno.Seguro.ToString());
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.FechaNac = txtFechaNac.Text.Trim();
            alumno.LugarNac = txtLugarNac.Text.Trim();
            alumno.Escuela = txtEscuela.Text.Trim();
            alumno.Seguro = txtSeguro.Text.Trim();
            MessageBox.Show("Los datos del objeto Alumno fueron registrados correctamente", "Agregar Alumno");
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Existir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }
    }
}
