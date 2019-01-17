using System;
using Xunit;
using LinkedList.Classes;
using MergeList;

namespace MergeListTest
{
    public class UnitTest1
    {
        [Fact]
        public void ListsOfEqualLength()
        {
            LList lL1 = new LList();
            lL1.Insert(1);
            lL1.Insert(2);
            lL1.Insert(3);

            LList lL2 = new LList();
            lL2.Insert(5);
            lL2.Insert(6);
            lL2.Insert(7);

            LList solution = new LList();
            solution.Insert(5);
            solution.Insert(1);
            solution.Insert(6);
            solution.Insert(2);
            solution.Insert(7);
            solution.Insert(3);

            Assert.Equal(solution.Print(), Program.MergeLists(lL1, lL2).Print());
        }
        [Fact]
        public void ListOneLongerThanListTwo()
        {
            // 3 -> 2 -> 1 -> null
            LList lL1 = new LList();
            lL1.Insert(1);
            lL1.Insert(2);
            lL1.Insert(3);

            // 6 -> 5 -> null
            LList lL2 = new LList();
            lL2.Insert(5);
            lL2.Insert(6);

            // 3 -> 2 -> 6 -> 1 -> 5 -> null
            LList solution = new LList();
            solution.Insert(1);
            solution.Insert(5);
            solution.Insert(2);
            solution.Insert(6);
            solution.Insert(3);

            Assert.Equal(solution.Print(), Program.MergeLists(lL1, lL2).Print());
        }
        [Fact]
        public void ListTwoLongerThanListOne()
        {
            // 5 -> 1 -> null
            LList lL1 = new LList();
            lL1.Insert(1);
            lL1.Insert(5);


            // 3 -> 2 -> 6 -> 5 -> null
            LList lL2 = new LList();
            lL2.Insert(5);
            lL2.Insert(6);
            lL2.Insert(2);
            lL2.Insert(3);

            // 5 -> 3 -> 1 -> 2 -> 6 -> 5 -> null
            LList solution = new LList();
            solution.Insert(5);
            solution.Insert(6);
            solution.Insert(2);
            solution.Insert(1);
            solution.Insert(3);
            solution.Insert(5);


            Assert.Equal(solution.Print(), Program.MergeLists(lL1, lL2).Print());
        }
    }
}
