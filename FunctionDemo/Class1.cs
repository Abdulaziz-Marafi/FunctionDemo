using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    public  class Class1
    {
       public  double calculateVolume(double length, double width, double height)
        {
            return length * width * height;
        }
       public  double calculateVolume(double length, double width)
        {
            return length * width;
        }
    }
}
