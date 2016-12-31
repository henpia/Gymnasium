using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Persistence
{
    public class LærerRepository
    {
        public static void OpretLærer(DTO.LærerDTO lærerDTO)
        {
            var db = new GymnasiumDbEntities();
            var lærer = convertLærerToEntity(lærerDTO);
            db.Lærer.Add(lærer);
            db.SaveChanges();
        }

        private static Lærer convertLærerToEntity(DTO.LærerDTO lærerDTO)
        {
            var lærer = new Lærer();
            lærer.LærerId = lærerDTO.LærerId;
            lærer.CprNummer = lærerDTO.CprNummer;
            lærer.Navn = lærerDTO.Navn;
            lærer.Adresse = lærerDTO.Adresse;
            return lærer;
        }

        public static List<DTO.LærerDTO> HentLærere()
        {
            var db = new GymnasiumDbEntities();
            var lærere = db.Lærer.Where(p => p.Deleted == false).ToList();
            var lærereDTO = convertLærereToDTO(lærere);
            return lærereDTO;
        }

        public static List<DTO.LærerDTO> HentSlettedeLærere()
        {
            var context = new GymnasiumDbEntities();
            var slettedeLærere = context.Lærer.Where(p => p.Deleted == true).ToList();
            var slettedeLærereDTO = convertLærereToDTO(slettedeLærere);
            return slettedeLærereDTO;
        }

        private static List<DTO.LærerDTO> convertLærereToDTO(List<Lærer> lærere)
        {
            var lærereDTO = new List<DTO.LærerDTO>();
            foreach (var lærer in lærere)
            {
                var lærerDTO = new DTO.LærerDTO();
                lærerDTO.LærerId = lærer.LærerId;
                lærerDTO.CprNummer = lærer.CprNummer;
                lærerDTO.Navn = lærer.Navn;
                lærerDTO.Adresse = lærer.Adresse;
                lærereDTO.Add(lærerDTO);
            }
            return lærereDTO;
        }

        public static void SletLærer(Guid lærerId)
        {
            var context = new GymnasiumDbEntities();
            var lærer = context.Lærer.Where(p => p.LærerId == lærerId).First();
            lærer.Deleted = true;
            context.SaveChanges();
        }

        public static void SletLærerPermanent(Guid lærerId)
        {
            var context = new GymnasiumDbEntities();
            var lærerToBeDeleted = context.Lærer.Where(p => p.LærerId == lærerId).First();
            context.Lærer.Remove(lærerToBeDeleted);
            context.SaveChanges();
        }
    }
}
