using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Unity.TestProtocol.Messages;

class SanityTests {

	[Test]
	public void SanityTest()
    {
        Assert.That(() => InfoMessage.Create("test"), Throws.Nothing);
    }
}
