using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using Newtonsoft.Json;

namespace Client_UI
{
    public partial class Gestion : Form


    {

        public Gestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request_Transaccion rq = new Request_Transaccion();
            rq.IdCuenta = 1;
            rq.IdTrans = 0;
            rq.Tipo = "Abono";
            rq.Monto = 30;
            rq.Fecha = "12/02/21";

            string res = Send<Request_Transaccion>("https://localhost:7133/api/Transaccion",rq,"POST");



        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";
            try
            {
                                           

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {

                result = e.Message;

            }

            return result;
        }

    
    //public static string RPost(string url)
    //{
    //    Request_Transaccion rp = new Request_Transaccion()
    //    {
    //        IdTrans = 0,Tipo="Abono",IdCuenta=1,Monto=30,Fecha="20/02/21"

    //    };
    //    string result = "";
    //    WebRequest oRequest = WebRequest.Create(url);
    //    oRequest.Method = "post";
    //    oRequest.ContentType = "application/json;charset=UTF-8";

    //    using (var oSW = new StreamWriter(oRequest.GetRequestStream()))
    //    {
    //        string _json = JsonConvert.SerializeObject(rp);

    //        oSW.Write(_json);
    //        oSW.Flush();
    //        oSW.Close();
    //    }
    //    WebResponse oResponse = oRequest.GetResponse();
    //    using (var oSR = new StreamReader(oResponse.GetResponseStream()))
    //    {
    //        result = oSR.ReadToEnd().Trim();
    //    }
    //    return result;

    //}


}
}