using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Admin.GlobalVar;

namespace Admin
{
    public static class SQL
    {
        
        
        public static void UpdateCustomer(string email, string toSet, string newValue)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Customers SET " + toSet + "='" + newValue + "', StatusChanged='" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' WHERE Email='" + email + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void UpdateCustomerOrdersAmount(string email)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Customers SET Orders=Orders+1 WHERE Email='" + email + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void UpdateCustomerTotalSpending(string email, string spending)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Customers SET TotalSpending=TotalSpending+'" + spending + "' WHERE Email='" + email + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void UpdateProduct(string name, string toSet, string newValue)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Products SET " + toSet + "='" + newValue + "' WHERE Name='" + name + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void UpdateSettings(string server, int port, bool ssl, string username, string password, string companyName, string companyOwner, string companyPhone)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Settings SET Value='" + server + "' WHERE Parameter='EmailSMTPServer'; UPDATE Settings SET Value='" + port.ToString() + 
                    "' WHERE Parameter='EmailPort'; UPDATE Settings SET Value='" + username + "' WHERE Parameter='EmailUsername'; UPDATE Settings SET Value='" + password + 
                    "' WHERE Parameter='EmailPassword'; UPDATE Settings SET Value='" + ssl.ToString() + "' WHERE Parameter='EmailEnableSSL'; UPDATE Settings SET Value='" + companyName + 
                    "' WHERE Parameter='CompanyName'; UPDATE Settings SET Value='" + companyOwner + "' WHERE Parameter='CompanyOwner'; UPDATE Settings SET Value='" + companyPhone + 
                    "' WHERE Parameter='CompanyPhone';",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void UpdateOrderStatus(int orderId, string status)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Orders SET Status='" + status + "' WHERE Id='" + orderId + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }
        public static void UpdateOrderIsActive(int orderId, string isActive)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "UPDATE Orders SET IsActive='" + isActive + "' WHERE Id='" + orderId + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void DeleteCustomer(string email)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "DELETE FROM Customers WHERE Email='" + email + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void DeleteStaff(string surname)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "DELETE FROM Staff WHERE Surname='" + surname + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void DeleteCategory(string name)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "DELETE FROM Categories WHERE Name='" + name + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void DeleteProduct(string name)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "DELETE FROM Products WHERE Name='" + name + "'",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static bool CheckUserExists(string email)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT Email FROM Customers WHERE Email='" + email + "'",

                    Connection = connectionCheck
                };

                object result = cmd.ExecuteScalar();

                if(result == DBNull.Value || result == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

                

                
            }

        }

       

        public static void AddCategory(string name, string type)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "INSERT INTO Categories (Name, Type) VALUES ('" + name + "', '" + type + "')",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void NewCustomer(string email, string surname, string firstname, string telephone, string password, string notes, string address1, string address2, string address3, string postcode)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "INSERT INTO Customers (Email, Surname, FirstName, Phone, Password, Notes, Address1, Address2, Address3, PostCode, Status, Registered, LastActive, StatusChanged, " +
                                    "Tier, Orders, HasActiveOrder) VALUES ('" + email + "', '" + surname + "', '" + firstname + "', '" + telephone + "', '" + password + "', '" + notes + "', '" + 
                                    address1 + "', '" + address2 + "', '" + address3 + "', '" + postcode + "', 'Active', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + 
                                    DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '0', '0', 'False')",

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        public static void AddProduct(string name, string category, string shortDescription, string longDescription, string image, decimal sellPrice, decimal buyPrice, string allergens, bool isVegetarian,
                                      bool isVegan, string type, string remarks, string timeFrom, string timeTo)
        {
            using (SqlConnection connectionCheck = new SqlConnection(GetConnectionString()))
            {
                connectionCheck.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "INSERT INTO Products (Name, ShortDescription, LongDescription, Image, IsAvailable, Category, Type, Remarks, TimeFrom, TimeTo, SellPrice, BuyPrice, Allergens," +
                                    " IsVegetarian, IsVegan, AmountSold) VALUES ('" + name.Replace("'", " ") + 
                                    "', '" + shortDescription.Replace("'", " ") + "', '" + longDescription.Replace("'", " ") + "', '" + image + "', 'True', '" + category.Replace("'", " ") + "', '" +
                                    type + "', '" + remarks.Replace("'", " ") + "', '" + timeFrom + "', '" + timeTo + "', '" + sellPrice + "', '" + buyPrice + "', '" + allergens + "', '" + isVegetarian + "', '" + isVegan + 
                                    "', '0')", 

                    Connection = connectionCheck
                };



                cmd.ExecuteNonQuery();


            }
        }

        
    }
}
