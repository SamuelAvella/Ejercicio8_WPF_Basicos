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

namespace Ejercicio5
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

        private void OnClickEvent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evento Button.Click - Un evento de acción directa");
        }

        // Evento para el botón de MouseEnter
        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Evento MouseEnter - Detecta cuando el ratón entra en el botón");
        }

        // Evento para el clic derecho (PreviewMouseRightButtonDown)
        private void OnRightClickEvent(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Evento Button_MouseRightButtonDown - Un evento de clic específico con el botón derecho");
        }
    }
}
