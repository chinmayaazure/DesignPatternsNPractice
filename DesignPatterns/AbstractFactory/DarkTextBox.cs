using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    //Concrete Product (Dark Family)
    public class DarkTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Display TextBox in Dark Theme.");
        }
    }
}
