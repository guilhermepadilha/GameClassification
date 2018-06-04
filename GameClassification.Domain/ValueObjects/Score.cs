using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.ValueObjects
{
    public class Score
    {
        public long PlayerId { get; set; }

        public long Balance { get; set; }

        public DateTime LastUpdateDate { get; set; }
      
    }
}
