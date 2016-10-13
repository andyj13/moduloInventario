using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using moduloInventario.Entities;

namespace moduloInventario.Mappings
{
    public class InsumoMap : ClassMap<Insumo>
    {
        public InsumoMap()
        {
            Id(x => x.Id);
            Map(x => x.Nombre);
            Map(x => x.Cantidad);
            Map(x => x.Descripcion);
            References(x => x.Categoria);
            References(x => x.Medida);
            HasMany(x => x.Lotes)
                .Inverse()
                .Cascade.All();
        }
    }
}
