using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Persistence
{
    public class ElevRepository
    {
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

        public static List<DTO.ElevDTO> HentElever()
        {
            var db = new GymnasiumDbEntities();
            var elever = db.Elevs.ToList();
            var eleverDTO = convertEleverToDTOList(elever);
            return eleverDTO;
        }

        private static List<DTO.ElevDTO> convertEleverToDTOList(List<Elev> elever)
        {
            var elevListDTO = new List<DTO.ElevDTO>();
            foreach (var elev in elever)
            {
                var elevDTO = new DTO.ElevDTO();
                elevDTO.ElevId = elev.ElevId;
                elevDTO.CprNummer = elev.CprNummer;
                elevDTO.Navn = elev.Navn;
                elevDTO.Adresse = elev.Adresse;
                elevListDTO.Add(elevDTO);
            }
            return elevListDTO;
        }
    
    }
}
