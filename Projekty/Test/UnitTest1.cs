using System;
using projekt01.Core.Services;
using projekt01.Shared.Entities;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var text = "Sample text for testing purposes.";
            var service = new TextStatisticsService();

            // Act
            var result = service.CountStatistics(text);

            // Assert
            Assert.Equal(text.Length, result.AllSymbolCount);
            Assert.True(result.UniqueSymbolCount > 0);
            Assert.True(result.Entropy > 0);
            Assert.NotNull(result.SymbolStatistics);
            Assert.Equal(GetTotalFrequency(result.SymbolStatistics), text.Length);

        }

        private int GetTotalFrequency(System.Collections.Generic.List<SymbolStatisticsData> symbolStatistics)
        {
            int totalFrequency = 0;

            foreach (var symbol in symbolStatistics)
            {
                totalFrequency += symbol.Frequency;
            }

            return totalFrequency;
        }
    }
}