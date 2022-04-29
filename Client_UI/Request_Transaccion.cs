using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Linq;

namespace Client_UI
{
    public class Request_Transaccion
    {
        public decimal IdTrans { get; set; }
        public string? Tipo { get; set; }
        public decimal? IdCuenta { get; set; }
        public decimal? Monto { get; set; }
        public string? Fecha { get; set; }
    }
}

