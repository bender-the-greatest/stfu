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

        private StfuException mException;

        /// <summary>
        /// Default constructor, used only for testing. frmError(StfuException) should be used instead.
        /// </summary>
        public frmError()
            : this(new StfuException(new Exception("This is just a test exception.")))
        { }

        public frmError(StfuException e)
            :this(e, string.Empty)
        { }

        public frmError(StfuException e, string prefix)
        {
            if (e == null) throw new ArgumentNullException("Exception cannot be null.");
            InitializeComponent();
            this.mException = e;
            this.txtMessage.Text = string.Format("{0}: {1}", (string.IsNullOrWhiteSpace(prefix)) ? string.Empty : prefix, e.Message);
            this.txtTrace.Text = e.StackTrace;
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            // Resize the window and make the trace box visible or invisible
            int lHeight = (this.txtTrace.Visible = !(this.Height == BIG_HEIGHT)) ? BIG_HEIGHT : ORIG_HEIGHT;
            this.MaximumSize = this.MinimumSize = new Size(this.Width, lHeight);
            this.Height = lHeight;
        }
    }
}
