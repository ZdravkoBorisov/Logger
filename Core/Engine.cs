namespace SolidExercise.Core
{
    using System;

    using Core.Interfaces;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                this.commandInterpreter.AddAppender(tokens);

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split("|");

                this.commandInterpreter.AddMessage(tokens);
               
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
