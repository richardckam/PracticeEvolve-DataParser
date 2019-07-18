using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.IO.UnitTest
{
    internal class AssertExtension
    {
        public static void DoesNotThrow<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                Assert.Fail(String.Format("{0} was thrown.", typeof(TException).Name ));
            }
            catch
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(true);
        }
    }
}
