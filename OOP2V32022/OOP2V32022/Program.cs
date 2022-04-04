using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V32022
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoProccesor photoProccesor = new PhotoProccesor();
            PhotoFilters photoFilters = new PhotoFilters();
            PhotoProccesor.PhotoFilterHandler photoFilterHandler = PhotoFilters.ApplyBrightness;
            photoFilterHandler += RedEyeFilter;

            photoProccesor.Proccess("https://dunp.ac.rs/images/nature.png",photoFilterHandler);

            Console.ReadLine();
        }

        public static void RedEyeFilter(Photo photo)
        {
            Console.WriteLine($"On photo {photo.Title} we apply removing red eye!");
        }
    }
}

/*
 lista delegata
      brightness
      redeye
 */
