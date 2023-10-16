using projekt01.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01.Core.Services
{

    public class BaseTextStatisticsServicePresenter : BaseTextStatisticsService
    {
        public override TextStatisticsData CountStatistics(string text)
        {
            TextStatisticsData data = new TextStatisticsData();

            data.AllSymbolCount = text.Length;
            data.UniqueSymbolCount = text.Distinct().Count();

            //Entropy
            double infoCharacter = 0;
            Dictionary<char, double> table = new Dictionary<char, double>();

            foreach (char c in text)
            {
                if(table.ContainsKey(c)) { table[c]++; }
                else { table.Add(c, 1); }
            }

            double freq;
            List<SymbolStatisticsData> symbolStatistics = new List<SymbolStatisticsData>();

            foreach (KeyValuePair<char, double> letter in table) 
            {
                freq = letter.Value / text.Length;
                SymbolStatisticsData symbol = new SymbolStatisticsData();
                symbol.Symbol = letter.Key;
                symbol.Frequency = letter.Key;
                symbol.Probability = letter.Value / (double)text.Length;
                symbol.InformationQuantity = 123;
                symbolStatistics.Add(symbol);
                infoCharacter += freq*Math.Log(freq)/Math.Log(2);
            }
            infoCharacter *= -1;

            data.Entropy = infoCharacter;

            //SymbolStatistics
            foreach (char c in text) 
            {
                
            }


            return data;
            
        }
    }
}
