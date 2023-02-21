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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// C:\Users\bullh\source\repos\PianoAlpha4\PianoAlpha4\Resources\c4.mp3

namespace PianoAlpha4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer playNote = new MediaPlayer();

        Uri C4Note;
        Uri E4Note;
        Uri G4Note;

        public void Animation(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var WidthAnimation = new DoubleAnimation() { To = 150,  Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };
            var HeightAnimation = new DoubleAnimation() { To = 150, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };
            
            button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            button.BeginAnimation(Button.HeightProperty, HeightAnimation);

        }
        
        public MainWindow()
        {
            InitializeComponent();

            C4Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources//c4.mp3");
            E4Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/e4.mp3");
            G4Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/g4.mp3");
        }

        private void C_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(C4Note);
            playNote.Play();
        }

        private void E_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(E4Note);
            playNote.Play();

        }

        private void G_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(G4Note);
            playNote.Play();
        }
    }
}
