using System;
using System.Windows;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATM.Core
{
    public static class CustomerManager
    {

        public static int Create(Model.Customer entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Customers([Pin],[Name],[CardNumber],[Username],[Age],[Phone],[Address],[Balance],[IsCreditCard]) values (@Pin,@Name,@CardNumber,@Username,@Age,@Phone,@Address,@Balance,@IsCreditCard)";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@Pin", entity.Pin);
                cmd.Parameters.AddWithValue("@Age", entity.Age);
                cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                cmd.Parameters.AddWithValue("@Address", entity.Address);
                cmd.Parameters.AddWithValue("@Balance", entity.Balance);
                cmd.Parameters.AddWithValue("@Username", entity.Username);
                cmd.Parameters.AddWithValue("@CardNumber", entity.CardNumber);
                cmd.Parameters.AddWithValue("@IsCreditCard", entity.IsCreditCard);
                con.Open();
                int value = cmd.ExecuteNonQuery();
                con.Close();
                return value;
            }
            catch (Exception)
            {

                return -1;
            }
        }
        public static Model.Customer GetCustomerLogin(string cardnumber, string pin,bool iscreditcard)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Customers where CardNumber=@CardNumber and Pin=@Pin and IsCreditCard=@IsCreditCard";
                cmd.Parameters.AddWithValue("@CardNumber", cardnumber);
                cmd.Parameters.AddWithValue("@Pin", pin);
                cmd.Parameters.AddWithValue("@IsCreditCard", iscreditcard);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Customer customer = new Model.Customer();
                while (dr.Read())
                {
                    customer.Id = Convert.ToInt32(dr["Id"]);
                    customer.Pin = dr["Pin"]?.ToString() ?? "";
                    customer.Name = dr["Name"]?.ToString() ?? "";
                    customer.CardNumber = dr["CardNumber"]?.ToString() ?? "";
                    customer.Username = dr["Username"]?.ToString() ?? "";
                    customer.Age = dr["Age"]?.ToString() ?? "";
                    customer.Phone = dr["Phone"]?.ToString() ?? "";
                    customer.Address = dr["Address"]?.ToString() ?? "";
                    customer.Balance = Convert.ToInt32(dr["Balance"]);
                    customer.IsCreditCard = (bool)dr["IsCreditCard"];
                }
                con.Close();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Model.Customer GetCustomerById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Customers where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Model.Customer customer = new Model.Customer();
                while (dr.Read())
                {
                    customer.Id = Convert.ToInt32(dr["Id"]);
                    customer.Pin = dr["Pin"]?.ToString() ?? "";
                    customer.Name = dr["Name"]?.ToString() ?? "";
                    customer.CardNumber = dr["CardNumber"]?.ToString() ?? "";
                    customer.Username = dr["Username"]?.ToString() ?? "";
                    customer.Age = dr["Age"]?.ToString() ?? "";
                    customer.Phone = dr["Phone"]?.ToString() ?? "";
                    customer.Address = dr["Address"]?.ToString() ?? "";
                    customer.Balance = Convert.ToInt32(dr["Balance"]);
                    customer.IsCreditCard = (bool)dr["IsCreditCard"];
                }
                con.Close();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool UpdateCustomersBalance(int totalBalance,int id)
        {
            try
            {
                //int total = balance + oldbalance;
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Customers set Balance=@Balance where Id=@Id";
                cmd.Parameters.AddWithValue("@Balance", totalBalance);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                bool value = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return value;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool UpdateCustomersPin(string pin,int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Customers set Pin=@Pin where Id=@Id";
                cmd.Parameters.AddWithValue("@Pin", pin);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                bool value = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return value;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static Model.Customer GetCustomersBalanceById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Balance from Customers where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Model.Customer customer = new Model.Customer();
                while (dr.Read())
                {

                    customer.Balance = Convert.ToInt32(dr["Balance"]);


                }
                con.Close();
                return customer;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
