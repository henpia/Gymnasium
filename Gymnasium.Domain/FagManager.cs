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
            Persistence.FagRepository.OpretFag(fagDTO);
        }
    }
}
