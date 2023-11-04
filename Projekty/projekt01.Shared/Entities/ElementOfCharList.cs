using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01.Shared.Entities
{
    public class ElementOfCharList
    {
        public char Character { get; set; }
        public int Quantity { get; set; }
        public ElementOfCharList(char pCharacter, int pQuantity) 
        {
            Character = pCharacter;
            Quantity = pQuantity;
        }
    }
}
