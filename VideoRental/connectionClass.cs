using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace VideoRental
{
    class connectionClass
    {

        //global declaration of the variable 
        SqlConnection connection;
        String connection_String = "Data Source=DESKTOP-D8TV9DE\\SQLEXPRESS;Initial Catalog=AshuVideoData;Integrated Security=True";
        SqlCommand command;
        SqlDataReader Datareader;
        int BookingID = 0;


        // user define method that is used to get the record from the table
        public DataTable fetchData(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }
        //this method is used to insert the record in the register member table 

        public void addCustomer(String Name,String Phone,String Address) {
            connection = new SqlConnection(connection_String);
            connection.Open();
            String qry = "insert into RegisterMember(Name,Phone,Address) values(@Name,@Phone,@Address)";
            command = new SqlCommand(qry, connection);

            command.Parameters.AddWithValue("@Name",Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            
            command.Parameters.AddWithValue("@Address", Address);

            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

        }
        // delete the record of the Register Member
        public int delRegisterMember(int Id) {

            DataTable tbl = new DataTable();
            String query = "select * from RentalVideo where MemberID=" + Id + " and VideoReturn='Rent'";
            tbl=fetchData(query);
            if (tbl.Rows.Count > 0)
            {
                return 0;
            }
            else
            {

                connection = new SqlConnection(connection_String);
                connection.Open();
                String qry = "delete RegisterMember where id=@id";
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@id", Id);

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return 1;
            }
        }


        // Update the record of the Register Member
        public void UpdateCustomer(int Id,String Name, String Phone, String Address)
        {
            connection = new SqlConnection(connection_String);
            connection.Open();
            String qry = "update RegisterMember set Name=@Name,Phone=@Phone,Address=@Address where id=@id";
            command = new SqlCommand(qry, connection);

            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);

            command.Parameters.AddWithValue("@Address", Address);

            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

        }

        public String bestCustomer()
        {
            //this method is used to print  the id of the movie which is send most on rent 
            String query = "";
            int countMember = 0, countID = 0;
            String Name = "";
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();

            query = "select * from RegisterMember ";
            tbl = fetchData(query);
            for (int y = 0; y < tbl.Rows.Count; y++)
            {
                String query1 = "select * from RentalVideo where MemberID='" + tbl.Rows[y]["id"].ToString() + "'";
                tbl1 = fetchData(query1);
                if (tbl1.Rows.Count > 0)
                {
                    if (tbl1.Rows.Count > countMember)
                    {
                        countMember= tbl.Rows.Count;
                        countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                        Name = tbl.Rows[y]["Name"].ToString();
                    }
                }
            }
            return Name;

        }
    }
}
