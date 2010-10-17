﻿using System;
using NGenerics.DataStructures.Trees;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.BinarySearchTreeTests
{
    [TestFixture]
    public class Maximum : BinarySearchTreeTest
    {

        [Test]
        public void Simple()
        {
            var tree = GetTestTree();
            var i = tree.Maximum;

            Assert.AreEqual(i.Key, 19);
            Assert.AreEqual(i.Value, "19");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionInvalidMax()
        {
            var tree = new BinarySearchTree<int, string>();
            var i = tree.Maximum;
        }

    }
}