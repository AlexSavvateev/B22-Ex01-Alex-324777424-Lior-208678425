using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B22_Ex03_Alex_324777424_Lior_208678425
{
    public class DescendingArtistSortStrategy : IArtistSortStrategy
    {
        public void Sort(List<string> artistListToSort)
        {
            artistListToSort.Sort((a, b) => b.CompareTo(a));
        }
    }
}
