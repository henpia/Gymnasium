using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Domain
{
    public class FagManager
    {
        public static void OpretFag(DTO.FagDTO fagDTO)
        {
            //fagDTO.FagId = Guid.NewGuid();
            Persistence.FagRepository.OpretFag(fagDTO);
        }

        public static List<DTO.FagDTO> HentFag()
        {
            List<DTO.FagDTO> fagDTO = Persistence.FagRepository.HentFag();
            return fagDTO;
        }

        public static void SletFag(int fagId)
        {
            Persistence.FagRepository.SletFag(fagId);
        }

        public static List<DTO.FagDTO> HentSlettedeFag()
        {
            return Persistence.FagRepository.HentSlettedeFag();
        }
    }
}
