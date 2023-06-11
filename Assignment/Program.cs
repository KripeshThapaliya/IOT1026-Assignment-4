namespace Assignment;

static class Program
{
    static void Main()
    {
        RobotTester.TestRobot();
    }
}

public class RobotTester
{
    public static void TestRobot()
    {
        // Tried using ChatGPT because ran into some 
        Robot robot = new Robot();

        // Perform various robot commands
        robot.ExecuteCommand(new OnCommand());
        robot.ExecuteCommand(new EastCommand());
        robot.ExecuteCommand(new SouthCommand());
        robot.ExecuteCommand(new CustomCommand());

        // Display the final state of the robot
        Console.WriteLine($"Robot state - X: {robot.X}, Y: {robot.Y}, IsPowered: {robot.IsPowered}");
    }
}
