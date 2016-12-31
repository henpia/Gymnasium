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

        public static List<DTO.FagDTO> HentFag()
        {
            var db = new GymnasiumDbEntities();
            List<Fag> fagListe = db.Fags.Where(p => p.Deleted == false).ToList();
            List<DTO.FagDTO> listFagDTO = convertFagListeToDTO(fagListe);
            return listFagDTO;
        }

        public static List<DTO.FagDTO> HentSlettedeFag()
        {
            var context = new GymnasiumDbEntities();
            var slettedeFag = context.Fags.Where(p => p.Deleted == true).ToList();
            List<DTO.FagDTO> slettedeFagDTO = convertFagListeToDTO(slettedeFag);
            return slettedeFagDTO;
        }

        private static List<DTO.FagDTO> convertFagListeToDTO(List<Fag> fagListe)
        {
            List<DTO.FagDTO> fagListeDTO = new List<DTO.FagDTO>();
            foreach (var fag in fagListe)
            {
                var fagDTO = new DTO.FagDTO();
                fagDTO.FagId = fag.FagId;
                fagDTO.Navn = fag.Navn;
                fagDTO.Beskrivelse = fag.Beskrivelse;
                fagListeDTO.Add(fagDTO);
            }
            return fagListeDTO;
        }

        public static void SletFag(int fagId)
        {
            var context = new GymnasiumDbEntities();
            var fag = context.Fags.FirstOrDefault(p => p.FagId == fagId);
            fag.Deleted = true;
            context.SaveChanges();
        }

        public static void SletFagPermanent(int fagId)
        {
            var context = new GymnasiumDbEntities();
            var fagToDelete = context.Fags.Where(p => p.FagId==fagId).First();
            context.Fags.Remove(fagToDelete);
            context.SaveChanges();
        }
    }
}
