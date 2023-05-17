using ZeelandZoo.Models;

namespace ZeelandZoo.MockData
{
    public class MockEvents
    {
        private static List<Events> _events = new List<Events>()
        {
            new Events("Beerpong Turnering!!!", 7/4-2023, 50),
            new Events("VM:Frankrig mod England", 12/4-2023, 40),
            new Events("Partybusser på vej!!!", 21/4-2023, 80),
            new Events("Fortnite Mesterskab!!!", 28/4-2023, 20),
        };

        public static List<Events> GetMockEvents()
        {
            return _events;
        }
    }
}
