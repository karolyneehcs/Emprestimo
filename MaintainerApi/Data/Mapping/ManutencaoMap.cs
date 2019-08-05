using MaintainerApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintainerApi.Data.Mapping
{
    public class ManutencaoMap : EntityTypeConfiguration<Manutencao>
    {
        public ManutencaoMap()
        {
            HasKey(a => a.Id);

            ToTable("Manutencao");
        }
    }
}
