using System;
using System.Collections.Generic;
using System.Text;

namespace WarPreparationChallenge
{
    public record Sword(
        SwordMaterial Material,
        float SwordLength,
        float CrossguardWidth,
        Gemstone Gemstone = Gemstone.None)
    {
        public override string ToString()
        {
            return $"{Material} Sword\n" +
                   $"Length: {SwordLength}\n" +
                   $"Crossguard: {CrossguardWidth}\n" +
                   $"Gemstone: {Gemstone}\n";
        }
    }
}