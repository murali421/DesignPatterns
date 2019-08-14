using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Image : BaseImage
    {
        private readonly string fileName;

        public Image(string fileName)
        {
            this.fileName = fileName;
        }
        internal override void Display(int x, int y, int height, int width)
        {
            Console.WriteLine($"<img src='{fileName}' style='left:{x}px top:'{y}'px height='{height}'px width='{width}'px />");
        }
    }
}
