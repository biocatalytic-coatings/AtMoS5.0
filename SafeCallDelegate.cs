using System;

namespace AtMoS3
{
    internal class SafeCallDelegate
    {
        private Action setText;

        public SafeCallDelegate(Action setText)
        {
            this.setText = setText;
        }
    }
}