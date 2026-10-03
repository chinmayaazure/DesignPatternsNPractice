using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    //Concrete Product - Light Family
    public class LightButton:IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Button in Light Theme.");
        }
    }
}
