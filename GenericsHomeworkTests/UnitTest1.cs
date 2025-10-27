using GenericsHomework;
using Xunit;

namespace GenericsHomeworkTests
{
    public class UnitTest1
    {
        public record class TestClass(string Name, int Id);

        [Fact]
        public void Name_SingleNodeLinkedList_NextIsSetToSelf()
        {
            //Arrange
            int input = 0;
            Node<int> node = new(input);

            //Act
            Node<int> next = node.Next;

            //Assert
            Assert.Equal(node, next);
        }
        [Fact]
        public void Node_InputIsTestClass_NodeIsAbleToStoreData()
        {
            //Arrange
            TestClass testClass = new("WowImmaTestClass", 1234);

            //Act
            Node<TestClass> node = new(testClass);

            //Assert
            Assert.Equal(testClass, node.Data);
        }
        [Fact]
        public void Append_InputInt_FirstNodeNextIsSecondNode ()
        {
            //Arrange
            int nodeTwoData = 1;
            Node<int> node = new(0);

            //Act
            node.Append(nodeTwoData);

            //Assert
            Assert.Equal(1, node.Next.Data);
        }
        [Fact]
        public void Append_InputTestClass_FirstNodeNextIsSecondNode()
        {
            //Arrange
            TestClass secondNodeData = new("OmgHolyS***ImStillATestClass", 1222);
            Node<TestClass> node = new(new TestClass("IamADifferentTestClass", 1233));

            //Act
            node.Append(secondNodeData);

            //Assert
            Assert.Equal(secondNodeData, node.Next.Data);
        }
        [Fact]
        public void Append_InputInt_LastNodeCirclesToFront()
        {
            //Arrange
            int nodeOneData = 0;
            Node<int> node = new(nodeOneData);

            //Act
            node.Append(1);

            //Assert
            Assert.Equal(0, node.Next.Next.Data);
        }
        [Fact]
        public void Append_InputTestClass_LastNodeCirclesToFront()
        {
            //Arrange
            TestClass firstNodeData = new("AlrightGuysThisIsGettingWeird", 1222);
            Node<TestClass> node = new(firstNodeData);

            //Act
            node.Append(new TestClass("IamADifferentTestClass", 1233));

            //Assert
            Assert.Equal(firstNodeData, node.Next.Next.Data);
        }
        [Fact]
        public void Append_AppendingMultiple_EachNodesNextIsCorrect()
        {
            //Arrange
            //These Are not directly Used but they are here to demonstrate
            //The data added in the for loop
            int nodeOneData = 0;
            int oneNextData = 1;
            int twoNextData = 2;
            int threeNextData = 3;
            int fourNextData = nodeOneData;
            Node<int> node = new(nodeOneData);

            //Act
            Node<int> cur = node;
            for (int i = 1; i < 4; i++)
            {
                cur.Append(i);
                cur = cur.Next;
            }
            Node<int> node2 = node.Next;
            Node<int> node3 = node2.Next;
            Node<int> node4 = node3.Next;

            //
            Assert.Equal(oneNextData, node.Next.Data);
            Assert.Equal(twoNextData, node2.Next.Data);
            Assert.Equal(threeNextData, node3.Next.Data);
            Assert.Equal(fourNextData, node4.Next.Data);
        }
        [Fact]

    }
}
