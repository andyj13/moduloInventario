using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloInventario.Entities
{
    public class Insumo
    {
        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual int Cantidad { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Medida Medida { get; set; }
        public virtual IList<Lote> Lotes { get; set; }

        public Insumo()
        {
            Lotes = new List<Lote>();
        }

        public virtual void agregarLote(Lote lote)
        {
            lote.Insumo = this;
            Lotes.Add(lote);
        }

    }
}
