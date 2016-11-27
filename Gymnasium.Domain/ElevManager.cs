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
            elevDTO.ElevId = Guid.NewGuid();
            Persistence.ElevRepository.OpretElev(elevDTO);
        }

        public static List<DTO.ElevDTO> HentElever()
        {
            var elever = Persistence.ElevRepository.HentElever();
            return elever;
        }
    }
}
