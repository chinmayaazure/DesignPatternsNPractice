using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    //Concrete Factory - Light Family
    public class LightUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }
}
