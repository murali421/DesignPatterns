using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal abstract class BaseImage
    {
        internal abstract void Display(int x, int y, int height, int width);
    }
}
