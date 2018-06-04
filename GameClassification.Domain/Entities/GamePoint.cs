using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class GamePoint
    {
        public long GamePointId { get; set; }

        public long PlayerId { get; set; }

        public long GameId { get; set; }

        public long Win { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
