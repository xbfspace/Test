using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest
{
    public class RightManager
    {
        //public delegate void RightAddedHandler();
        public event EventHandler<RightAddedEventArgs> OnRightAdded;
        public virtual void AddRight() {
            Console.WriteLine("add right from RightManager");
            RightAddedEventArgs args = new RightAddedEventArgs("code0");
            OnRightAdded(this,args);
        }

        public virtual void RemoveRight() {
            Console.WriteLine("remove right from RightManager");
        }

        public virtual void UpdateRight() {
            Console.WriteLine("update right from RightManager");
        }
    }

    public class RightAddedEventArgs : EventArgs {
        public readonly string RightCode;
        public RightAddedEventArgs(string rightCode) {
            RightCode = rightCode;
        }
    }
}
