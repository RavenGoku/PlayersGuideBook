using _35.Level26_TheOldRobot_Challenge;


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
    while (string.IsNullOrEmpty(command) || double.TryParse(command, out _))
    {
        Console.Write($"Wrong Command, try again {i + 1}/3: ");
        command = Console.ReadLine()?.ToUpper().Trim();
    }

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