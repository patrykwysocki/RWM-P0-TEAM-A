using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            //Assert.IsTrue(false);

            int[] input = { 4,2,8 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 4,5,13};

            //foreach (var o in output)
            //{
            //    Debug.Log(o);
            //}

            CollectionAssert.AreEqual(expected, output);
        }
    }
}