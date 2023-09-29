using MerchandiseSystem.Models;

namespace MerchandiseTest
{
    public class MerchandiseUnitTest
    {
        private readonly MainSystem _service;

        public MerchandiseUnitTest()
        {
            _service = new MainSystem();
        }


        [Fact]
        public void Add_Service_Result_True()
        {
            var result = _service.AddService("718392", "Mantenimiento hidrolavadora", 2700.0, true, 10.0);

            Assert.True(result);
        }

        [Fact]
        public void Add_Service_And_Validate_Result_True()
        {
            _service.AddService("7183921", "Mantenimiento hidrolavadora", 2700.0, true, 10.0);
            var result = _service.GetMerchandise("7183921");

            Assert.True(result.MerchandiseCode == "7183921");
        }

        [Fact]
        public void Add_Product_Result_True()
        {
            var result = _service.AddProduct("782951", "Disyuntor", 4500.0, true, 25.0);

            Assert.True(result);
        }

        [Fact]
        public void Add_Product_And_Validate_Result_True()
        {
            _service.AddProduct("7829512", "Disyuntor", 4500.0, true, 25.0);

            var result = _service.GetMerchandise("7829512");

            Assert.True(result.MerchandiseCode == "7829512");
        }

        [Fact]
        public void Calculate_Service_Final_Price()
        {
            _service.AddService("7183921", "Mantenimiento hidrolavadora", 2700.0, true, 10.0);

            var result = _service.GetMerchandise("7183921").calculateFinalPrice();

            Assert.True(result == 2430);
        }

        [Fact]
        public void Calculate_Product_Final_Price()
        {
            _service.AddProduct("7829512", "Disyuntor", 4500.0, true, 25.0);

            var result = _service.GetMerchandise("7829512").calculateFinalPrice();

            Assert.True(result == 3937.5);
        }

        [Fact]
        public void Add_Duplicated_Service_Result_False()
        {
            _service.AddService("2891728", "Mantenimiento aire acondicionado", 2250.0, false);

            var result = _service.AddService("2891728", "Mantenimiento aire acondicionado", 2250.0, false);

            Assert.False(result);
        }

        [Fact]
        public void Add_Duplicated_Product_Result_False()
        {
            _service.AddProduct("3780173", "Lampara led 9W", 330.0, true, 10.0);

            var result = _service.AddProduct("3780173", "Lampara led 9W", 330.0, true, 10.0);

            Assert.False(result);
        }
    }
}