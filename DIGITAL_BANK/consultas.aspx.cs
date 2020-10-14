using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class consultas : System.Web.UI.Page
{

    public static string saldo;
    


    public string Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }







    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        agregar consulta = new agregar();

        consulta.Numero_de_cuenta = txt_numero_de_cuenta.Text;

        if (consulta.Verificar_con_numero_cuenta() == true)
        {
            etiqueta.Text = "";

            etiqueta.Text  = consulta.Saldo.ToString() +"$";

        }

        else
        {
            etiqueta.Text = "No exisen Registros ";

        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txt_numero_de_cuenta.Text = "";
    }
}