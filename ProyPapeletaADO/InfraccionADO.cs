using Microsoft.Data.SqlClient;
using ProyPapeletaBE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace ProyPapeletaADO
{
    public class InfraccionADO
    {
        
        public Boolean InsertarInfraccion(InfraccionBE objInfraccionBE)
        {
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_INFRACCION", cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = objInfraccionBE.DESCRIPCION_SANCION;
                        cmd.Parameters.Add("@CALIFICACION", SqlDbType.VarChar).Value = objInfraccionBE.CALIFICACION;
                        cmd.Parameters.Add("@PUNTOS", SqlDbType.Int).Value = objInfraccionBE.PUNTOS;
                        cmd.Parameters.Add("@UIT", SqlDbType.Decimal).Value = objInfraccionBE.UIT;
                        cmd.Parameters.Add("@ESTADO", SqlDbType.Bit).Value = objInfraccionBE.ESTADO;
                        cmd.Parameters.Add("@USU_REGISTRO", SqlDbType.VarChar).Value = objInfraccionBE.USU_REGISTRO;

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

        public Boolean ActualizarInfraccion(InfraccionBE objInfraccionBE)
        {
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_INFRACCION", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@COD_INFRACCION", SqlDbType.Char).Value = objInfraccionBE.COD_INFRACCION;
                        cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = objInfraccionBE.DESCRIPCION_SANCION;
                        cmd.Parameters.Add("@CALIFICACION", SqlDbType.VarChar).Value = objInfraccionBE.CALIFICACION;
                        cmd.Parameters.Add("@PUNTOS", SqlDbType.VarChar).Value = objInfraccionBE.PUNTOS;
                        cmd.Parameters.Add("@UIT", SqlDbType.Decimal).Value = objInfraccionBE.UIT;
                        cmd.Parameters.Add("@ESTADO", SqlDbType.Bit).Value = objInfraccionBE.ESTADO;

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

        //ELIMINAR INFRACCION 
        public Boolean EliminarInfraccion(String strCodigo)
        {
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ELIMINAR_INFRACCION", cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@COD_INFRACCION", SqlDbType.Char).Value = strCodigo;
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

        //CONSULTAR INFRACCION 
        public InfraccionBE ConsultarInfraccion(String strCodigo)
        {
            var objInfraccionBE = new InfraccionBE();
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CONSULTAR_INFRACCION", cnx))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@COD_INFRACCION", SqlDbType.Char).Value = strCodigo;

                        cnx.Open();
                        using (SqlDataReader dtr = cmd.ExecuteReader())
                        {
                            if (dtr.Read())
                            {
                                objInfraccionBE.COD_INFRACCION = dtr["COD_INFRACCION"].ToString();
                                objInfraccionBE.DESCRIPCION_SANCION = dtr["DESCRIPCION_SANCION"].ToString();
                                objInfraccionBE.CALIFICACION = dtr["CALIFICACION"].ToString();
                                objInfraccionBE.PUNTOS = int.Parse(dtr["PUNTOS"].ToString());
                                objInfraccionBE.UIT = Convert.ToDecimal(dtr["UIT"]);
                                objInfraccionBE.ESTADO = Convert.ToBoolean(dtr["ESTADO"]);



                            }
                            return objInfraccionBE;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al consultar: {ex.Message}");

            }
        }
        public DataTable ListarInfraccion()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {

                    using (SqlCommand cmd = new SqlCommand("SP_LISTAR_INFRACCION", cnx))
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
                throw new Exception($"Error al listar los infractores: {ex.Message}");
            }
        }
    }
}