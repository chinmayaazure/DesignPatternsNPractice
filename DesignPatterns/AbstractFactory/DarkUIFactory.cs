using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    //Concrete Factory - Dark Family
    public class DarkUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }
}
