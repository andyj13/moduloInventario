using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using moduloInventario.Entities;

namespace moduloInventario.Mappings
{
    class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
        {
            Id(x => x.Id);
            Map(x => x.TipoCategoria);
            HasMany(x => x.Insumos)
                .Inverse()
                .Cascade.All();
        }
    }
}
