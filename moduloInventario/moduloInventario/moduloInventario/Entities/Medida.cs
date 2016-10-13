using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloInventario.Entities
{
    public class Medida
    {
        public virtual int Id { get; protected set; }
        public virtual string TipoMedida { get; set; }
        public virtual IList<Insumo> Insumos { get; set; }

        public Medida()
        {
            Insumos = new List<Insumo>();
        }

        public virtual void agregarInsumo(Insumo insumo)
        {
            insumo.Medida = this;
            Insumos.Add(insumo);
        }
    }
}
