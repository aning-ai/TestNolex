﻿using System;

namespace NolexModel
{
    public class Ambulatorio
    {
        public int Id {get; set;}
        public string Descrizione { get; set; }

        public override string ToString()
        {
            return Descrizione;
        }
    }
}
