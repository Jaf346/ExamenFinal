using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Clientes_View : System.Web.UI.Page
    {
        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
            
        }

        public class Agente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
           
        }
    }
}