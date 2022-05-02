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
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }
        static CapaNegocio.Docente docente = new CapaNegocio.Docente();
        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            docente.Nombres = txtNombres.Text.Trim();
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.FechaNac = txtFechaNac.Text.Trim();
            docente.LugarNac = txtLugarNac.Text.Trim();
            docente.Afp = txtAFP.Text.Trim();
            docente.EstadoCivil = txtEstadoCivil.Text.Trim();
            docente.Curso = txtCurso.Text.Trim();
            docente.GradoAcademico = txtGradoAcademico.Text.Trim();
            
            MessageBox.Show("Los datos del objeto Docente fueron registrados correctamente", "Agregar Docente");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + docente.Apellidos + "\nCodigo: " + docente.Codigo + "\nCorreo: " +
                docente.Correo + "\nDomicilio: " + docente.Domicilio + "\nFechaNac: " + docente.FechaNac + "\nLugarNac: " + docente.LugarNac
                + "\nNombres: " + docente.Nombres + "\nAFP : " + docente.Afp + "\nEstado Civil: " + docente.EstadoCivil + "\nCurso:" + docente.Curso + "\nGrado Academico: " 
                + docente.GradoAcademico.ToString());
        }
        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Existir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Actualizar());
        }
        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Agregar());
        }
        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Buscar());
        }
        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Eliminar());
        }
        private void btnMetodo7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Listar());
        }
    }
}
