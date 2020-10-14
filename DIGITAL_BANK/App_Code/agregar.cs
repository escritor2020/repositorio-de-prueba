using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Descripción breve de agregar
/// </summary>
public class agregar
{



    private static string idcliente;
    private static string nombre;
    private static string direccion;
    private static string telefono;
    private static string valor_inicial;
    private static string numero_de_cuenta;
    private static string saldo;





    //METODO para establecer y recuperar datos


    public string Saldo
    {
        set { saldo = value; }
        get { return saldo; }
    }








    public string Numero_de_cuenta
    {
        set { numero_de_cuenta = value; }
        get { return numero_de_cuenta; }
    }






    public string Valor_inicial
    {
        set { valor_inicial = value; }
        get { return valor_inicial; }
    }






    public string Idcliente
    {
        set { idcliente = value; }
        get { return idcliente; }
    }

    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }

    public string Direccion
    {
        set { direccion = value; }
        get { return direccion; }
    }
    public string Telefono
    {
        set { telefono = value; }
        get { return telefono; }
    }

















    // metodo utilizado para insertar los registros  en la la tabla Empleado

    public static void Insert(string nombre, string direccion, string telefono, string valor_inicial, string numero_de_cuenta, string saldo)
    {


//---------------------------------------------------------------------------------------------------------------------------------------------------.................................

        SqlConnection conn = bd_Comun.ObtenerConexion();

        {
            string query = "INSERT INTO clientes(nombre,direccion,telefono,valor_inicial,numero_de_cuenta,saldo) VALUES(@nombre,@direccion,@telefono,@valor_inicial,@numero_de_cuenta,@saldo)";
            SqlCommand cmd = new SqlCommand(query, conn);

            
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@valor_inicial", valor_inicial);
            cmd.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);
            cmd.Parameters.AddWithValue("@saldo", saldo);

           


            try
            {

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {




            }

        }

    }


 //------------------------------------------------------------------------------------------------------------------------------------------------------------------   






    public bool Verificar()
    {

        SqlConnection conn = bd_Comun.ObtenerConexion();


        bool resultado = false;

        SqlCommand comando = new SqlCommand("select * from clientes where nombre='" + nombre + "'", conn);
        comando.Connection = conn;
        SqlDataReader ejecuta = comando.ExecuteReader();
        if (ejecuta.Read())
        {

            nombre = ejecuta["nombre"].ToString(); 
            idcliente = ejecuta["Id_cliente"].ToString();
            direccion = ejecuta["direccion"].ToString();
            telefono = ejecuta["telefono"].ToString();
            valor_inicial = ejecuta["valor_inicial"].ToString();
            numero_de_cuenta = ejecuta["numero_de_cuenta"].ToString();
            saldo = ejecuta["saldo"].ToString();




            resultado = true;

        }
        else
        {

        }

        return resultado;
    }





    public bool Verificar_con_numero_cuenta()
    {

        SqlConnection conn = bd_Comun.ObtenerConexion();


        bool resultado = false;

        SqlCommand comando = new SqlCommand("select * from clientes where numero_de_cuenta='" + Numero_de_cuenta + "'", conn);
        comando.Connection = conn;
        SqlDataReader ejecuta = comando.ExecuteReader();
        if (ejecuta.Read())
        {

            nombre = ejecuta["nombre"].ToString();
            idcliente = ejecuta["Id_cliente"].ToString();
            direccion = ejecuta["direccion"].ToString();
            telefono = ejecuta["telefono"].ToString();
            valor_inicial = ejecuta["valor_inicial"].ToString();
            numero_de_cuenta = ejecuta["numero_de_cuenta"].ToString();
            saldo = ejecuta["saldo"].ToString();




            resultado = true;

        }
        else
        {

        }

        return resultado;
    }




    //----------------------------------------------------------------------------------------------------------------------------------------











  //----------------------------------------------------------------------------------------------------------------------------------------





    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    // metodo utilizado para Actualizar  los registros de la tabla clientes 

    public static void actualizar_cliente(string nombre, string direccion, string telefono, string valor_inicial, string numero_de_cuenta, string saldo, string Id_cliente)
    {
        SqlConnection conn = bd_Comun.ObtenerConexion();

        {
            string query = "update clientes set nombre ='" + nombre + "',direccion='" + direccion + "',telefono='" + telefono + "',valor_inicial='" + valor_inicial + "',numero_de_cuenta='" + numero_de_cuenta + "',saldo='" + saldo + "'  where Id_cliente =" + Id_cliente + ";";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@valor_inicial", valor_inicial);
            cmd.Parameters.AddWithValue("@numero_de_cuenta", numero_de_cuenta);
            cmd.Parameters.AddWithValue("@saldo", saldo);
        



            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {




            }

        }

    }


  //-----------------------------------------------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------------------------------------------



    //metodo utilizado para eliminar los clientes


    public static void eliminar_clientes(string Id_cliente)
    {
        SqlConnection conn = bd_Comun.ObtenerConexion();

        {


            try
            {

                string sql = "delete from clientes where Id_cliente=" + Id_cliente + ";";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_cliente", Id_cliente);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Personas");
                da.Fill(dt);





            }
            catch (Exception)
            {


            }
        }
    }


 //-----------------------------------------------------------------------------------------------------------------------------------------...............................

































}