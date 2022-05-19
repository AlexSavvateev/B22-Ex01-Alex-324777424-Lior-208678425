using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B22_Ex03_Alex_324777424_Lior_208678425
{
    public class AscendingCollectionSortStrategy : ICollectionSortStrategy
    {
        public void Sort(List<string> collectionListToSort)
        {
            collectionListToSort.Sort((a, b) => a.CompareTo(b));
        }
    }
}