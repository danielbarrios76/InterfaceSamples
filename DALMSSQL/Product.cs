using System.Data.SqlClient;
using ProductInterface;

namespace DALMSSQL
{
    public class Product : IProduct
    {
        public Entities.Product GetProductByID(int ID)
        {
            Entities.Product Product = null;
            var Connection = new SqlConnection();
            Connection.ConnectionString = "Data Source=192.168.1.64;initial catalog=northwind;user id=demo;password=Demo$";
            Connection.Open();
            var Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = $"Select * from Products where ProductID = {ID}";
            var Reader = Command.ExecuteReader();
            if(Reader.Read())
            {
                Product = new Entities.Product
                {
                    ProductID = System.Convert.ToInt32(Reader["ProductID"]),
                    ProductName = Reader["ProductName"].ToString(),
                    UnitPrice = System.Convert.ToDecimal(Reader["UnitPrice"]),
                    UnitsInStock = System.Convert.ToInt32(Reader["UnitsInStock"]),
                    CategoryID = System.Convert.ToInt32(Reader["CategoryID"])
                };
            }
            Connection.Dispose();
            return Product;
        }


    }
}
