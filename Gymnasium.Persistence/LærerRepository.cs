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
            lærer.FagId = lærerDTO.FagId;
            return lærer;
        }

        public static List<DTO.LærerDTO> HentLærere()
        {
            // TODO: Implement HentLærere(), which should return a list of lærere
            var db = new GymnasiumDbEntities();
            var lærere = db.Lærer.Where(p => p.LærerId.ToString() != "").ToList();
            var lærereDTO = convertLærereToDTO(lærere);
            return lærereDTO;
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
                lærerDTO.FagId = lærer.FagId;
                lærereDTO.Add(lærerDTO);
            }
            return lærereDTO;
        }
    }
}
