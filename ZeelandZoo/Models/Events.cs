namespace ZeelandZoo.Models
{
    public class Events
    {
        #region Properties
        public string Event_Titler { get; set; }
        public int Dato { get; set; }
        public int Antal_Personer { get; set; }
        #endregion

        #region Constructor
        public Events(string event_titler, int dato, int antal_personer)
        {
            Event_Titler = event_titler;
            Dato = dato;
            Antal_Personer = antal_personer;
        }
        #endregion
    }
}
