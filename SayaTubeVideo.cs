using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD6_KPL_1302213003
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(1,99999);
            playCount = 0;


            
        }
        public void IncreasePlayCount(int x)
        {
            x += x;

        }
        public int GetPlayCount()
        {
            return playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("====Video Details====");
            Console.WriteLine("ID : " + this.id);
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Play Count : " + playCount);
            Console.WriteLine();
        }
    }
}
