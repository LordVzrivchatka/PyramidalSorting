using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КУРСАЧ
{
    public class RandGeneration
    {
        public int[] RandGen(int count, int from, int to)
        {
            int[] arr = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; ++i)
            {
                arr[i] = rand.Next(from, to);
            }
            return arr;
        }
    }
}
