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
        public void calculate_the_final_price()
        {
            sut.Add(10);

            sut.CalculateTotalPrice().Should().Be(10);
        }

        [Test]
        public void calculate_the_final_price_for_Items()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 10, price2 = 20;
            sut.AddItem(productId1, productName1, price1);
            sut.AddItem(productId2, productName2, price2);

            sut.CalculateTotalItemPrice().Should().Be(30);
        }

        [Test]
        public void knows_the_number_of_items()
        {
            sut.Add(10);

            sut.NumberOfProducts().Should().Be(1);
        }

        [Test]
        public void knows_the_number_of_items_in_list()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 10, price2 = 20;
            sut.AddItem(productId1, productName1, price1);
            sut.AddItem(productId2, productName2, price2);

            sut.NumberOfItemProducts().Should().Be(2);
        }

        [Test]
        public void may_offer_discounts_when_there_at_least_one_expensive_product()
        {
            sut.Add(120);

            sut.HasDiscount().Should().BeTrue();
        }

        [Test]
        public void may_offer_discounts_on_item_list_when_there_at_least_one_expensive_product()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 120, price2 = 20;
            sut.AddItem(productId1, productName1, price1);
            sut.AddItem(productId2, productName2, price2);

            sut.HasItemDiscount().Should().BeTrue();
        }

        [Test]
        public void does_not_offer_discount_for_cheap_products()
        {
            sut.Add(10);

            sut.HasDiscount().Should().BeFalse();
        }

        [Test]
        public void does_not_offer_discount_on_item_list_for_cheap_products()
        {
            int productId1 = 1, productId2 = 2;
            string productName1 = "Product1", productName2 = "Product2";
            decimal price1 = 10, price2 = 20;
            sut.AddItem(productId1, productName1, price1);
            sut.AddItem(productId2, productName2, price2);

            sut.HasItemDiscount().Should().BeFalse();
        }
    }
}
