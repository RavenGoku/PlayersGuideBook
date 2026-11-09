/* -------------------- WAR PREPARATIONS --------------------
                     Level 29 - Records
                          100 XP

   As you pass through Rocaard, two blacksmiths,
   Cygnus and Lyra, ask for your help.

   They need a program to assist them in crafting
   enchanted swords for an army preparing to fight
   the Uncoded One's forces.

   OBJECTIVES:

   1. Create an enumeration for sword materials:
      Wood, Bronze, Iron, Steel, Binarium.

   2. Create an enumeration for gemstone types:
      Emerald, Amber, Sapphire, Diamond, Bitstone,
      and the option of having no gemstone.

   3. Create a Sword record containing:
      - Material
      - Gemstone
      - Length
      - Crossguard width

   4. In your main program, create a basic iron
      sword without a gemstone.

   5. Create two variations of the original sword
      using 'with' expressions.

   6. Display all three swords using Console.WriteLine().

   ----------------------------------------------------------
*/

using WarPreparationChallenge;


Sword basicSword = new Sword(SwordMaterial.Iron, 100, 20);
Sword magicSword = basicSword with { Material = SwordMaterial.Binarium, Gemstone = Gemstone.Emerald };
Sword longSword = basicSword with { Material = SwordMaterial.Steel, SwordLength = 150 };

Console.WriteLine(basicSword);
Console.WriteLine(magicSword);
Console.WriteLine(longSword);