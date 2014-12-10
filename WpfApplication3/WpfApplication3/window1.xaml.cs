using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            this.Background = Brushes.Black;
            InitializeComponent();
            MediaElement monMedia = new MediaElement();
        }
        void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Voulez vous vraiment quitter?", "Fermer l'application", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    System.Environment.Exit(1);
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
        void button_Mute(object sender, RoutedEventArgs e)
        {
        }
        void button_Play(object sender, RoutedEventArgs e)
        {
            monMedia.Play();
        }
        void button_Pause(object sender, RoutedEventArgs e)
        {
            monMedia.Pause();
        }
        void button_Stop(object sender, RoutedEventArgs e)
        {
            monMedia.Stop();
        }
        void button_parcourir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.AddExtension = true;
            opn.DefaultExt = "*.*";
            opn.Filter = "Media Files (*.*)|*.*";
            opn.ShowDialog();
            try
            {
                monMedia.Source = new Uri(opn.FileName);
                monMedia.Play();
            }
            catch
            {
                new NullReferenceException("Error");
            }
        }
    }
}
