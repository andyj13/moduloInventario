using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloInventario.Entities
{
    public class Categoria
    {
        public virtual int Id { get; protected set; }
        public virtual string TipoCategoria { get; set; }
        public virtual IList<Insumo> Insumos { get; set; }

        public Categoria()
        {
            Insumos = new List<Insumo>();
        }

        public virtual void agregarInsumo(Insumo insumo)
        {
            insumo.Categoria = this;
            Insumos.Add(insumo);
        }
    }
}
