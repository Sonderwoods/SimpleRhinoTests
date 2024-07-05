using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject1
{
    namespace SimpleXUnitTests
    {
        
        public sealed class SetupFixture : Rhino.Testing.Fixtures.RhinoSetupFixture, IDisposable
        {

            public SetupFixture()
            {

                base.OneTimeSetup();

                // your custom setup
            }

            public void Dispose()
            {
                base.OneTimeTearDown();

                // you custom teardown
            }


            [Fact]
            public void Test1()
            {
                var x = MyRhinoPlugin2.MyTestClass.GetABrep();
            }
        }
    }

}
