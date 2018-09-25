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
        public int NumOfPlaylists(int N, int K, int L)
        {
            int output = 0;
            int fact = 0;

            for (int i = 0; i < N; i++)
            {
                while (i != K)
                {
                    fact = Factorial((N - i));
                    i++;
                }
                output = fact * (N - K) ^ (N - i);
            }

            return output;
        }

        public static int Factorial(int n)
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
