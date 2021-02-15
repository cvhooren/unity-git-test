using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MyTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MySimplePasses()
        {
            Assert.AreEqual(5, 5);
        }
    }
}
