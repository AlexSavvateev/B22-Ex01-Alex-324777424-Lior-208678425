using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace B22_Ex03_Alex_324777424_Lior_208678425
{
    public abstract class PhotoSelectionAlgorithmBase
    {
        public Image GetPhoto(User i_FacebookUser)
        {

            FacebookObjectCollection<Photo> taggedPictures = i_FacebookUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            return GetImageFromAlbum(taggedPictures);
        }

        protected abstract Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album);
    }
}