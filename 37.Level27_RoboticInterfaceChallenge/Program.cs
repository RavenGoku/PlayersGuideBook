/* -----------------Robotic Interface Challenge-----------------
   With your knowledge of interfaces, you realize you can refine the old robot you found in the mud to use
   interfaces instead of the original design. Instead of an abstract RobotCommand base class, it could
   become an IRobotCommand interface!
   Building on your solution to the Old Robot challenge, perform the changes below:
   Objectives:
   •  Change your abstract RobotCommand class into an IRobotCommand interface.
   •  Remove the unnecessary public and abstract keywords from the Run method.
   •  Change the Robot class to use IRobotCommand instead of RobotCommand.
   •  Make all of your commands implement this new interface instead of extending the RobotCommand
        class that no longer exists. You will also want to remove the override keywords in these classes.
   •  Ensure your program still compiles and runs.
   •  Answer this question: Do you feel this is an improvement over using an abstract base class? Why
   or why not?
*/


using RoboticInterfaceChallenge;


Console.WriteLine("""
                  ====================================
                           THE OLD ROBOT
                  ====================================

                  Program your robot with 3 commands.

                  Available Commands:
                  --------------------
                  ON     - Power on the robot
                  OFF    - Power off the robot
                  NORTH  - Move one step north (+Y)
                  SOUTH  - Move one step south (-Y)
                  EAST   - Move one step east  (+X)
                  WEST   - Move one step west  (-X)

                  ------------------------------------
                  Enter your commands one at a time.
                  ====================================

                  """);

Robot robot = new Robot();


for (int i = 0; i < robot.Commands.Length;)
{
    Console.Write($"Enter command {i + 1}/3: ");
    string? command = Console.ReadLine()?.ToUpper().Trim();

    switch (command)
    {
        case "ON":
            robot.Commands[i] = new OnCommand();
            i++;
            break;
        case "OFF":
            robot.Commands[i] = new OffCommand();
            i++;
            break;
        case "NORTH":
            robot.Commands[i] = new NorthCommand();
            i++;
            break;
        case "SOUTH":
            robot.Commands[i] = new SouthCommand();
            i++;
            break;
        case "EAST":
            robot.Commands[i] = new EastCommand();
            i++;
            break;
        case "WEST":
            robot.Commands[i] = new WestCommand();
            i++;
            break;
        default:
            Console.WriteLine($"Command '{command}' is not recognized. Please enter a valid command.");
            continue;
    }
}


robot.Run();