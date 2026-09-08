using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ATC2027.Controls.UserControl.Abstract
{

    public interface ICombobox : IMonogameControl, IHasModifiableCandidateItems, IOneItemCanBeSelectedAndBeNull
    {
        public Bitmap DropDownButton { get; set; }
        public int selectedIndex { get; set; }
        public int lengthOfItemList { get; }
        public Collection<string> candidateOptions { get; set; }
        public void AddItemToCandidateOptions();

        public string GetSelectedItemAsString();

    }
}
