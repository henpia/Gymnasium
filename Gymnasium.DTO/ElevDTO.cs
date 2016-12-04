using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.DTO
{
    public class ElevDTO
    {
        public System.Guid ElevId { get; set; }
        public string CprNummer { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public bool Deleted { get; set; }
    }
}
