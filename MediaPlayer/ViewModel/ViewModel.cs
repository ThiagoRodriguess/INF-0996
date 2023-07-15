using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MediaPlayer.ViewModel
{
    public class ViewModel : BaseViewModel
    {
        private string _videoPath;
        public string VideoPath
        {
            get { return _videoPath; }
            set
            {
                if (_videoPath != value)
                {
                    _videoPath = value;
                    NotifyPropertyChanged(nameof(VideoPath));
                }
            }
        }

        private bool _isPlaying;
        public bool IsPlaying
        {
            get { return _isPlaying; }
            set
            {
                if (_isPlaying != value)
                {
                    _isPlaying = value;
                    NotifyPropertyChanged(nameof(IsPlaying));
                }
            }
        }

        private double _seekPosition;
        public double SeekPosition
        {
            get { return _seekPosition; }
            set
            {
                if (_seekPosition != value)
                {
                    _seekPosition = value;
                    NotifyPropertyChanged(nameof(SeekPosition));
                    UpdateSeekPosition(); // Atualizar a posição de reprodução no MediaElement
                }
            }
        }

        private double _volume = 1;
        public double Volume
        {
            get { return _volume; }
            set
            {
                if (_volume != value)
                {
                    _volume = value;
                    NotifyPropertyChanged(nameof(Volume));
                    UpdateVolume(); // Atualizar o volume no MediaElement
                }
            }
        }

        public MediaElement MediaElement { get; set; }

        public void Play()
        {
            MediaElement.Play();
            IsPlaying = true;
        }

        public void Pause()
        {
            MediaElement.Pause();
            IsPlaying = false;
        }

        public void Stop()
        {
            MediaElement.Stop();
            IsPlaying = false;
        }

        private void UpdateSeekPosition()
        {
            MediaElement.Position = TimeSpan.FromSeconds(SeekPosition);
        }

        private void UpdateVolume()
        {
            MediaElement.Volume = Volume;
        }
    }
}
