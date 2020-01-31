using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DataRepositoryManager
    {
        DataRepository.BokningRepository BokRep = new DataRepository.BokningRepository();
        public IEnumerable<Bokning> HämtaAllaBokningar()
        {
            return BokRep.HämtaAlla();
        }


    }
}
