using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;



using Webapp.Api.Controllers;

namespace Webapp.Api.Modelos
{
    public class CLIENTE_ADO
    {
        #region Atributo    

        string conectionString = @"Data Source=DESKTOP-MRGPWK77\SQLEXPRESS;Initial Catalog=DBAPIWEB; Integrated Security= True ";


        #endregion


        #region Propiedades
        public int id_cliente { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }
        #endregion


        #region Metodos 


        public DataTable TraerT()
        {

            string sqlSentencia = "Cliente_g";

            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;

            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCom.CommandType = CommandType.StoredProcedure;

            sqlCnn.Open();



            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCom;

            DataSet ds = new DataSet();
            da.Fill(ds);


            sqlCnn.Close();


            return ds.Tables[0];



        }


        public DataTable TraerPorId()
        {
            string sqlSentencia = "Cliente_g";

            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;

            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);

            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.Add("@Id", SqlDbType.Int).Value = id_cliente;

            sqlCnn.Open();



            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCom;

            DataSet ds = new DataSet();
            da.Fill(ds);


            sqlCnn.Close();


            return ds.Tables[0];

        }

        //public void Guardar()
        //{

        //    string sqlSentencia = "localidad_i";

        //    SqlConnection sqlCnn = new SqlConnection();
        //    sqlCnn.ConnectionString = conectionString;

        //    SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);

        //    sqlCom.CommandType = CommandType.StoredProcedure;
        //    sqlCom.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = nombre;
        //    sqlCom.Parameters.Add("@provincia", SqlDbType.NVarChar, 100).Value = provincia;

        //    sqlCnn.Open();

        //    var res = sqlCom.ExecuteNonQuery();


        //    sqlCnn.Close();


        //}


        //public void Modificar()
        //{

        //    string sqlSentencia = "localidad_u";

        //    SqlConnection sqlCnn = new SqlConnection();
        //    sqlCnn.ConnectionString = conectionString;

        //    SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);

        //    sqlCom.CommandType = CommandType.StoredProcedure;
        //    sqlCom.Parameters.Add("@Id", SqlDbType.Int).Value = localidad_id;
        //    sqlCom.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = nombre;
        //    sqlCom.Parameters.Add("@provincia", SqlDbType.NVarChar, 100).Value = provincia;


        //    sqlCnn.Open();

        //    var res = sqlCom.ExecuteNonQuery();


        //    sqlCnn.Close();

        //}

        //public void Eliminar()
        //{


        //    string sqlSentencia = "localidad_d";

        //    SqlConnection sqlCnn = new SqlConnection();
        //    sqlCnn.ConnectionString = conectionString;

        //    SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);

        //    sqlCom.CommandType = CommandType.StoredProcedure;
        //    sqlCom.Parameters.Add("@Id", SqlDbType.Int).Value = localidad_id;

        //    sqlCnn.Open();

        //    var res = sqlCom.ExecuteNonQuery();


        //    sqlCnn.Close();

        //}

        #endregion
    }
}
