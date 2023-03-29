using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD6_KPL_1302213003
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        String username;
        int total;

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(1, 999999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.total = 0;
            this.username = username;
            
            }
        }

        public int GetTotalVideoPlayCount()
        {
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                total = total + uploadedVideos[i].GetPlayCount();
            }
            return total;
        }
        
        public void AddVideos(SayaTubeVideo videos)
        {
            uploadedVideos.Add(videos);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.Writeline("Video" + (i+1) + "judul"+ uploadedVideos[i].title + "count"+ uploadedVideos[i].GetPlayCount()); 
        }
    }
}
