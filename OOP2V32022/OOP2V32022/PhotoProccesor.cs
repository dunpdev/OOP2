using System;
using System.Threading;

namespace OOP2V32022
{
    
    public class PhotoProccesor
    {
         public delegate void PhotoFilterHandler(Photo photo);
        // public void Proccess(string url, PhotoFilterHandler photoFilterHandler)
        public void Proccess(string url, PhotoFilterHandler photoFilterHandler)
        {
            Photo photo = Photo.Load(url);
            Console.WriteLine("Base photo has been loaded!");
            Thread.Sleep(3000);

            photoFilterHandler(photo);
            //PhotoFilters.ApplyBrightness(photo);
            //PhotoFilters.ApplySmoothing(photo);

            photo.Save();
        }
    }
}
