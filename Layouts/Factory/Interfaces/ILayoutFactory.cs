namespace SolidExercise.Layouts.Factory.Interfaces
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
