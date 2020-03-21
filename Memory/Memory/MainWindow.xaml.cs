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

namespace Memory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer _mpBgr;
        private MediaPlayer _mpCurSound;

        public MainWindow()
        {
            InitializeComponent();
            _mpBgr = new MediaPlayer();
            _mpCurSound = new MediaPlayer();
        }
        private void Memory(object sender, RoutedEventArgs e)
        {
            _mpBgr.Open(new Uri(@"C:\Users\UPPiotr\source\repos\Memory\Memory/Ludovico Einaudi - Writing Poems.wav", UriKind.Absolute));
            _mpBgr.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             
                _mpCurSound.Open(new Uri(@"C:\Users\UPPiotr\source\repos\Memory\Memory/Ludovico Einaudi - Writing Poems.wav", UriKind.Absolute));
                _mpCurSound.Play();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
