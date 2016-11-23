using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Domain
{
    public class LærerManager
    {
        public static void OpretLærer(DTO.LærerDTO lærerDTO)
        {
            lærerDTO.LærerId = Guid.NewGuid();
            // TODO: Work towards removing this field from the Lærer table.
            lærerDTO.FagId = Guid.NewGuid();
            Persistence.LærerRepository.OpretLærer(lærerDTO);
        }

        public static List<DTO.LærerDTO> HentLærere()
        {
            return Persistence.LærerRepository.HentLærere();
        }
    }
}
