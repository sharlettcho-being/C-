using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1_1
{
    internal class Song
    {
        public string wTitle { get; set; }
        public string wArtistName { get; set; }
        public int wLength { get; set; }

        public Song(string vTitle, string vArtistName, int vLength)
        {
            this.wTitle = vTitle;
            this.wArtistName = vArtistName;
            this.wLength = vLength;
        }

    }
}
