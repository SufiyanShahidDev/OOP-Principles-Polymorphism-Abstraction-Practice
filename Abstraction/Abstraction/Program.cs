namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TVremote vremote = new TVremote();
            vremote.TurnOn();

            ACremote aCremote = new ACremote();
            aCremote.TurnOn();
        }
    }
}
