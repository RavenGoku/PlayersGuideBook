// See https://aka.ms/new-console-template for more information

/*
=========================== { Simula’s Test 100 XP } ============================

As you move through the village of Enumerant, you notice a short, cloaked figure following you. Not
being one to enjoy a mysterious figure tailing you, you seize a moment to confront the figure. “Don’t be
alarmed!” she says. “I am Simula. They are saying you’re a Programmer. Is this true?” You answer in the
affirmative, and Simula’s eyes widen. “If you are truly a Programmer, you will be able to help me. Follow
me.” She leads you to a backstreet and into a dimly lit hovel. She hands you a small, locked chest. “We
haven’t seen any Programmers in these lands in a long time. And especially not ones that can craft types.
If you are a True Programmer, you will want what is in that chest. And if you are a True Programmer, I
will gladly give it to you to aid you in your quest.”
The chest is a small box you can hold in your hand. The lid can be open, closed (but unlocked), or locked.
You’d normally be able to go between these states, opening, closing, locking, and unlocking the box, but
the box is broken. You need to create a program with an enumeration to recreate this locking mechanism.
The image below shows how you can move between the three states:

        OPEN->close->CLOSED->lock->LOCKED->unlock->CLOSED->open->OPEN

Nothing happens if you attempt an impossible action in the current state, like opening a locked box.
The program below shows what using this might look like:
The chest is locked. What do you want to do? unlock
The chest is unlocked. What do you want to do? open
The chest is open. What do you want to do? close
The chest is unlocked. What do you want to do?

Objectives:
    • Define an enumeration for the state of the chest.
    • Make a variable whose type is this new enumeration.
    • Write code to allow you to manipulate the chest with the lock, unlock, open, and close
    commands, but ensure that you don’t transition between states that don’t support it.
    • Loop forever, asking for the next command.

 */

using System.Net.Sockets;

ChestState chest = ChestState.Locked;

Console.WriteLine($"Simulas chest is Locked.\nManipulate the chest with the: 'lock', 'unlock', 'open', and 'close' words to try open it.");

while (true)
{
    Console.Write($"The chest is '{chest}'.What do you want to do? ");
    string action = Console.ReadLine();

    switch (chest)
    {
        case ChestState.Locked:
        if (action == "unlock") chest = ChestState.Unlocked;
        else
            Console.WriteLine("You can unlock\n");
        break;
        
        case ChestState.Unlocked:
        if (action == "open") chest = ChestState.Open;
        else if (action == "lock") chest = ChestState.Locked;
        else
            Console.WriteLine("You can 'open' or 'lock'\n");
        break;

        case ChestState.Open:
        if (action == "close") chest = ChestState.Unlocked;
        else
            Console.WriteLine("You can 'close'\n");
        break;

        default:
        break;
    }

    if (action == "exit")
    {
        Console.WriteLine("Game End");
        break;
    }

}




enum ChestState {Unknown = 0, Locked,Unlocked,Open};
