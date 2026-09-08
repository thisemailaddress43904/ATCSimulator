using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.UserControl.Abstract
{
    public interface IHasModifiableCandidateItems
    {
        public void AddItem(string item);
        public string RemoveItem(string str);
        public string RemoveItemAt(int index);
        public string AddItemAt(int index);
        public void SelectItemAt(int index);
        public void SelectItem(string item);
        public int GetNumberOfItems();
    }
}
