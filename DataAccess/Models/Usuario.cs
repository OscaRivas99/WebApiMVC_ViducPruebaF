using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cuenta = new HashSet<Cuentum>();
        }

        public decimal IdUser { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Pass { get; set; }
        public string? Token { get; set; }

        public virtual ICollection<Cuentum> Cuenta { get; set; }
    }
}
