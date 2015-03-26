using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stfu_shared
{
    public class StfuException : Exception
    {
        private Exception mInner;

        public StfuException(Exception e)
            :base(e.Message, e)
        {
            mInner = (e.InnerException != null) ? e.InnerException : e;
        }

        public override string ToString()
        {
            return mInner.ToString();
        }
    }
}
