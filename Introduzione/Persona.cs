﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduzione
{
    public class Persona
    {
        public Guid ID { get; set; }
        public static int NumOfObj { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public DateTime CreationDate { get; set; }
    }
}