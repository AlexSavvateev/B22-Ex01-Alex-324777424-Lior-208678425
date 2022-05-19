using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace B22_Ex03_Alex_324777424_Lior_208678425
{
    public class PhotoRandomizer : PhotoSelectionAlgorithmBase
    {

        private readonly Random r_Random = new Random();

        protected override Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album)
        {
            return i_Album[r_Random.Next(i_Album.Count)].ImageAlbum;
        }
    }
}
