
using ConsoleApp1.Data;
using ConsoleApp1.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            IPresentation presentation = new PresentationLayer();
            presentation.Start();
        }

    }
}
