using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – 1302204008");
            video.PrintVideoDetails();
            Console.WriteLine("Menambahkan PlayCount 28");
            video.IncreasePlayCount(28);
            video.PrintVideoDetails();

            Console.WriteLine("Menambahlan PlayCount 28000000");
            video.IncreasePlayCount(28000000);
            video.PrintVideoDetails();
        }
    }
}
