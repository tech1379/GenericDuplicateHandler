using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace GenericDuplicateHandler
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void DuplicateHandler_TestOne()
        {
            var newListString = new List<string>
            {
                "Hello",
                "World",
                "Hello",
                "Hello"
            };
            var handler = new DuplicateHandler<string>();
            var output = handler.RemoveDuplicates(newListString);
            
           Assert.That(output, Is.Unique);
        }
    }
}
