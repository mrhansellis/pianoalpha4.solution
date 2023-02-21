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
        Uri D4Note;
        Uri F4Note;
        Uri A5Note;
        Uri B5Note;
        Uri C5Note;


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
            D4Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/d4.mp3");
            F4Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/f4.mp3");
            A5Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/a5.mp3");
            B5Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/b5.mp3");
            C5Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/c5.mp3");
        }

        private void C_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(C4Note);
            playNote.Play();
            E.Visibility = Visibility.Visible;
        }

        private void E_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(E4Note);
            playNote.Play();
            G.Visibility = Visibility.Visible;
        }

        private void G_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(G4Note);
            playNote.Play();
            D.Visibility = Visibility.Visible;
        }

        private void D_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(D4Note);
            playNote.Play();
            F.Visibility = Visibility.Visible;
        }

        private void F_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(F4Note);
            playNote.Play();
            A.Visibility = Visibility.Visible;
        }

        private void A_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(A5Note);
            playNote.Play();
            B.Visibility = Visibility.Visible;
        }

        private void B_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(B5Note);
            playNote.Play();
            C5.Visibility = Visibility.Visible;
        }

        private void C5_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playNote.Open(C5Note);
            playNote.Play();
        }
    }
}
