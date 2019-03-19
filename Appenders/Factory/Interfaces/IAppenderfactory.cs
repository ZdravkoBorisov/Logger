namespace SolidExercise.Appenders.Factory
{
    using Appenders.Interfaces;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
