using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloInventario.Entities
{
    public class Lote
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime FechaIngreso { get; set; }
        public virtual DateTime FechaCaducidad { get; set; }
        public virtual double Precio { get; set; }
        public virtual Insumo Insumo { get; set; }

        public Lote()
        {

        }
    }
}
