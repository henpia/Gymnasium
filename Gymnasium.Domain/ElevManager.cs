using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasium.Domain
{
    public class ElevManager
    {
        public static void OpretElev()
        {
            Persistence.ElevRepository.OpretElev();
        }
    }
}
