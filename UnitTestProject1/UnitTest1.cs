using SystemZamowienKoszulek_2.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void AddItemToCartTest_AddingItem_ItemAdded()
        {
            //Arrange
            var cart = new Cart(1000001);
            var item = new Item(Type.Male, Size.Xxl, Name.Koszulka, 10.00);

            //Act
            var result = cart.AddItemToCart(item);

            //Assert
            Assert.AreEqual(item, result);
        }

        [TestMethod]
        public void RemoveItemFromCartTest_RemovingItem_ItemWithIdIsRemoved()
        {
            //Arrange
            var cart = new Cart(1000001);
            var item = new Item(Type.Female, Size.S, Name.Koszulka, 25.00);
            cart.List.Add(item);

            //Act
            var result = cart.RemoveItemFromCart(item.Id);
            var isRemoved = true;
            foreach (var element in cart.List)
                if (element.Id == item.Id)
                    isRemoved = false;

            //Assert
            Assert.AreEqual(item, result);
            Assert.IsTrue(isRemoved);
        }

        [TestMethod]
        public void ReturnNameAndAmountTest_AddingAndReturningValues_ReturnedGoodAmounts()
        {
            //Arrange
            var cart = new Cart(1000001);
            var item1 = new Item(Type.Female, Size.S, Name.Koszulka, 25.00);
            var item2 = new Item(Type.Female, Size.S, Name.Koszulka, 30.00);
            var item3 = new Item(Type.Female, Size.S, Name.Kubek, 25.00);
            cart.AddItemToCart(item1);
            cart.AddItemToCart(item2);
            cart.AddItemToCart(item3);

            //Act
            var result = cart.ReturnNameAndAmount();

            //Assert
            Assert.IsTrue(result[Name.Koszulka] == 2);
            Assert.IsTrue(result[Name.Kubek] == 1);
        }
    }

    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddingItemToOrderTest_AddingToOrderWhenStatusIsPayment_ReturnTrue()
        {
            //Arrange
            var order = new Order();
            order.State = State.Payment;
            var item = new Item();

            //Act
            var result = order.AddProduct(item);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddingItemToOrderTest_AddingToOrderWhenStatusIsChecked_ReturnFalse()
        {
            //Arrange
            var order = new Order();
            order.State = State.Checked;
            var item = new Item();

            //Act
            var result = order.AddProduct(item);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddingItemToOrderTest_AddingToOrderWhenStatusIsRelease_ReturnFalse()
        {
            //Arrange
            var order = new Order();
            order.State = State.Release;
            var item = new Item();

            //Act
            var result = order.AddProduct(item);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RemovingItemFromOrderTest_RemovingFromOrderWhenStatusIsPayment_ReturnTrue()
        {
            //Arrange
            var order = new Order();
            var item = new Item();
            order.AddProduct(item);
            order.State = State.Payment;

            //Act
            var result = order.RemoveProduct(item.Id);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemovingItemFromOrderTest_RemovingFromOrderWhenStatusIsChecked_ReturnFalse()
        {
            //Arrange
            var order = new Order();
            var item = new Item();
            order.AddProduct(item);
            order.State = State.Checked;

            //Act
            var result = order.RemoveProduct(item.Id);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RemovingItemFromOrderTest_RemovingFromOrderWhenStatusIsRelease_ReturnFalse()
        {
            //Arrange
            var order = new Order();
            var item = new Item();
            order.AddProduct(item);
            order.State = State.Release;

            //Act
            var result = order.RemoveProduct(item.Id);

            //Assert
            Assert.IsFalse(result);
        }
    }
}