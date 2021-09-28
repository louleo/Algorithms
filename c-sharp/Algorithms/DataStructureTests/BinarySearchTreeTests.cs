using System.Collections.Generic;
using System.Linq;
using DataStructure;
using FluentAssertions;
using Xunit;

namespace DataStructureTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void Test_BinarySearchTree_Deletion()
        {
            int[] arr = new []{7,3,4,5,1,2,10,8,9,12,11,13};
            BinarySearchTree bst = new BinarySearchTree(arr);
            List<int> list = arr.ToList();
            bst.Delete(10);
            list.Remove(10);
            list.Sort();
            List<int> result = (List<int>) bst.ToList();
            result.Should().Equal(list);
        }
    }
}