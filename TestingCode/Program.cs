/*The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be
destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your
programming skills will you have a chance to win this fight. You must build a program that allows one
user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
town.

The first user begins by secretly establishing how far the Manticore is from the city, in the range 0 to 100.
The program then allows a second player to repeatedly attempt to destroy the airship by picking the
range to target until either the city of Consolas or the Manticore is destroyed. In each attempt, the player
is told if they overshot (too far), fell short (not far enough), or hit the Manticore. The damage dealt to the
Manticore depends on the turn number. For most turns, 1 point of damage is dealt. But if the turn number
is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of
damage, and if it is a multiple of both 3 and 5, a mighty fire-electric blast deals 10 points of damage. The
Manticore is destroyed after taking 10 points of damage.

However, if the Manticore survives a turn, it will deal a guaranteed 1 point of damage to the city of
Consolas. The city can only take 15 points of damage before being annihilated.
Before a round begins, the user should see the current status: the current round number, the city’s health,
and the Manticore’s health. */

//============================ Functions ======================================================================
void Welcome_Display()
{
    Console.WriteLine(@"The skies over Consolas have turned the color of bruised iron.

        From the digital abyss, the Uncoded One has sent his ultimate weapon: the Manticore.
    This massive, shadow-draped airship now hovers on the horizon, its weapons
    humming with a virus meant to erase the city entirely. If it breaches the perimeter,
    Consolas will fall.
    Your only hope lies in an impossible alliance. By combining Mylara’s advanced tech
    prototype, Skorin’s devastating defense cannon.

    But first, you must find the target. The Manticore has masked its position in the fog,
    and the city's shields are already bleeding power under its relentless barrage.
    Boot up the system, calibrate the cannon, and find that airship before Consolas is
    wiped from the map." + "\n\n");
}
//******************************************************************************************

int ask_for_number(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int ask_for_number_range(string text,int min, int max)
{
    int number = 0;
    while (true)
    {
        number = ask_for_number(text);
        if (number < min || number > max)
        {
            Console.WriteLine("Number is out of range, please try again.\n");
        }else
            break; 
    }
    return number;

}

void DisplayStatus(int game_round, int city_life,int city_hp, int manticore_life, int manti_hp)
{
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {game_round}   City: {city_hp}/{city_life}  manticore: {manti_hp}/{manticore_life}");
}
int Cannon_damage_points(int game_round)
{
    int damage = (game_round % 3 == 0, game_round % 5 == 0) switch
    {
        (true, true) => 10,
        (true, false) => 3,
        (false, true) => 3,
        (false, false) => 1
    };

    if (game_round % 3 == 0 && game_round % 5 == 0)
    {
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("(10) Electric and Fire ");
        Console.ResetColor();
        Console.WriteLine("damage this round.");
    }
    else if (game_round % 3 == 0)
    {
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("(3) Fire ");
        Console.ResetColor();
        Console.WriteLine("damage this round.");
    }
    else if (game_round % 5 == 0)
    {
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("(3) Electric ");
        Console.ResetColor();
        Console.WriteLine("damage this round.");
    }
    else
    {
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("(1) Normal ");
        Console.ResetColor();
        Console.WriteLine("damage this round.");
    }

    return damage;
}
bool is_number_guessed(int manti_distance)
{
    int number = ask_for_number("Enter desired cannon range:  ");
    
    if (number < manti_distance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"That round went lower!");
        Console.ResetColor();

        return false;
    }
    else if (number > manti_distance)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"That round went too high!");
        Console.ResetColor();
        return false;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOU HIT THE MANTICORE!");
        Console.ResetColor();
        return true;
    }
}
int Hit_Resolve(int cannon_attack,int manti_distance, int manti_hp)
{
    if (is_number_guessed(manti_distance))
    {
        manti_hp -= cannon_attack;
    }
    return manti_hp;
}
bool is_Game_End(int manticore_hp, int city_hp)
{
    if (manticore_hp <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        Console.ResetColor();
        return true ;
    }
    if(city_hp <=0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You Failed! The Manticore has destroyed The city of Consolas!");
        Console.ResetColor();
        return true;
    }else
        return false;
}

//============================== End Functions =================================================================

Console.Title = "Hunting The Manticore";

int manticore_life = 10,
    manticore_hp = manticore_life;

int city_life = 15,
    city_hp = city_life;

int game_round = 1;
bool end_game=false;

string user_1 = "Player 1";
string user_2 = "Player 2";



Welcome_Display();
int manticore_distance = ask_for_number_range($"{user_1}, how far away from the city do you want to station the Manticore? (0 to 100) ", 0, 100);
Console.Clear();
Welcome_Display();
Console.WriteLine($"{user_2}, it is your turn.");

while (end_game == false)
{
    DisplayStatus(game_round, city_life, city_hp, manticore_life, manticore_hp);
    int cannon_attack = Cannon_damage_points(game_round);
    manticore_hp = Hit_Resolve(cannon_attack, manticore_distance, manticore_hp); manticore_hp = Hit_Resolve(cannon_attack, manticore_distance, manticore_hp);
    if (manticore_hp > 0)
    {
        --city_hp;
    }
    game_round++;

    end_game = is_Game_End(manticore_hp,city_hp);
};




