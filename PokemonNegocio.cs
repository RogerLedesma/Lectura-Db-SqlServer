using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace frmPokemon
{
    class PokemonNegocio
    {


        public List<Pokemon> Listar ()
        {   

            // LISTA DE POKEMON, RECOLECTANDO 

            List<Pokemon> lista = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database=POKEDEX_DB; integrated security = true ";
                // Puedo copiar y pegar "server = FX8000-PC\\SQLEXPRESS" o bien
                // colocar un punto para que luego la lectura sea agil.
                
                //comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "";
                

                
     
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
