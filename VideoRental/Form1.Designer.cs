namespace VideoRental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label17 = new System.Windows.Forms.Label();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.DateTimePicker();
            this.Issue = new System.Windows.Forms.DateTimePicker();
            this.rentalDelete = new System.Windows.Forms.Button();
            this.rentalReturn = new System.Windows.Forms.Button();
            this.rentalIssue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.RegisterCustomer = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.TextBox();
            this.Copies = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Ratting = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.VideoRecord = new System.Windows.Forms.DataGridView();
            this.VideoChk = new System.Windows.Forms.CheckBox();
            this.CustomerChk = new System.Windows.Forms.CheckBox();
            this.RentChk = new System.Windows.Forms.CheckBox();
            this.rentidLabel = new System.Windows.Forms.Label();
            this.rentID = new System.Windows.Forms.Label();
            this.MovieTop = new System.Windows.Forms.Button();
            this.TopCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VideoRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(395, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 24);
            this.label17.TabIndex = 87;
            this.label17.Text = "Rental Area";
            // 
            // MovieID
            // 
            this.MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieID.Location = new System.Drawing.Point(465, 125);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(154, 32);
            this.MovieID.TabIndex = 86;
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(465, 84);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(154, 32);
            this.CustomerID.TabIndex = 85;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Return.Location = new System.Drawing.Point(468, 203);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(154, 32);
            this.Return.TabIndex = 84;
            // 
            // Issue
            // 
            this.Issue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Issue.Location = new System.Drawing.Point(466, 164);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(154, 32);
            this.Issue.TabIndex = 83;
            // 
            // rentalDelete
            // 
            this.rentalDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDelete.Location = new System.Drawing.Point(324, 283);
            this.rentalDelete.Name = "rentalDelete";
            this.rentalDelete.Size = new System.Drawing.Size(274, 37);
            this.rentalDelete.TabIndex = 82;
            this.rentalDelete.Text = "Delete";
            this.rentalDelete.UseVisualStyleBackColor = true;
            this.rentalDelete.Click += new System.EventHandler(this.rentalDelete_Click);
            // 
            // rentalReturn
            // 
            this.rentalReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturn.Location = new System.Drawing.Point(444, 245);
            this.rentalReturn.Name = "rentalReturn";
            this.rentalReturn.Size = new System.Drawing.Size(154, 32);
            this.rentalReturn.TabIndex = 81;
            this.rentalReturn.Text = "Return";
            this.rentalReturn.UseVisualStyleBackColor = true;
            this.rentalReturn.Click += new System.EventHandler(this.rentalReturn_Click);
            // 
            // rentalIssue
            // 
            this.rentalIssue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalIssue.Location = new System.Drawing.Point(322, 245);
            this.rentalIssue.Name = "rentalIssue";
            this.rentalIssue.Size = new System.Drawing.Size(101, 32);
            this.rentalIssue.TabIndex = 80;
            this.rentalIssue.Text = "Issue";
            this.rentalIssue.UseVisualStyleBackColor = true;
            this.rentalIssue.Click += new System.EventHandler(this.rentalIssue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 79;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(309, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 78;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(318, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 77;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(318, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 76;
            this.label15.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "Customer Area";
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer.Location = new System.Drawing.Point(21, 218);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(274, 37);
            this.deleteCustomer.TabIndex = 74;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(141, 180);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(154, 32);
            this.updateCustomer.TabIndex = 73;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // RegisterCustomer
            // 
            this.RegisterCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCustomer.Location = new System.Drawing.Point(19, 180);
            this.RegisterCustomer.Name = "RegisterCustomer";
            this.RegisterCustomer.Size = new System.Drawing.Size(101, 32);
            this.RegisterCustomer.TabIndex = 70;
            this.RegisterCustomer.Text = "Add";
            this.RegisterCustomer.UseVisualStyleBackColor = true;
            this.RegisterCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(141, 136);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(154, 32);
            this.Address.TabIndex = 72;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(141, 97);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(154, 32);
            this.Phone.TabIndex = 71;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(141, 56);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(154, 32);
            this.Name.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 67;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 66;
            this.label9.Text = "Mobile No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 64;
            this.label11.Text = " Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(99, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 24);
            this.label18.TabIndex = 105;
            this.label18.Text = "Movie Area";
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(213, 606);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(85, 32);
            this.delVideo.TabIndex = 104;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(122, 606);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(85, 32);
            this.updateVideo.TabIndex = 103;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(31, 606);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(85, 32);
            this.AddVideo.TabIndex = 102;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(149, 550);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(154, 32);
            this.Genre.TabIndex = 101;
            // 
            // Plot
            // 
            this.Plot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plot.Location = new System.Drawing.Point(149, 512);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(154, 32);
            this.Plot.TabIndex = 100;
            // 
            // Copies
            // 
            this.Copies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copies.Location = new System.Drawing.Point(149, 476);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(154, 32);
            this.Copies.TabIndex = 99;
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(149, 440);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(154, 32);
            this.Cost.TabIndex = 98;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(149, 402);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(154, 32);
            this.Year.TabIndex = 97;
            this.Year.TextChanged += new System.EventHandler(this.Year_TextChanged);
            this.Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_KeyPress);
            // 
            // Ratting
            // 
            this.Ratting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratting.Location = new System.Drawing.Point(149, 364);
            this.Ratting.Name = "Ratting";
            this.Ratting.Size = new System.Drawing.Size(154, 32);
            this.Ratting.TabIndex = 96;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(149, 326);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(154, 32);
            this.title.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 94;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 93;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 92;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 91;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 90;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(48, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 88;
            this.label16.Text = "Title";
            // 
            // VideoRecord
            // 
            this.VideoRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideoRecord.Location = new System.Drawing.Point(369, 326);
            this.VideoRecord.Name = "VideoRecord";
            this.VideoRecord.Size = new System.Drawing.Size(665, 312);
            this.VideoRecord.TabIndex = 106;
            this.VideoRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VideoRecord_CellContentClick);
            this.VideoRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VideoRecord_CellContentDoubleClick);
            // 
            // VideoChk
            // 
            this.VideoChk.AutoSize = true;
            this.VideoChk.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoChk.Location = new System.Drawing.Point(626, 252);
            this.VideoChk.Name = "VideoChk";
            this.VideoChk.Size = new System.Drawing.Size(70, 27);
            this.VideoChk.TabIndex = 107;
            this.VideoChk.Text = "Video";
            this.VideoChk.UseVisualStyleBackColor = true;
            this.VideoChk.CheckedChanged += new System.EventHandler(this.VideoChk_CheckedChanged);
            // 
            // CustomerChk
            // 
            this.CustomerChk.AutoSize = true;
            this.CustomerChk.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerChk.Location = new System.Drawing.Point(702, 252);
            this.CustomerChk.Name = "CustomerChk";
            this.CustomerChk.Size = new System.Drawing.Size(96, 27);
            this.CustomerChk.TabIndex = 108;
            this.CustomerChk.Text = "Customer";
            this.CustomerChk.UseVisualStyleBackColor = true;
            this.CustomerChk.CheckedChanged += new System.EventHandler(this.CustomerChk_CheckedChanged);
            // 
            // RentChk
            // 
            this.RentChk.AutoSize = true;
            this.RentChk.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentChk.Location = new System.Drawing.Point(818, 252);
            this.RentChk.Name = "RentChk";
            this.RentChk.Size = new System.Drawing.Size(61, 27);
            this.RentChk.TabIndex = 109;
            this.RentChk.Text = "Rent";
            this.RentChk.UseVisualStyleBackColor = true;
            this.RentChk.CheckedChanged += new System.EventHandler(this.RentChk_CheckedChanged);
            // 
            // rentidLabel
            // 
            this.rentidLabel.AutoSize = true;
            this.rentidLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentidLabel.Location = new System.Drawing.Point(318, 56);
            this.rentidLabel.Name = "rentidLabel";
            this.rentidLabel.Size = new System.Drawing.Size(0, 24);
            this.rentidLabel.TabIndex = 110;
            // 
            // rentID
            // 
            this.rentID.AutoSize = true;
            this.rentID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentID.Location = new System.Drawing.Point(464, 56);
            this.rentID.Name = "rentID";
            this.rentID.Size = new System.Drawing.Size(0, 24);
            this.rentID.TabIndex = 111;
            // 
            // MovieTop
            // 
            this.MovieTop.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTop.Location = new System.Drawing.Point(646, 101);
            this.MovieTop.Name = "MovieTop";
            this.MovieTop.Size = new System.Drawing.Size(274, 37);
            this.MovieTop.TabIndex = 112;
            this.MovieTop.Text = "Top Movie";
            this.MovieTop.UseVisualStyleBackColor = true;
            this.MovieTop.Click += new System.EventHandler(this.MovieTop_Click);
            // 
            // TopCustomer
            // 
            this.TopCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopCustomer.Location = new System.Drawing.Point(646, 155);
            this.TopCustomer.Name = "TopCustomer";
            this.TopCustomer.Size = new System.Drawing.Size(274, 37);
            this.TopCustomer.TabIndex = 113;
            this.TopCustomer.Text = "Top Customer";
            this.TopCustomer.UseVisualStyleBackColor = true;
            this.TopCustomer.Click += new System.EventHandler(this.TopCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 693);
            this.Controls.Add(this.TopCustomer);
            this.Controls.Add(this.MovieTop);
            this.Controls.Add(this.rentID);
            this.Controls.Add(this.rentidLabel);
            this.Controls.Add(this.RentChk);
            this.Controls.Add(this.CustomerChk);
            this.Controls.Add(this.VideoChk);
            this.Controls.Add(this.VideoRecord);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.delVideo);
            this.Controls.Add(this.updateVideo);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Ratting);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.rentalDelete);
            this.Controls.Add(this.rentalReturn);
            this.Controls.Add(this.rentalIssue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.RegisterCustomer);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
           
            ((System.ComponentModel.ISupportInitialize)(this.VideoRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker Return;
        private System.Windows.Forms.DateTimePicker Issue;
        private System.Windows.Forms.Button rentalDelete;
        private System.Windows.Forms.Button rentalReturn;
        private System.Windows.Forms.Button rentalIssue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button RegisterCustomer;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Plot;
        private System.Windows.Forms.TextBox Copies;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Ratting;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView VideoRecord;
        private System.Windows.Forms.CheckBox VideoChk;
        private System.Windows.Forms.CheckBox CustomerChk;
        private System.Windows.Forms.CheckBox RentChk;
        private System.Windows.Forms.Label rentidLabel;
        private System.Windows.Forms.Label rentID;
        private System.Windows.Forms.Button MovieTop;
        private System.Windows.Forms.Button TopCustomer;
    }
}

