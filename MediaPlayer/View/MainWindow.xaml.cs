using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Media;
using WpfApp1.Models;
using WpfApp1.ViewModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel.ViewModel viewModel;
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel.ViewModel();
            viewModel.MediaElement = mediaElement1;
            DataContext = viewModel;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            slider_seek.Value = viewModel.SeekPosition;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel.Pause();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            viewModel.Stop();
        }

        private void Slider_vol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            viewModel.Volume = (double)slider_vol.Value;
        }

        private void Slider_seek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            viewModel.SeekPosition = slider_seek.Value;
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {

            string filename = (string)((DataObject)e.Data).GetFileDropList()[0];
            viewModel.VideoPath = filename;
            mediaElement1.Source = new Uri(filename);
            mediaElement1.LoadedBehavior = MediaState.Manual;
            mediaElement1.UnloadedBehavior = MediaState.Manual;
            viewModel.Play();
            timer.Start();

        }

        private void MediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            TimeSpan ts = mediaElement1.NaturalDuration.TimeSpan;
            slider_seek.Maximum = ts.TotalSeconds;
            timer.Start();

        }
    }
}

