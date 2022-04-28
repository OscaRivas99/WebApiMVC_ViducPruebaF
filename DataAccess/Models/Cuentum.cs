using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Cuentum
    {
        public Cuentum()
        {
            Transaccions = new HashSet<Transaccion>();
        }

        public decimal IdCuenta { get; set; }
        public decimal? NumeroCuenta { get; set; }
        public decimal? IdUser { get; set; }
        public decimal? Saldo { get; set; }

        public virtual Usuario? IdUserNavigation { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
