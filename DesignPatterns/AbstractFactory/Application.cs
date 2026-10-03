using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Application
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;
        public Application(IUIFactory factory)
        {
                _button=factory.CreateButton();
            _textBox = factory.CreateTextBox();
        }

        public void Paint()
        {
            _button.Render();
            _textBox.Display();
        }
    }
}
