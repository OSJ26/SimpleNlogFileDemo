namespace NlogFileDemo.Interface
{
    public interface ILog
    {
        void Information(string message);
        void Warning (string message);
        void Error (string message);
        void Debug (string message);
    }
}
