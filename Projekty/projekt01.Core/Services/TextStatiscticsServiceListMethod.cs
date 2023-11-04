using projekt01.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01.Core.Services
{
    public class TextStatiscticsServiceListMethod : BaseTextStatisticsService
    {
        public override TextStatisticsData CountStatistics(string text)
        {
            TextStatisticsData data = new TextStatisticsData();

            data.AllSymbolCount = text.Length;

            //Entropy
            double infoCharacter = 0;
            List<ElementOfCharList> elementOfCharLists = new List<ElementOfCharList>();

            //nie wiem czemu nie działa :c
            while (text.Length != 0)
            {
                char currentLetter = text[0];
                int currentLetterCount = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (currentLetter == text[i])
                    {
                        currentLetterCount++;
                        text = text.Remove(i, 1);
                        i--;
                    }
                    else continue;
                }
                elementOfCharLists.Add(new ElementOfCharList(currentLetter, currentLetterCount));
            }
            

            double freq;
            List<SymbolStatisticsData> symbolStatistics = new List<SymbolStatisticsData>();

            foreach (ElementOfCharList letter in elementOfCharLists)
            {
                freq = letter.Quantity / text.Length;
                SymbolStatisticsData symbol = new SymbolStatisticsData();
                symbol.Symbol = letter.Character;
                symbol.Frequency = letter.Quantity;
                symbol.Probability = letter.Quantity / (double)text.Length;
                symbol.InformationQuantity = Math.Log((double)1 / symbol.Probability, 2);
                symbolStatistics.Add(symbol);
                infoCharacter += symbol.Probability * symbol.InformationQuantity;
            }
            //infoCharacter *= -1;
            data.UniqueSymbolCount = symbolStatistics.Count();
            data.Entropy = infoCharacter;
            data.SymbolStatistics = symbolStatistics;

            return data;

        }
    }
}
