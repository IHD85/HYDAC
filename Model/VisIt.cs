using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveZ
{
    public class Visit
    {
        public DateOnly Dato { get; set; }
        public TimeOnly FromTime { get; set; }
        public TimeOnly ToTime { get; set; }
        public Visitor Visitor { get; set; }

        public char Sikkerhedsfolder { get; set; }

        public Responsible Responsible1 { get; set; }
        public Firma Firma { get; set; }
        public Visit(DateOnly dato, Visitor visitor, Firma firma, Responsible responsible, TimeOnly fromTime, TimeOnly toTime, char secureDoc)
        {
            Dato = dato;
            Visitor = visitor;
            Firma = firma;
            Responsible1 = responsible;
            ToTime = toTime;
            Sikkerhedsfolder = secureDoc;
            Dato = dato;
            FromTime = fromTime;
        }
    }
}
