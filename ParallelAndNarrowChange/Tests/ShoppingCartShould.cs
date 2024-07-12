using FluentAssertions;
using NUnit.Framework;
using ParallelAndNarrowChange.Field;

namespace ParallelAndNarrowChange
{
    [TestFixture]
    public class ShoppingCartShould
    {
        private IShoppingCart sut;

        [SetUp]
        public void SetUp()
        {
            sut = new ShoppingCart();
        }

        [Test]
        public void calculate_the_final_price_for_Items()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 10, price2 = 20;
            sut.Add(productId1, productName1, price1);
            sut.Add(productId2, productName2, price2);

            sut.CalculateTotalPrice().Should().Be(30);
        }

        [Test]
        public void knows_the_number_of_items_in_list()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 10, price2 = 20;
            sut.Add(productId1, productName1, price1);
            sut.Add(productId2, productName2, price2);

            sut.NumberOfProducts().Should().Be(2);
        }

        [Test]
        public void may_offer_discounts_on_item_list_when_there_at_least_one_expensive_product()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 120, price2 = 20;
            sut.Add(productId1, productName1, price1);
            sut.Add(productId2, productName2, price2);

            sut.HasDiscount().Should().BeTrue();
        }

        [Test]
        public void does_not_offer_discount_on_item_list_for_cheap_products()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 10, price2 = 20;
            sut.Add(productId1, productName1, price1);
            sut.Add(productId2, productName2, price2);

            sut.HasDiscount().Should().BeFalse();
        }
    }
}
