using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
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
                var handler = new GenericDuplicateHandler.DuplicateHandler<string>();
                var output = handler.RemoveDuplicates(newListString);

                Assert.That(output, Is.Unique);
            }
        }
    }
}