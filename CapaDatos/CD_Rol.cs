﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Rol
    {
        //Metodo Para Listar Nombres De Rol
        
        public List<Rol> Listar(int idRol)
        {
            //Objeto
            List<Rol> lista = new List<Rol>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                //Peticion dB

                try
                {
                    StringBuilder querySQL = new StringBuilder();
                    querySQL.AppendLine("SELECT a.IdRol, a.Descripcion FROM ROL a");
                    querySQL.AppendLine("INNER JOIN USUARIO b on a.IdRol = b.IdRol");
                    querySQL.AppendLine("WHERE a.IdRol = @idRol");

                    SqlCommand cmd = new SqlCommand(querySQL.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                objRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }//Cierre del ciclo
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Al Ejecutar La Consola Rol " + ex.Message);
                }

            }
                return lista;
        }//Cierre Del Metodo


    }
}