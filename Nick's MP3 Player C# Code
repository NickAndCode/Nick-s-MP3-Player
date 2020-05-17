using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Win32;


namespace NicksMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            EnablePlayback(false);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer;
            timer.Tick += TotalTime;
            timer.Tick += Progress;
            timer.Start();
        }

        private void EnablePlayback(bool enabled)
        {
            playButton.IsEnabled = enabled;
            pauseButton.IsEnabled = enabled;
            playLoopButton.IsEnabled = enabled;
            stopButton.IsEnabled = enabled;
        }

        private void OpenFileButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                CheckFileExists = true,
                Filter = "MP3 files (*.mp3)|*.mp3",
            };
            
            if (file.ShowDialog() == true)
            {
                EnablePlayback(true);
                textBox.Text = file.FileName;
                player.Open(new Uri(file.FileName));
                string message = string.Format($"Selected File: {file.FileName}");
                MessageBar(message);
            }
        }

        private void Timer(object sender, EventArgs e)
        {
            if (player.Source != null)
            {
                timerButton.Content = player.Position.ToString(@"mm\:ss");
            }
        }

        private void TotalTime(object sender, EventArgs e)
        {
            if (player.Source != null)
            {
                if (player.NaturalDuration.HasTimeSpan)
                {
                    totalTime.Content = player.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                }
            }
        }

        private void Progress(object sender, EventArgs e)
        {
            if (player.Source != null)
            {
                if (player.NaturalDuration.HasTimeSpan)
                {
                    progressBar.Value = player.Position.TotalSeconds;
                    progressBar.Maximum = player.NaturalDuration.TimeSpan.TotalSeconds;
                }
            }
        }

        private void PlayButton(object sender, RoutedEventArgs e)
        {
            player.Play();
            MessageBar("Playing");
        }

        private void PlayLoopButton(object sender, RoutedEventArgs e)
        {
            {
                player.MediaEnded += new EventHandler(Media_Ended);
                player.Play();
                MessageBar("Play On Repeat");
                return;
            }
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
        }

        private void PauseButton(object sender, RoutedEventArgs e)
        {
            player.Pause();
            MessageBar("Paused");
        }

        private void StopButton(object sender, RoutedEventArgs e)
        {
            player.Stop();
            MessageBar("Stop. Have A Nice Day!");
        }

        private void MessageBar(string statusMessage)
        {
            if (!string.IsNullOrEmpty(statusMessage))
            {
                statusBar.Items[0] = statusMessage;
            }
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            player.Close();
            Application.Current.Shutdown();
        }
    }
}
