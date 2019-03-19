namespace SolidExercise
{
    using Core;
    using Core.Interfaces;

    public class Program
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);

            engine.Run();

        }
    }
}
