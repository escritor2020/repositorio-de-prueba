using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;  


/// <summary>
/// Descripción breve de bd_Comun
/// </summary>
public class bd_Comun
{

    public static SqlConnection ObtenerConexion()
    {
        SqlConnection conectar = new SqlConnection("Data Source=COMPUTADORA_CEN;Initial Catalog=clientes;Integrated Security=True");
        conectar.Open();



        return conectar;
    }











	public bd_Comun()
	{
		
	}
}