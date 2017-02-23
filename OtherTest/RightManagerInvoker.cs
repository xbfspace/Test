using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest
{
    public class RightManagerInvoker
    {
        public static void AddRight() {
            var rightManager = new RightManager();
            //rightManager.OnRightAdded += RightManager_OnRightAdded;
            rightManager.OnRightAdded += RightManager_OnRightAdded1;
            rightManager.AddRight();
        }

        private static void RightManager_OnRightAdded1(object sender, RightAddedEventArgs e)
        {
            Console.WriteLine("add right from RightManagerInvoker");
        }

    }
}
