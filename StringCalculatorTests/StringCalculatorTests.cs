using NUnit.Framework;

namespace CodingKata
{
    public class StringCalculatorTests
    {
        [Test]
        public void WhenCtorCallled_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => _ = new StringCalculator());
        }
    }
}