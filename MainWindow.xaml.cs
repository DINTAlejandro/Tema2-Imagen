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

namespace Tema2_Imagen
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

        private void bajo_RadioButton_Click(object sender, RoutedEventArgs e)
        {
            img_Image.Opacity = 0.1;
        }

        private void medio_RadioButton_Click(object sender, RoutedEventArgs e)
        {
            img_Image.Opacity = 0.5;
        }

        private void alto_RadioButton_Click(object sender, RoutedEventArgs e)
        {
            img_Image.Opacity = 1;
        }

        private void relleno_RadioButton_Click(object sender, RoutedEventArgs e)
        {
            img_Image.Stretch = Stretch.Fill;
        }

        private void uniforme_RadioButton_Click(object sender, RoutedEventArgs e)
        {
            img_Image.Stretch = Stretch.Uniform;
        }

        private void rellenouniforme_RadioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
            img_Image.Stretch = Stretch.UniformToFill;
        }

        private void sinajuste_RadioButton_Click(object sender, RoutedEventArgs e)
        {
            img_Image.Stretch = Stretch.None;
        }
    }
}
