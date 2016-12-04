using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.DTO
{
    public class LærerDTO
    {
        public System.Guid LærerId { get; set; }
        public string CprNummer { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
    }
}
