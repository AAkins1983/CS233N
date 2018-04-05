using System;

namespace ProductMaint
{
    // This application is described in chapter 14 of
    // "Murach's C# 2008" by Joel Murach
    // (c) 2008 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class Software : Product
	{
		private string version;

        public Software()
		{
		}

        public Software(string code, string description, string version,
            decimal price) : base(code, description, price)
        {
            this.Version = version;
        }

        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + ", Version " + Version;
        }

	}
}
