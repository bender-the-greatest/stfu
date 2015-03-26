using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stfu_shared
{
    public partial class frmError : Form
    {
        private const short ORIG_HEIGHT = 115;
        private const short BIG_HEIGHT = 350;

        public frmError()
        {
            InitializeComponent();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            // 

            // resize the window accordingly
            int lHeight = (this.Height == BIG_HEIGHT) ? ORIG_HEIGHT : BIG_HEIGHT;
            this.MaximumSize = new Size(this.Width, lHeight);
            this.Height = lHeight;
        }
    }
}
