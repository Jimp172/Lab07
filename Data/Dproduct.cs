using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class Dproduct
    {
        private string connectionString = "Data Source=DESKTOP-GRUDL8S;Initial Catalog=FacturaDB;User ID=tecsup;Password=tecsup";

        public List<Product> Get()
        {
            List<Product> productList = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión

                using (SqlCommand command = new SqlCommand("ListarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                product_id = reader.GetInt32(reader.GetOrdinal("product_id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                price = reader.GetDecimal(reader.GetOrdinal("price")),
                                stock = reader.GetInt32(reader.GetOrdinal("stock")),
                                active = reader.GetInt32(reader.GetOrdinal("active")) == 1 ? true : false
                            };

                            productList.Add(product);
                        }
                    }
                }
            }
            return productList;
        }
    }
}
