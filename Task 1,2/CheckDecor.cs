using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1And2;

namespace Task_1_2
{
    public class CheckDecor : IViewerBuy
    {
        public void ViewerBuy(Buy buy)
        {
            Console.WriteLine("*********\n" + buy + "\n**********");
        }
    }
}
