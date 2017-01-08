using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Domain
{
    public class ElevManager
    {
        public static void OpretElev(DTO.ElevDTO elevDTO)
        {
            // elevDTO.ElevId = Guid.NewGuid();
            Persistence.ElevRepository.OpretElev(elevDTO);
        }

        public static List<DTO.ElevDTO> HentElever()
        {
            var elever = Persistence.ElevRepository.HentElever();
            return elever;
        }

        public static void SletElev(int elevId)
        {
            Persistence.ElevRepository.SletElev(elevId);
        }

        public static List<DTO.ElevDTO> HentSlettedeElever()
        {
            return Persistence.ElevRepository.HentSlettedeElever();
        }

        public static void SletElevPermanently(int elevId)
        {
            Persistence.ElevRepository.SletElevvPermanently(elevId);
        }
    }
}
