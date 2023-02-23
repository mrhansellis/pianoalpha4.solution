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
        MediaPlayer playC4Note = new MediaPlayer();
        MediaPlayer playE4Note = new MediaPlayer();
        MediaPlayer playG4Note = new MediaPlayer();
        MediaPlayer playD4Note = new MediaPlayer();
        MediaPlayer playF4Note = new MediaPlayer();
        MediaPlayer playA5Note = new MediaPlayer();
        MediaPlayer playB5Note = new MediaPlayer();
        MediaPlayer playC5Note = new MediaPlayer();

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
            
            var WidthAnimation = new DoubleAnimation() { From = 50, To = 150, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };
            var HeightAnimation = new DoubleAnimation() { From = 50, To = 150, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };

            button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }

        public void AnimationSmall(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            var WidthAnimation = new DoubleAnimation() { From = 40, To = 140, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };
            var HeightAnimation = new DoubleAnimation() { From = 40, To = 140, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };

            button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }

        public void Animation3(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            var WidthAnimation = new DoubleAnimation() { From = 60, To = 160, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };
            var HeightAnimation = new DoubleAnimation() { From = 60, To = 160, Duration = TimeSpan.FromSeconds(0.1), AutoReverse = true };

            button.BeginAnimation(Button.WidthProperty, WidthAnimation);
            button.BeginAnimation(Button.HeightProperty, HeightAnimation);
        }

        public MainWindow()
        {
            InitializeComponent();

            C4Note = new Uri("file:///C:/Users/bullh/source/repos/PianoAlpha4/PianoAlpha4/Resources/c4.mp3");
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
            playC4Note.Open(C4Note);
            playC4Note.Play();
            E.Visibility = Visibility.Visible;
        }

        private void E_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playE4Note.Open(E4Note);
            playE4Note.Play();
            G.Visibility = Visibility.Visible;
        }

        private void G_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playG4Note.Open(G4Note);
            playG4Note.Play();
            D.Visibility = Visibility.Visible;
        }

        private void D_Button_Click(object sender, RoutedEventArgs e)
        {
            AnimationSmall(sender, e);
            playD4Note.Open(D4Note);
            playD4Note.Play();
            F.Visibility = Visibility.Visible;
        }

        private void F_Button_Click(object sender, RoutedEventArgs e)
        {
            AnimationSmall(sender, e);
            playF4Note.Open(F4Note);
            playF4Note.Play();
            A.Visibility = Visibility.Visible;
        }

        private void A_Button_Click(object sender, RoutedEventArgs e)
        {
            AnimationSmall(sender, e);
            playA5Note.Open(A5Note);
            playA5Note.Play();
            B.Visibility = Visibility.Visible;
        }

        private void B_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation(sender, e);
            playB5Note.Open(B5Note);
            playB5Note.Play();
            C5.Visibility = Visibility.Visible;
        }

        private void C5_Button_Click(object sender, RoutedEventArgs e)
        {
            Animation3(sender, e);
            playC5Note.Open(C5Note);
            playC5Note.Play();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            E.Visibility = Visibility.Hidden;
            G.Visibility = Visibility.Hidden;
            D.Visibility = Visibility.Hidden;
            F.Visibility = Visibility.Hidden;
            A.Visibility = Visibility.Hidden;
            B.Visibility = Visibility.Hidden;
            C5.Visibility = Visibility.Hidden;
        }

        private void RefreshButton_MouseEnter(object sender, MouseEventArgs e)
        {
            RefreshButton.Visibility = Visibility.Visible;
        }

        //private void C_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{

        //}
    }
}
