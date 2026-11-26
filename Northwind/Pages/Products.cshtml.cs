using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

public class ProductsModel : PageModel
{
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        Products = new List<Product>();
        string connectionString = "Data Source=../northwind.db;Mode=ReadOnly";

        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string sql = @"SELECT p.ProductName, c.CategoryName, p.UnitPrice
                           FROM Products p
                           JOIN Categories c ON p.CategoryID = c.CategoryID";
            using (SqliteCommand command = new SqliteCommand(sql, connection))
            {
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Products.Add(new Product
                        {
                            ProductName = reader.GetString(0),
                            CategoryName = reader.GetString(1),
                            UnitPrice = (decimal)reader.GetDouble(2)
                        });
                    }
                }
            }
        }
    }
}

public class Product
{
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public decimal UnitPrice { get; set; }
}