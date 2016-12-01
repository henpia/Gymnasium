using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Persistence
{
    public class FagRepository
    {
        public static void OpretFag(DTO.FagDTO fagDTO)
        {
            // TODO: Implement the OpretFag method in the persistense layer
            var db = new GymnasiumDbEntities();
            var fag = convertFagToEntity(fagDTO);

            db.Fags.Add(fag);
            db.SaveChanges();
        }

        private static Fag convertFagToEntity(DTO.FagDTO fagDTO)
        {
            var fag = new Fag();

            fag.FagId = fagDTO.FagId;
            fag.Navn = fagDTO.Navn;
            fag.Beskrivelse = fagDTO.Beskrivelse;


            return fag;
        }

        public static void HentFag()
        {
            // TODO: Implement the HentFag method in the persistence layer
        }
    }
}
