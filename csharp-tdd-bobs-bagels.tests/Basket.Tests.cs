
using NUnit.Framework;
using System.ComponentModel;
using tdd_bobs_bagels.CSharp.Main;


namespace csharp_tdd_bobs_bagels.tests
{
    public class Tests
    {
        [TestFixture]
        public class BasketTests
        {
            [TestCase("cremeCheese")]
            // Test for story 1
            public void Test1(string bagelName) 
            {
                //arrange 
                Basket basket = new Basket();


                //act
                basket.add(bagelName);

                //assert
                Assert.That(basket.Items, Does.Contain(bagelName));
            }
            [TestCase("cremeCheese")]
            // Test for story 2
            public void Test2(string bagelName)
            {
                //arrange 
                Basket basket = new Basket();
                basket.add(bagelName);

                //act
                basket.remove(bagelName);

                //assert
                Assert.That(basket.Items, Does.Not.Contain(bagelName));
            }
            [TestCase("cremeCheese",4)]
            // Test for story 3
            public void Test3(string bagelName, int length)
            {
                //arrange 
                Basket basket = new Basket();
                basket.add(bagelName);
                basket.add(bagelName);
                basket.add(bagelName);
                basket.add(bagelName);
                basket.add(bagelName);

                //act
                basket.remove(bagelName);
                int resultingLength = basket.Items.Count;

                //assert
                Assert.IsTrue(length == resultingLength);
            }
            [TestCase(100)]
            // Test for story 4
            public void Test4(int capacity)
            {
                //arrange 
                Basket basket = new Basket();


                //act
                basket.changeCap(100);

                int resultingCapacity = basket.Capacity;

                //assert
                Assert.IsTrue(resultingCapacity == capacity);
            }
            [TestCase("cremeCheese")]
            public void Test5(string bagelName)
            {
                //arrange 
                Basket basket = new Basket();


                //act
                bool returnResult = basket.remove(bagelName);


                //assert
                Assert.IsTrue(returnResult == false) ;
            }
        }

    }
}