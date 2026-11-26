using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

public class CustomersModel : PageModel
{
    public List<Customer> Customers { get; set; }

    public void OnGet()
    {
        Customers = new List<Customer>();
        string connectionString = "Data Source=../northwind.db;Mode=ReadOnly";

        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT CustomerID, CompanyName, ContactName, Country FROM Customers";
            using (SqliteCommand command = new SqliteCommand(sql, connection))
            {
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customers.Add(new Customer
                        {
                            CustomerID = reader.GetString(0),
                            CompanyName = reader.GetString(1),
                            ContactName = reader.GetString(2),
                            Country = reader.GetString(3)
                        });
                    }
                }
            }
        }
    }
}

public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string Country { get; set; }
}