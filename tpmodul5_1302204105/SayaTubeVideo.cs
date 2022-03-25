using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tpmodul5_1302204105
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo() { }
        public SayaTubeVideo(string judul)
        {
            if (judul.Length > 100 && judul == null)
                throw new Exception("Judul kelebihan");
            title = judul;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);
            playCount = 0;
        }
        public void IncreasePlayCount(int jumlah)
        {
            if(jumlah > 10000000)
                throw new Exception("melebihi batas penambahan play count");
            try
            {
                playCount = checked(playCount + jumlah);
            }
            catch
            {
                Console.WriteLine("Jumlah play count akan melampaui batas");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID       :" + id);
            Console.WriteLine("Judul    :" + title);
            Console.WriteLine("Views    :" + playCount);
        }
    }
}
