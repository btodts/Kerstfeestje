using BalanceTheScale;
using Xunit;

namespace BalanceTheScaleTests
{
    public class ScaleTests
    {
        [Fact]
        public void A_Balanceable_Scale_Returns_The_Weights_Used()
        {
            var sut = new Scale(5, 9, new [] {1, 2, 6, 9});
            var result = sut.BalanceIt();

            Assert.Equal("Left: 6, Right: 2", result);
        }

        [Fact]
        public void A_Non_Balanceable_Scale_Returns_Error_Message()
        {
            var sut = new Scale(5, 9, new [] {1, 1, 1, 1});
            var result = sut.BalanceIt();

            Assert.Equal("No balance possible!", result);
        }
    }
}
