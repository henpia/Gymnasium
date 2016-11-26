using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Persistence
{
    public class ElevRepository
    {
        // TODO: Implement the ElevRepository class in the persistence layer
        public static void OpretElev()
        {
            // Open a new connecction to the database
            var db = new GymnasiumDbEntities();
            var elev = convertElevToEntity();

            db.Elevs.Add(elev);
            db.SaveChanges();
        }

        private static Elev convertElevToEntity()
        {
            var elev = new Elev();

            // TODO: Refactor this code to not be hardcoded
            elev.ElevId = Guid.NewGuid();
            elev.CprNummer = "112244-0353";
            elev.Navn = "Peter Jørgensen";
            elev.Adresse = "Vestbyvej 210";
            return elev;
        }

        public static void HentElever()
        {

        }
    }
}
