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
        public static void OpretElev(DTO.ElevDTO elevDTO)
        {
            // Open a new connecction to the database
            var db = new GymnasiumDbEntities();
            var elev = convertElevToEntity(elevDTO);
            db.Elevs.Add(elev);
            db.SaveChanges();
        }

        private static Elev convertElevToEntity(DTO.ElevDTO elevDTO)
        {
            var elev = new Elev();
            elev.ElevId = elevDTO.ElevId;
            elev.CprNummer = elevDTO.CprNummer;
            elev.Navn = elevDTO.Navn;
            elev.Adresse = elevDTO.Adresse;
            return elev;
        }

        public static void HentElever()
        {

        }
    }
}
