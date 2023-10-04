using projekt01.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01.Shared.Interfaces
{
    public interface ITextAnalyzerService
    {
        TextAnalyzeResult PerformAnalysis(string text);
    }
}
