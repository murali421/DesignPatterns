using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageFactory imageFactory = new ImageFactory();

            var image = imageFactory.GetFlyWeight("image.jpg");

            image.Display(0, 0, 100, 120);

            image = imageFactory.GetFlyWeight("image.jpg");

            image.Display(10, 20, 200, 400);

            image = imageFactory.GetFlyWeight("image.jpg");

            image.Display(40, 60, 150, 200);


            image = imageFactory.GetFlyWeight("image1.jpg");

            image.Display(40, 60, 150, 200);


            image = imageFactory.GetFlyWeight("image1.jpg");

            image.Display(70, 60, 150, 200);

            Console.ReadKey();
        }
    }
}
