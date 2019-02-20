using System;
using Xunit;
using TreeIntersectionChallenege;


namespace TreeIntersectionChallengeTests
{
    public class UnitTest1
    {
        [Fact]
        public void NoCommonValues()
        {
            Program.Node t1 = new Program.Node(1);
            Program.Node one1 = new Program.Node(1);
            Program.Node two1 = new Program.Node(1);
            Program.Node three1 = new Program.Node(1);
            Program.Node four1 = new Program.Node(1);
            Program.Node five1 = new Program.Node(1);
            Program.Node six1 = new Program.Node(1);

            t1.Left = one1;
            one1.Left = three1;
            one1.Right = four1;
            t1.Right = two1;
            two1.Left = five1;
            two1.Right = six1;

            Program.Node t2 = new Program.Node(2);
            Program.Node one2 = new Program.Node(2);
            Program.Node two2 = new Program.Node(2);
            Program.Node three2 = new Program.Node(2);
            Program.Node four2 = new Program.Node(2);
            Program.Node five2 = new Program.Node(2);
            Program.Node six2 = new Program.Node(2);

            t2.Left = one2;
            one2.Left = three2;
            one2.Right = four2;
            t2.Right = two2;
            two2.Left = five2;
            two2.Right = six2;

            Assert.True(Program.TreeIntersection(t1, t2).Count == 0);
        }
        [Fact]
        public void CommonValuesDupeInBoth()
        {
            Program.Node t1 = new Program.Node(1);
            Program.Node one1 = new Program.Node(1);
            Program.Node two1 = new Program.Node(1);
            Program.Node three1 = new Program.Node(1);
            Program.Node four1 = new Program.Node(1);
            Program.Node five1 = new Program.Node(2);
            Program.Node six1 = new Program.Node(2);

            t1.Left = one1;
            one1.Left = three1;
            one1.Right = four1;
            t1.Right = two1;
            two1.Left = five1;
            two1.Right = six1;

            Program.Node t2 = new Program.Node(1);
            Program.Node one2 = new Program.Node(1);
            Program.Node two2 = new Program.Node(2);
            Program.Node three2 = new Program.Node(2);
            Program.Node four2 = new Program.Node(2);
            Program.Node five2 = new Program.Node(2);
            Program.Node six2 = new Program.Node(2);

            t2.Left = one2;
            one2.Left = three2;
            one2.Right = four2;
            t2.Right = two2;
            two2.Left = five2;
            two2.Right = six2;

            Assert.True(Program.TreeIntersection(t1, t2).Count == 2);
        }
        [Fact]
        public void EmptyTrees()
        {
            Program.Node t1 = new Program.Node(1);
            Program.Node t2 = new Program.Node(2);

            Assert.True(Program.TreeIntersection(t1, t2).Count == 0);
        }
    }
}
