using System;

namespace NolexModel
{
    public class ParteCorpo
    {
        public int Id {get; set;}
        public string Descrizione { get; set; }
        public override string ToString()
        {
            return Descrizione;
        }
    }
}
