using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GameClassification.Infra.Data.EntityConfig
{
    public class GamePointConfiguration : EntityTypeConfiguration<GamePoint>
    {
        public GamePointConfiguration()
        {
            HasKey(c => c.GamePointId);
        }
    }
}
