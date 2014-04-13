using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.IO;

namespace CommonLib
{
    public class ImplementationClass : Component, ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("ImplementationClass.SampleMethod");
        }
    }
}
