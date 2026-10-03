using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    //Concrete Produtc - Light Family
    public class LightTextBox:ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Display TextBox in Light Theme.");
        }
    }
}
