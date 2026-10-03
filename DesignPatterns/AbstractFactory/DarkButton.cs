using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
     //Concrete Product (Dark Family)
    public class DarkButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Button in Dark Theme.");
        }
    }
}
