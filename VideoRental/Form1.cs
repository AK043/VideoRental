using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class Form1 : Form
    {
        connectionClass instance_Register = new connectionClass();
        videoConnection instance_Video = new videoConnection();
        rentalConnection instance_Rent = new rentalConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (!Name.Text.ToString().Equals("") && !Phone.Text.ToString().Equals("") && !Address.Text.ToString().Equals(""))
            {
                instance_Register.addCustomer(Name.Text.ToString(), Phone.Text.ToString(), Address.Text.ToString());
                MessageBox.Show("Member is registered in the System App");
            }
            else
            {
                MessageBox.Show("Fill all details of the Customer to Register ");
            }
            clearAll();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals(""))
            {
                if (instance_Register.delRegisterMember(Convert.ToInt32(CustomerID.Text.ToString())) == 1)
                {
                    MessageBox.Show("Member is deleted from the System App");
                }
                else {
                    MessageBox.Show("You already have an video on rent ");
                }
                
            }
            else
            {
                MessageBox.Show("Select the member to delete from the system app");
            }
            clearAll();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals("") && !Name.Text.ToString().Equals("") && !Phone.Text.ToString().Equals("") && !Address.Text.ToString().Equals(""))
            {
                instance_Register.UpdateCustomer(Convert.ToInt32(CustomerID.Text.ToString()), Name.Text.ToString(), Phone.Text.ToString(), Address.Text.ToString());
                MessageBox.Show("Sucessfuly update the Record of the Member in the System App ");
            }
            clearAll();

        }

        private void AddVideo_Click(object sender, EventArgs e)
        {
            if (!title.Text.ToString().Equals("") && !Ratting.Text.ToString().Equals("") && !Year.Text.ToString().Equals("") && !Cost.Text.ToString().Equals("") && !Copies.Text.ToString().Equals("") && !Plot.Text.ToString().Equals("") && !Genre.Text.ToString().Equals(""))
            {

                instance_Video.registerVideo(title.Text.ToString(), Ratting.Text.ToString(), Year.Text.ToString(), Cost.Text.ToString(), Copies.Text.ToString(), Plot.Text.ToString(), Genre.Text.ToString());
                MessageBox.Show("Video Record is saved in the System App");
            }
            else
            {
                MessageBox.Show("Write all the details of the video to record in the system app");
            }
            clearAll();
        }

        private void delVideo_Click(object sender, EventArgs e)
        {
            if (!MovieID.Text.ToString().Equals(""))
            {
                if (instance_Video.deleteVideo(Convert.ToInt32(MovieID.Text.ToString())) == 1)
                {
                    MessageBox.Show("video record is deleted from the system app");
                }
                else {
                    MessageBox.Show("Video is already on rent so can't be delete it ");
                }
            }
            else
            {
                MessageBox.Show("Select the video record to delete from the system app");
            }
            clearAll();
        }

        private void updateVideo_Click(object sender, EventArgs e)
        {
            if (!MovieID.Text.ToString().Equals("") && !title.Text.ToString().Equals("") && !Ratting.Text.ToString().Equals("") && !Year.Text.ToString().Equals("") && !Cost.Text.ToString().Equals("") && !Copies.Text.ToString().Equals("") && !Plot.Text.ToString().Equals("") && !Genre.Text.ToString().Equals(""))
            {
                instance_Video.updateVideo(Convert.ToInt32(MovieID.Text.ToString()), title.Text.ToString(), Ratting.Text.ToString(), Year.Text.ToString(), Cost.Text.ToString(), Copies.Text.ToString(), Plot.Text.ToString(), Genre.Text.ToString());
                MessageBox.Show("Video Record is Update in the System App");
            }
            else
            {
                MessageBox.Show("Write all the details of the movie to update the record from the system app ");
            }
            clearAll();
        }

        private void rentalIssue_Click(object sender, EventArgs e)
        {
            if (!MovieID.Text.ToString().Equals("") && !CustomerID.Text.ToString().Equals(""))
            {
                if (instance_Rent.issueVideo(CustomerID.Text.ToString(), MovieID.Text.ToString(), Issue.Text.ToString()) == 1)
                {
                    MessageBox.Show("Movie is Issued on rent and record in the system app");
                }
                else {
                    MessageBox.Show("There is an issue like no more cd's are available or may be customer has 2 video on rent ");
                }

            }
            else {
                MessageBox.Show("Select the Registered  member and video to issue a movie on rent");
            }
            clearAll();
        }


        private void rentalDelete_Click(object sender, EventArgs e)
        {
            instance_Rent.delIssueVideo(Convert.ToInt32(CustomerID.Text.ToString()));
            MessageBox.Show("Rental video record is delete from the system app");
            clearAll();
        }

        private void rentalReturn_Click(object sender, EventArgs e)
        {
            if (!MovieID.Text.ToString().Equals("") && !CustomerID.Text.ToString().Equals(""))
            {
                int bill=instance_Rent.updateIssueVideo(1,CustomerID.Text.ToString(), MovieID.Text.ToString(), Issue.Text.ToString(),Return.Text.ToString());


                MessageBox.Show("movie is return to the system and your total bill is=$"+bill);
            }
            else {
                MessageBox.Show("select the movie to return ");
            }
            clearAll();
        }

        private void VideoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoChk.Checked==true) {
                CustomerChk.Checked = false;
                RentChk.Checked = false;
                DataTable tbl = new DataTable();

                String query = "select * from RegisterVideo ";
                tbl = instance_Video.fetchData(query);
                VideoRecord.DataSource = tbl;
            }
        }

        private void CustomerChk_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerChk.Checked==true) {
                VideoChk.Checked = false;
                RentChk.Checked = false;
                DataTable tbl = new DataTable();

                String query = "select * from RegisterMember ";
                tbl = instance_Video.fetchData(query);
                VideoRecord.DataSource = tbl;
            }
        }

        private void RentChk_CheckedChanged(object sender, EventArgs e)
        {
            if (RentChk.Checked==true) {
                VideoChk.Checked = false;
                CustomerChk.Checked = false;
                DataTable tbl = new DataTable();

                String query = "select * from RentalVideo";
                tbl = instance_Video.fetchData(query);
                VideoRecord.DataSource = tbl;
            }
        }

        private void VideoRecord_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void VideoRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VideoChk.Checked == true)
            {
                MovieID.Text = VideoRecord.CurrentRow.Cells[0].Value.ToString();
                title.Text = VideoRecord.CurrentRow.Cells[1].Value.ToString();
                Ratting.Text = VideoRecord.CurrentRow.Cells[2].Value.ToString();
                Year.Text = VideoRecord.CurrentRow.Cells[3].Value.ToString();
                Cost.Text = VideoRecord.CurrentRow.Cells[4].Value.ToString();
                Copies.Text = VideoRecord.CurrentRow.Cells[5].Value.ToString();
                Plot.Text = VideoRecord.CurrentRow.Cells[6].Value.ToString();
                Genre.Text = VideoRecord.CurrentRow.Cells[7].Value.ToString();

            }
            if (CustomerChk.Checked == true)
            {
                CustomerID.Text = VideoRecord.CurrentRow.Cells[0].Value.ToString();
                Name.Text = VideoRecord.CurrentRow.Cells[1].Value.ToString();
                Phone.Text = VideoRecord.CurrentRow.Cells[2].Value.ToString();
                Address.Text = VideoRecord.CurrentRow.Cells[3].Value.ToString();

            }
            if (RentChk.Checked == true)
            {
                rentidLabel.Text = "Rent ID";
                rentID.Text = VideoRecord.CurrentRow.Cells[0].Value.ToString();
                CustomerID.Text = VideoRecord.CurrentRow.Cells[1].Value.ToString();
                MovieID.Text = VideoRecord.CurrentRow.Cells[2].Value.ToString();
                Issue.Text = VideoRecord.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void Year_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //dislay the cost of the price of the video after adding the year of the video
                DateTime Currentdate = DateTime.Now;

                int year = Currentdate.Year;

                int diff = year - Convert.ToInt32(Year.Text.ToString());
                // MessageBox.Show(diff.ToString());
                if (diff >= 5)
                {
                    Cost.Text = "2";
                }
                if (diff >= 0 && diff < 5)
                {
                    Cost.Text = "5";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void MovieTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the Best Movie Title Name is=" + instance_Video.bestMovie());
            clearAll();
        }

        private void TopCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the Best Customer Name is=" + instance_Register.bestCustomer());
            clearAll();
        }

        public void clearAll() {

            title.Text = "";
            Ratting.Text = "";
            Year.Text = "";
            Cost.Text = "";
            Copies.Text = "";
            Plot.Text = "";
            Genre.Text = "";

            Name.Text = "";
            Phone.Text = "";
            Address.Text = "";

            MovieID.Text = "";
            CustomerID.Text = "";
            rentID.Text = "";
            rentidLabel.Text = "";

            CustomerChk.Checked = false;
            VideoChk.Checked = false;
            RentChk.Checked = false;

        }
    }
}
