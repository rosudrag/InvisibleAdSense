namespace InvisibleAdSense.Driver
{
    public interface IAdSenseDriver
    {
        void Close();
        void GoTo(string url);
    }
}