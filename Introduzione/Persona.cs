using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduzione
{
    public class Persona
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Eta { get; set; }
        public DateTime CreationDate { get; set; }
        public static int NumOfObj { get; set; }
    }
}