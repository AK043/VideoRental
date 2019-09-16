using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
    class videoConnection
    {

        //global declaration of the variable 
        SqlConnection connection;
        String connection_String = "Data Source=DESKTOP-D8TV9DE\\SQLEXPRESS;Initial Catalog=AshuVideoData;Integrated Security=True";
        SqlCommand command;
        SqlDataReader Datareader;

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


        public void registerVideo(String title, String ratting, String year, String cost, String copies, String plot, String genre) {
            connection = new SqlConnection(connection_String);
            connection.Open();
            String qry = "insert into RegisterVideo(Title,Ratting,Year,Cost,Copies,Plot,Genre) values(@title,@ratting,@year,@cost,@copies,@plot,@genre)";
            command = new SqlCommand(qry, connection);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@ratting", ratting);

            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@cost", cost);
            command.Parameters.AddWithValue("@copies", copies);
            command.Parameters.AddWithValue("@plot", plot);
            command.Parameters.AddWithValue("@genre", genre);



            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

        }

        public int deleteVideo(int id) {


            DataTable tbl = new DataTable();
            String query = "select * from RentalVideo where VideoID=" + id + " and VideoReturn='Rent'";
            tbl = fetchData(query);
            if (tbl.Rows.Count > 0)
            {
                return 0;
            }
            else
            {
                connection = new SqlConnection(connection_String);
                connection.Open();
                String qry = "delete from RegisterVideo where id=@id";
                command = new SqlCommand(qry, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return 1;
            }
        }


        public void updateVideo(int id, String title, String ratting, String year, String cost, String copies, String plot, String genre) {
            connection = new SqlConnection(connection_String);
            connection.Open();
            String qry = "update RegisterVideo set Title=@title,Ratting=@ratting,Year=@year,Cost=@cost,Copies=@copies,Plot=@plot,Genre=@genre where id=@id";
            command = new SqlCommand(qry, connection);


            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@ratting", ratting);

            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@cost", cost);
            command.Parameters.AddWithValue("@copies", copies);
            command.Parameters.AddWithValue("@plot", plot);
            command.Parameters.AddWithValue("@genre", genre);



            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

        }


        public String bestMovie() {
            //this method is used to print  the id of the movie which is send most on rent 
            String query = "";
            int countVideo = 0, countID = 0;
            String Title= "";
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();

            query = "select * from RegisterVideo ";
            tbl = fetchData(query);
            for (int y = 0; y < tbl.Rows.Count; y++)
            {
                String query1 = "select * from RentalVideo where VideoID='" + tbl.Rows[y]["id"].ToString() + "'";
                tbl1 = fetchData(query1);
                if (tbl1.Rows.Count > 0)
                {
                    if (tbl1.Rows.Count > countVideo)
                    {
                        countVideo = tbl.Rows.Count;
                        countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                        Title = tbl.Rows[y]["Title"].ToString();
                    }
                }
            }
            return Title;

        }
    }
}
