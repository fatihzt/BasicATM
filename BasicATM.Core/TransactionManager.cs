using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BasicATM.Core
{
    public static class TransactionManager
    {
        public static int Create(Model.Transaction entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Transactions([CustomerId],[Type],[Amount],[TDate]) values (@CustomerId,@Type,@Amount,@TDate)";
                cmd.Parameters.AddWithValue("@CustomerId", entity.CustomerId);
                cmd.Parameters.AddWithValue("@Type", entity.Type);
                cmd.Parameters.AddWithValue("@Amount", entity.Amount);
                cmd.Parameters.AddWithValue("@TDate", entity.TDate);
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
        public static IEnumerable<Model.Transaction> GetTransactionById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = " select * from Transactions where CustomerId=@CustomerId ";
                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Transaction> transactionlist = new List<Model.Transaction>();
                while (dr.Read())
                {
                    Model.Transaction transaction = new Model.Transaction();
                    transaction.Id = Convert.ToInt32(dr["Id"]);
                    transaction.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                    transaction.Type = Enum.Parse<Model.TransactionType>(dr["Type"]?.ToString() ?? "");
                    transaction.Amount = Convert.ToInt32(dr["Amount"]);
                    transaction.TDate = dr["TDate"]?.ToString() ?? "";
                    transactionlist.Add(transaction);
                }
                con.Close();
                return transactionlist;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static IEnumerable<Model.Transaction> GetAllTransactions()
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Transactions";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Transaction> transactionList = new List<Model.Transaction>();
                while (dr.Read())
                {
                    Model.Transaction transaction = new Model.Transaction();
                    transaction.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                    transaction.Type = Enum.Parse<Model.TransactionType>(dr["Type"]?.ToString() ?? "");
                    transaction.Amount = Convert.ToInt32(dr["Amount"]);
                    transaction.TDate = dr["TDate"]?.ToString() ?? "";
                    transactionList.Add(transaction);
                }
                con.Close();
                return transactionList;
            }
            catch (Exception)
            {

                throw;
            }
        }
       
    }
}
