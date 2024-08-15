
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
                Assert.That(basket.items, Does.Contain(bagelName));
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
                Assert.That(basket.items, Does.Not.Contain(bagelName));
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
                int resultingLength = basket.items.Count;

                //assert
                Assert.IsTrue(length == resultingLength);
            }
        }

    }
}