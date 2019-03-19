namespace SolidExercise.Loggers.Interfaces
{
    public interface ILogger
    {
        void Info(string dateTime, string errorMessage);

        void Warning(string dateTime, string infoMessage);

        void Error(string dateTime, string infoMessage);

        void Critical(string dateTime, string infoMessage);

        void Fatal(string dateTime, string infoMessage);


    }
}
