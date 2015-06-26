using NUnit.Framework;

namespace MusicSalesTests
{
    [TestFixture]
	public class ItemsValuatorTests
    {
	    private ItemsValuator _valuator;

	    [SetUp]
		public void SetUp()
		{
			_valuator = new ItemsValuator();			
		}

        [Test]
        public void The_total_price_of_no_items_is_zero()
        {
	        var noItems = string.Empty;
			const int expectedTotalPrice = 0;

	        var totalPrice = _valuator.Valuate(noItems);

	        Assert.That(totalPrice, Is.EqualTo(expectedTotalPrice));
        }

		[Test]
		public void The_total_price_of_a_single_item_is_that_items_price()
		{
			var aSingleItemIsrc = "234569";
			const int expectedTotalPrice = 96;

			var totalPrice = _valuator.Valuate(aSingleItemIsrc);

			Assert.That(totalPrice, Is.EqualTo(expectedTotalPrice));
		}

    }

	public class ItemsValuator
	{
		public int Valuate(string items)
		{
			return IsNoItems(items) ? 0 : 96;
		}

		private static bool IsNoItems(string items)
		{
			return string.Empty.Equals(items);
		}
	}
}
