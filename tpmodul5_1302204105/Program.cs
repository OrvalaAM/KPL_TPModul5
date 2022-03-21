using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204105
{
    internal class Program
    {
        public static void Main()
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Orvala");
            video.IncreasePlayCount(50);
            video.PrintVideoDetails();
        }
    }
}
