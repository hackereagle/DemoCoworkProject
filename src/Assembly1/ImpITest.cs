using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RORZE
{
    public class ImpITest : ITest
    {
        private InternalClass ttt;

        public ImpITest()
        {
            ttt = new InternalClass();

        }

        string ITest.testing()
        {
            ttt.InternalClassDoSomething();
            return "ImpITest testing";

        }
    }
}
