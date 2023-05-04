
namespace AirlineGUI
{
    partial class AddBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.btnDeleteFlights = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnViewFlights = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cusBox = new System.Windows.Forms.ListBox();
            this.flightBox = new System.Windows.Forms.ListBox();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.cusIdTextBox = new System.Windows.Forms.TextBox();
            this.fidLabel = new System.Windows.Forms.Label();
            this.cidLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.btnDeleteFlights);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnViewCustomers);
            this.panel1.Controls.Add(this.btnViewFlights);
            this.panel1.Controls.Add(this.btnAddBooking);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.btnAddFlight);
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(0, 547);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(186, 30);
            this.btnCloseForm.TabIndex = 12;
            this.btnCloseForm.Text = "Exit Booking System";
            this.btnCloseForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.White;
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 200);
            this.PnlNav.TabIndex = 1;
            // 
            // btnDeleteFlights
            // 
            this.btnDeleteFlights.FlatAppearance.BorderSize = 0;
            this.btnDeleteFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFlights.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFlights.Location = new System.Drawing.Point(0, 402);
            this.btnDeleteFlights.Name = "btnDeleteFlights";
            this.btnDeleteFlights.Size = new System.Drawing.Size(186, 30);
            this.btnDeleteFlights.TabIndex = 9;
            this.btnDeleteFlights.Text = "Delete Flights";
            this.btnDeleteFlights.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteFlights.UseVisualStyleBackColor = true;
            this.btnDeleteFlights.Click += new System.EventHandler(this.btnDeleteFlights_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(0, 366);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(186, 30);
            this.btnDeleteCustomer.TabIndex = 8;
            this.btnDeleteCustomer.Text = "Delete Customers";
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewCustomers.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomers.Location = new System.Drawing.Point(0, 330);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(186, 30);
            this.btnViewCustomers.TabIndex = 7;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnViewFlights
            // 
            this.btnViewFlights.FlatAppearance.BorderSize = 0;
            this.btnViewFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewFlights.ForeColor = System.Drawing.Color.White;
            this.btnViewFlights.Location = new System.Drawing.Point(0, 294);
            this.btnViewFlights.Name = "btnViewFlights";
            this.btnViewFlights.Size = new System.Drawing.Size(186, 30);
            this.btnViewFlights.TabIndex = 6;
            this.btnViewFlights.Text = "View Flights";
            this.btnViewFlights.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewFlights.UseVisualStyleBackColor = true;
            this.btnViewFlights.Click += new System.EventHandler(this.btnViewFlights_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.FlatAppearance.BorderSize = 0;
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Location = new System.Drawing.Point(0, 258);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(186, 30);
            this.btnAddBooking.TabIndex = 5;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 222);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(186, 30);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.FlatAppearance.BorderSize = 0;
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(0, 186);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(186, 30);
            this.btnAddFlight.TabIndex = 3;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(0, 150);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(186, 30);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Airline Booking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(422, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Booking";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(316, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 3);
            this.panel3.TabIndex = 21;
            // 
            // cusBox
            // 
            this.cusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBox.FormattingEnabled = true;
            this.cusBox.ItemHeight = 15;
            this.cusBox.Location = new System.Drawing.Point(212, 193);
            this.cusBox.Name = "cusBox";
            this.cusBox.Size = new System.Drawing.Size(235, 214);
            this.cusBox.TabIndex = 22;
            // 
            // flightBox
            // 
            this.flightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightBox.FormattingEnabled = true;
            this.flightBox.ItemHeight = 15;
            this.flightBox.Location = new System.Drawing.Point(676, 193);
            this.flightBox.Name = "flightBox";
            this.flightBox.Size = new System.Drawing.Size(234, 214);
            this.flightBox.TabIndex = 23;
            // 
            // btnCus
            // 
            this.btnCus.FlatAppearance.BorderSize = 0;
            this.btnCus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCus.ForeColor = System.Drawing.Color.White;
            this.btnCus.Location = new System.Drawing.Point(235, 435);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(186, 30);
            this.btnCus.TabIndex = 13;
            this.btnCus.Text = "View Customers";
            this.btnCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnFlights
            // 
            this.btnFlights.FlatAppearance.BorderSize = 0;
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFlights.ForeColor = System.Drawing.Color.White;
            this.btnFlights.Location = new System.Drawing.Point(703, 435);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(186, 30);
            this.btnFlights.TabIndex = 24;
            this.btnFlights.Text = "View Flights";
            this.btnFlights.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFlights.UseVisualStyleBackColor = true;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(470, 363);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(186, 30);
            this.btnAddBook.TabIndex = 25;
            this.btnAddBook.Text = "Add Booking";
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flightIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightIdTextBox.Location = new System.Drawing.Point(481, 294);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(166, 26);
            this.flightIdTextBox.TabIndex = 26;
            // 
            // cusIdTextBox
            // 
            this.cusIdTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cusIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusIdTextBox.Location = new System.Drawing.Point(481, 222);
            this.cusIdTextBox.Name = "cusIdTextBox";
            this.cusIdTextBox.Size = new System.Drawing.Size(166, 26);
            this.cusIdTextBox.TabIndex = 27;
            // 
            // fidLabel
            // 
            this.fidLabel.AutoSize = true;
            this.fidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fidLabel.Location = new System.Drawing.Point(479, 262);
            this.fidLabel.Name = "fidLabel";
            this.fidLabel.Size = new System.Drawing.Size(170, 20);
            this.fidLabel.TabIndex = 30;
            this.fidLabel.Text = "Enter Flight Number";
            // 
            // cidLabel
            // 
            this.cidLabel.AutoSize = true;
            this.cidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cidLabel.Location = new System.Drawing.Point(484, 193);
            this.cidLabel.Name = "cidLabel";
            this.cidLabel.Size = new System.Drawing.Size(159, 20);
            this.cidLabel.TabIndex = 31;
            this.cidLabel.Text = "Enter Customer ID";
            // 
            // AddBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.cidLabel);
            this.Controls.Add(this.fidLabel);
            this.Controls.Add(this.cusIdTextBox);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.flightBox);
            this.Controls.Add(this.cusBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewFlights;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button btnDeleteFlights;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox cusBox;
        private System.Windows.Forms.ListBox flightBox;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.TextBox cusIdTextBox;
        private System.Windows.Forms.Label fidLabel;
        private System.Windows.Forms.Label cidLabel;
    }
}

