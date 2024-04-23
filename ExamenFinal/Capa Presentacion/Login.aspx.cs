using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Presentacion
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += new EventHandler(Button1_Click);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = username.Value;
            string password = password.Value;

            if (username == "usuario" && password == "contraseña")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Inicio de sesión exitoso')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Nombre de usuario o contraseña incorrectos')", true);
            }
        }
    }
}
