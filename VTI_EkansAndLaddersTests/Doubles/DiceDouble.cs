using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLaddersTests.Doubles
{
    internal class DiceDouble : IDice
    {
        public int ValueToReturn { get; set; }
        public int Roll()
        {
            return ValueToReturn;
        }
    }
}