using System;
using Xunit;
using TicketService;
using Moq;

namespace TicketService.Tests
{
    public class TicketServiceTest
    {
        ITicketService sut;
        Mock<IPriceProvider> providerMock;

        public TicketServiceTest()
        {
            sut = new TicketService();
            providerMock = new Mock<IPriceProvider>();
        }
        
        [Fact]
        public void CountPrice_ForAdultsInTheEvning_ReturnsDublePrice()
        {
            // Arrange
            bool isAdult = true;
            bool isEvning = true;
            decimal expectedPrice = 500;
            providerMock.Setup(x => x.GetPriceForAdult()).Returns(250);

            // Act 
            var result = sut.CountPrice(isAdult, isEvning, providerMock.Object);

            // Assert
            Assert.Equal(expectedPrice, result);
            providerMock.Verify(x => x.GetPriceForAdult(), Times.Once);
            providerMock.Verify(x => x.GetPriceForChild(), Times.Never);
        }
    }
}
