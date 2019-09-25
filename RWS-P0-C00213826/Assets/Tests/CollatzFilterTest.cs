using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CollatzFilterTest
    {
        [Test]
        public void CollatzSimple()
        {
            int[] input = { 1, 2, 5, 8, 0, -2 };
            int[] output = CollatzFilter.collatz(input);
            int[] expected = { 4, 1, 16, 4, 0, -1 };
            int[] incorrect = { 2, 4, 0, -1, 1000, 0 };

            CollectionAssert.AreNotEqual(incorrect, output);

            CollectionAssert.AreEqual(expected, output);
        }
    }
}