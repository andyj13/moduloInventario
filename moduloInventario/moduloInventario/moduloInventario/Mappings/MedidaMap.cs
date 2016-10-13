using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using moduloInventario.Entities;

namespace moduloInventario.Mappings
{
    class MedidaMap : ClassMap<Medida>
    {
        public MedidaMap()
        {
            Id(x => x.Id);
            Map(x => x.TipoMedida);
            HasMany(x => x.Insumos)
                .Inverse()
                .Cascade.All();
        }
    }
}
