using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.UserControl.Abstract
{
    public interface ITextBox : ILabel
    {
        public void AppendToContent(char character);
        public char OppendFromContent();
}

}
