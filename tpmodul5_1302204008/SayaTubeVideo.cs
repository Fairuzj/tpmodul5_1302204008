using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204008
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null && title.Length <=100);
            Random random = new Random();
            this.title = title;
            this.id = random.Next(0,100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int i)
        {
            Contract.Requires(i <=10000000);

            try
            {
                if(i > 10000000)
                {
                    throw new Exception();
                }
                else
                {
                    this.playCount = this.playCount+1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("PlayCount yang dimasukkan melebihi batas!");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Id : "+id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Play Count : "+playCount);
            Console.WriteLine();
        } 
    }
}
