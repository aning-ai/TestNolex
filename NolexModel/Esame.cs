using System;

namespace NolexModel
{
    public class Esame
    {
        public int Id {get; set;}
        public string Descrizione { get; set; }
        public string CodiceMinisteriale { get; set; }
        public string CodiceInterno { get; set; }
        public int IdParteCorpo { get; set; }
    }
}
