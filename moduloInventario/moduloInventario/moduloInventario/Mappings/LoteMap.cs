using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using moduloInventario.Entities;

namespace moduloInventario.Mappings
{
    class LoteMap : ClassMap<Lote>
    {
        public LoteMap()
        {
            Id(x => x.Id);
            Map(x => x.FechaIngreso);
            Map(x => x.FechaCaducidad);
            Map(x => x.Precio);
            References(x => x.Insumo);
        }
    }
}
