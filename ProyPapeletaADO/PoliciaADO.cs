using Microsoft.Data.SqlClient;
using ProyPapeletaBE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace ProyPapeletaADO
{
    public class PoliciaADO
    {
        public Boolean InsertarPolicia(PoliciaBE objPoliciaBE) 
        {
            try 
            {
                
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_POLICIA", cnx))
                    {
                       
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = objPoliciaBE.NOMBRE;
                        cmd.Parameters.Add("@PATERNO", SqlDbType.VarChar).Value = objPoliciaBE.PATERNO;
                        cmd.Parameters.Add("@MATERNO", SqlDbType.VarChar).Value = objPoliciaBE.MATERNO;
                        cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = objPoliciaBE.DNI;
                        cmd.Parameters.Add("@COD_UBIGEO", SqlDbType.Char).Value = objPoliciaBE.COD_UBIGEO;
                        cmd.Parameters.Add("@GRADO", SqlDbType.VarChar).Value = objPoliciaBE.GRADO;
                        cmd.Parameters.Add("@SEXO", SqlDbType.Char).Value = objPoliciaBE.SEXO;
                        cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.Date).Value = objPoliciaBE.FECHANACIMIENTO;
                        cmd.Parameters.Add("@ESTADO", SqlDbType.Char).Value = objPoliciaBE.ESTADO;
                        cmd.Parameters.Add("@FOTO", SqlDbType.Image).Value = objPoliciaBE.FOTO;//cualquier error es aqui bb
                        cmd.Parameters.Add("@USU_REGISTRO", SqlDbType.VarChar).Value = objPoliciaBE.USU_REGISTRO;

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al insertar: {ex.Message}");

            }
        }

        public Boolean ActualizarPolicia(PoliciaBE objPoliciaBE)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_POLICIA", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@COD_POLICIA", SqlDbType.Char).Value = objPoliciaBE.COD_POLICIA; // ← faltaba
                        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = objPoliciaBE.NOMBRE;
                        cmd.Parameters.Add("@PATERNO", SqlDbType.VarChar).Value = objPoliciaBE.PATERNO;
                        cmd.Parameters.Add("@MATERNO", SqlDbType.VarChar).Value = objPoliciaBE.MATERNO;
                        cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = objPoliciaBE.DNI;
                        cmd.Parameters.Add("@COD_UBIGEO", SqlDbType.Char).Value = objPoliciaBE.COD_UBIGEO;
                        cmd.Parameters.Add("@GRADO", SqlDbType.VarChar).Value = objPoliciaBE.GRADO;
                        cmd.Parameters.Add("@SEXO", SqlDbType.Char).Value = objPoliciaBE.SEXO;
                        cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.SmallDateTime).Value = objPoliciaBE.FECHANACIMIENTO;
                        cmd.Parameters.Add("@ESTADO", SqlDbType.Char).Value = objPoliciaBE.ESTADO;
                        cmd.Parameters.Add("@FOTO", SqlDbType.Image).Value = objPoliciaBE.FOTO ?? (object)DBNull.Value;
                        cmd.Parameters.Add("@USU_ULT_MODIFICACION", SqlDbType.VarChar).Value = objPoliciaBE.USU_ULT_MODIFICACION;

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al actualizar: {ex.Message}");
            }
        }

        //ELIMINAR POLICIA 
        public Boolean EliminarPolicia(String strCodigo)
        {
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ELIMINAR_POLICIA", cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@COD_POLICIA", SqlDbType.Char).Value = strCodigo;

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al eliminar: {ex.Message}");

            }
        }

        //CONSULTAR POLICIA 
        public PoliciaBE ConsultarPolicia(String strCodigo)
        {
            var objPoliciaBE = new PoliciaBE();
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CONSULTAR_POLICIA", cnx))
                    {

             
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@COD_POLICIA", SqlDbType.Char).Value = strCodigo;

                        cnx.Open();
                        using(SqlDataReader dtr = cmd.ExecuteReader())
                {
                            if (dtr.Read())
                            {
                                objPoliciaBE.COD_POLICIA = dtr["COD_POLICIA"].ToString(); 
                                objPoliciaBE.NOMBRE = dtr["NOMBRE"].ToString();
                                objPoliciaBE.PATERNO = dtr["PATERNO"].ToString();
                                objPoliciaBE.MATERNO = dtr["MATERNO"].ToString();
                                objPoliciaBE.DNI = dtr["DNI"].ToString();
                                objPoliciaBE.GRADO = dtr["GRADO"].ToString();
                                objPoliciaBE.SEXO = dtr["SEXO"].ToString();
                                objPoliciaBE.ESTADO = dtr["ESTADO"].ToString();
                                objPoliciaBE.FECHANACIMIENTO = Convert.ToDateTime(dtr["FECHANACIMIENTO"]);
                                objPoliciaBE.ESTADO = dtr["ESTADO"].ToString();
                                objPoliciaBE.COD_UBIGEO = dtr["COD_UBIGEO"].ToString();

                                if (dtr["FOTO"] != DBNull.Value)
                                {
                                    objPoliciaBE.FOTO = (byte[])dtr["FOTO"];
                                }

                            }
                           return objPoliciaBE;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al consultar: {ex.Message}");

            }
        }

        //LISTAR POLICIA
        public DataTable ListarPolicia()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LISTAR_POLICIA", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            ada.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al listar los policías: {ex.Message}");
            }
        }
        public DataTable ListarDepartamentos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx =
                new SqlConnection(Configuracion.PAPELETA))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DISTINCT DEPARTAMENTO FROM TB_UBIGEO",
                    cnx);

                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ListarProvincias(string departamento)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DISTINCT PROVINCIA FROM TB_UBIGEO WHERE DEPARTAMENTO=@DEPARTAMENTO",
                    cnx);

                da.SelectCommand.Parameters.AddWithValue("@DEPARTAMENTO", departamento);

                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ListarDistritos(string provincia)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT COD_UBIGEO, DISTRITO FROM TB_UBIGEO WHERE PROVINCIA=@PROVINCIA",
                    cnx);

                da.SelectCommand.Parameters.AddWithValue("@PROVINCIA", provincia);

                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ObtenerUbigeoPorPolicia(string codPolciia)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlCommand cmd = new SqlCommand("SP_CONSULTAR_POLICIA", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@COD_POLICIA", SqlDbType.Char, 6).Value = codPolciia;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public DataRow ObtenerUbigeo(string codUbigeo)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlCommand cmd = new SqlCommand("SP_OBTENER_UBIGEO", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@COD_UBIGEO", SqlDbType.Char, 6).Value = codUbigeo.Trim();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
