using projekt01.Shared.Entities;
using projekt01.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projekt01.Core.Services
{
    public class TextAnalyzerService : ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis(string text)
        {
            TextAnalyzeResult result = new TextAnalyzeResult();

            result.textLength = text.Length;

            result.hasLetters = Regex.IsMatch(text, ".*[a-zA-Z].*");

            result.hasDigits = Regex.IsMatch(text, ".*[0-9].*");

            result.hasSpecialChars = Regex.IsMatch(text, ".*[@_!#$%^&*()<>?}{~:].*");

            return result;

        }
    }
}
