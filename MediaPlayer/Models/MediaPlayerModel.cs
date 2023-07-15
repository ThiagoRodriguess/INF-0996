using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
   public class MediaPlayerModel : BaseModel
    {
        public string VideoPath { get; set; }
        public bool IsPlaying { get; set; }
        public double SeekPosition { get; set; }
        public double Volume { get; set; }
    }
}
