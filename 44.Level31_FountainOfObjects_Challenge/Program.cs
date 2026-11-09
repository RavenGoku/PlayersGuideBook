
/* ---------------- THE FOUNTAIN OF OBJECTS ----------------
                       Level 31
                        500 XP

   The Fountain of Objects has been destroyed by the
   Uncoded One. Explore a dark cavern, find the fountain,
   reactivate it, and return safely to the entrance.

   The cavern is a grid of rooms. You cannot see your
   surroundings and must rely on your senses.

   OBJECTIVES:

   1. Create a two-dimensional grid of rooms.
      Each room has a row and column.

   2. Create a game loop that:
      - Describes the player's surroundings.
      - Accepts a command.
      - Performs the action.
      - Checks the game state.

   3. Allow the player to move north, south, east,
      and west using text commands.
      Prevent movement outside the map.

   4. Start the player at (0, 0).
      This is the cavern entrance and exit.
      Describe the light visible at the entrance.

   5. Place the Fountain of Objects at (0, 2).
      It begins disabled.

   6. Describe the fountain differently depending
      on whether it is enabled or disabled.

   7. Allow "enable fountain" only when the player
      is standing in the fountain room.

   8. The player wins when they return to the
      entrance after activating the fountain.

   9. Use different console colours for narrative,
      descriptions, input, and fountain messages.

   10. Display an appropriate victory message
       when the player successfully escapes.

   NOTE:
   This is the base game. Pits, Amaroks, Maelstroms,
   and other expansions are separate challenges.

   ---------------------------------------------------------
*/


namespace _44.Level31_FountainOfObjects_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board newBoard = new();
        }
    }
}
