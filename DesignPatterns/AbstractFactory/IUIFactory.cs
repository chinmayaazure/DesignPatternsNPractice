using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    //Abstract Factory
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
