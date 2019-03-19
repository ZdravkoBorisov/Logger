namespace SolidExercise.Loggers.Interfaces
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
