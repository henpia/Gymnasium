using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Persistence
{
    public class FagRepository
    {
        public static void OpretFag()
        {
            // TODO: Implement the OpretFag method in the persistense layer
            var db = new GymnasiumDbEntities();
            var fag = convertFagToEntity();

            db.Fags.Add(fag);
            db.SaveChanges();
        }

        private static Fag convertFagToEntity()
        {
            var fag = new Fag();

            fag.FagId = Guid.NewGuid();
            fag.Navn = "Matematik";
            fag.Beskrivelse = "Dette fag skal fremme elevernes matematiske færdigheder.";
            return fag;
        }

        public static void HentFag()
        {
            // TODO: Implement the HentFag method in the persistence layer
        }
    }
}
