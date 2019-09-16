using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
    class rentalConnection
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


        public int issueVideo(String memberID,String movieID,String issuedate) {

            DataTable tbl = new DataTable();

            DataTable tbl1 = new DataTable();

            DataTable tbl2 = new DataTable();

            String query = "select * from RentalVideo where VideoID=" + Convert.ToInt32(movieID) + " and VideoReturn='Rent'";
            tbl=fetchData(query);

            String query1 = "select * from RegisterVideo where id=" + Convert.ToInt32(movieID) + "";
            tbl1 = fetchData(query1);
            int countvideo =Convert.ToInt32( tbl1.Rows[0]["Copies"].ToString());
        
            String query2 = "select * from RentalVideo where MemberID=" + Convert.ToInt32(memberID) + " and VideoReturn='Rent'";
            tbl2 = fetchData(query2);

            if (tbl2.Rows.Count < 2 && tbl.Rows.Count < countvideo)
            {



                connection = new SqlConnection(connection_String);
                connection.Open();
                String qry = "insert into RentalVideo(MemberID,VideoID,Issue,VideoReturn) values(@MemberID,@VideoID,@Issue,@Return)";
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@MemberID", memberID);
                command.Parameters.AddWithValue("@VideoID", movieID);

                command.Parameters.AddWithValue("@Issue", issuedate);
                command.Parameters.AddWithValue("@Return", "Rent");



                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return 1;
            }
            else {
                return 0;   
            }
        }

        public void delIssueVideo(int id)
        {
            connection = new SqlConnection(connection_String);
            connection.Open();
            String qry = "delete from  RentalVideo where id=@id";
            command = new SqlCommand(qry, connection);

            command.Parameters.AddWithValue("@id",id);
            

            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }


        public int updateIssueVideo(int id, String memberID, String movieID, String issuedate,String returnDate) {

            DataTable tbl1 = new DataTable();

            String query1 = "select * from RegisterVideo where id=" + Convert.ToInt32(movieID) + "";
            tbl1 = fetchData(query1);
            int videoCost = Convert.ToInt32(tbl1.Rows[0]["Cost"].ToString());


            DateTime Current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime Old_date = Convert.ToDateTime(issuedate.ToString());


            //get the difference in the days fromat
            String diffdays = (Current_date - Old_date).TotalDays.ToString();


            // calculate the round off value 
            Double totalDays = Math.Round(Convert.ToDouble(diffdays));

            // return the total cost of the Video
            int price = 0;
            price = videoCost * Convert.ToInt32(totalDays);



            connection = new SqlConnection(connection_String);
            connection.Open();
            String qry = "update RentalVideo set MemberID=@MemberID,VideoID=@VideoID,Issue=@Issue,VideoReturn=@Return where id=@id";
            command = new SqlCommand(qry, connection);


            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@MemberID", memberID);
            command.Parameters.AddWithValue("@VideoID", movieID);

            command.Parameters.AddWithValue("@Issue", issuedate);
            command.Parameters.AddWithValue("@Return", returnDate);



            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return price;

        }
    }
}
