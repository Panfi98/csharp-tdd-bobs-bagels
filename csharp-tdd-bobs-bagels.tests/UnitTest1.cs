
using NUnit.Framework;
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
            public void Test(string bagelName) {
                //arrange 
                Basket basket = new Basket();


                //act
                int result;

                //assert
                Assert.That(basket.items, Does.Contain(bagelName));
            }
        }
    }
}