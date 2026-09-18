using ATC2027.ATC_Library.CollectionRing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Forms
{
    public partial class ApplyClearanceForm : Form
    {
        CollectionRing collectionRing;
        public ApplyClearanceForm(ref CollectionRing collectionRing)
        {
            this.collectionRing = collectionRing;
            InitializeComponent();
        }

        private void ApplyClearanceForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbFlightNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
