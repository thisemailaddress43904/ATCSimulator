using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.UserControl.Abstract
{
    public interface ISwitch : IMonogameControl
    {
        public bool IsSetToTrue();
        public string GetLabelContent();
        public void SetLabelContent(string str);
    }
}
