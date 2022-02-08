using MarsRover.model;
using MarsRover.utilities;

namespace MarsRover;

    public static class RobotTask
    {
        public static string PerformRobotTask(string dimensions, string commandList)
        {
            var shape = dimensions.Split('x');
            int n = Convert.ToInt32(shape[0]);
            int m = Convert.ToInt32(shape[1]);

            if (n == 0 || m == 0)
            {
                return "Please Give Correct Input";
            }


            var plateau = new Plateau(n, m);
            var robot = new Robot();

            foreach (var command in commandList)
            {
                if (command == 'F')
                    robot.MoveFront(plateau);
                else
                    robot.ChangeDirection(command.ToString());
            }
            return robot.ToString();
        }
    }

