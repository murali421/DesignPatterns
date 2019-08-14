using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class ImageFactory
    {
        private Dictionary<string, BaseImage> images = new Dictionary<string, BaseImage>();
        internal BaseImage GetFlyWeight(string fileName)
        {
            if (images.ContainsKey(fileName))
            {
                Console.WriteLine("Retriving from the existing Object");
                return images[fileName];
            }
            else
            {
                Console.WriteLine("New Object Created");                
                BaseImage image = new Image(fileName);
                images.Add(fileName, image);
                return image;
            }
        }
    }
}
