using System;
using System.IO;

using Rhino;
using Rhino.Testing.Fixtures;

using NUnit.Framework;
using NUnit.Framework.Internal;
using MyRhinoPlugin1;

namespace SimpleNUnitTests
{
    [TestFixture]
    public sealed class TestDocument : RhinoTestFixture
    {
        [Test]
        public void TestOpen()
        {
            string output = Path.GetDirectoryName(GetType().Assembly.Location);
            string modelPath = Path.Combine(output, @"Files\circle.3dm");

            Assert.DoesNotThrow(() => RhinoDoc.Open(modelPath, out bool _));
        }

        [Test]
        public void TestOpenHeadless()
        {
            string output = Path.GetDirectoryName(GetType().Assembly.Location);
            string modelPath = Path.Combine(output, @"Files\circle.3dm");

            Assert.DoesNotThrow(() => RhinoDoc.OpenHeadless(modelPath));
        }

        [Test]
        public void TestRhinoCommand()
        {
            string output = Path.GetDirectoryName(GetType().Assembly.Location);
            string modelPath = Path.Combine(output, @"Files\circle.3dm");

            

            var doc = RhinoDoc.OpenHeadless(modelPath);

            var count = doc.Objects.Count;

            var myBrep = MyRhinoPlugin1.MyTestClass.GetABrep();
            Guid guid = doc.Objects.Add(myBrep);

            Assert.That(guid, Is.Not.EqualTo(Guid.Empty));

            Assert.That(doc.Objects.Count, Is.EqualTo(count + 1));
        }
    }
}
