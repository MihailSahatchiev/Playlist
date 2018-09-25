using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Playlist
    {
        public int NumOfPlaylists(int numSongs, int timesPlayed, int length)
        {
            int answer = 0;
            int calculate = 0;

            for (int i = 0; i < numSongs; i++)
            {
                while (i != timesPlayed)
                {
                    calculate = Calc((numSongs - i));
                    i++;
                }
                answer = calculate * (numSongs - timesPlayed) ^ (numSongs - i);
            }

            return answer;
        }

        public static int Calc(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Playlist pl = new Playlist();
            Console.WriteLine("Number of songs: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Play times: ");
            int k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Playlist quantity: ");          
            int l = Int32.Parse(Console.ReadLine());
            int toReturn = pl.NumOfPlaylists(n, k, l);
            Trace.WriteLine(toReturn.ToString());
        }
    }
}
