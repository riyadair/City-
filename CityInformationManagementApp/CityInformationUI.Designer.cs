namespace CityInformationManagementApp
{
    partial class CityInformationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.aboutCityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cityListView = new System.Windows.Forms.ListView();
            this.serialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aboutColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByCountryRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByCityRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cityNameTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.aboutCityTextBox);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Information";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(117, 28);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.cityNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(221, 147);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // aboutCityTextBox
            // 
            this.aboutCityTextBox.Location = new System.Drawing.Point(117, 62);
            this.aboutCityTextBox.Multiline = true;
            this.aboutCityTextBox.Name = "aboutCityTextBox";
            this.aboutCityTextBox.Size = new System.Drawing.Size(179, 47);
            this.aboutCityTextBox.TabIndex = 1;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(117, 121);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(179, 20);
            this.countryTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cityListView);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchByCountryRadioButton);
            this.groupBox2.Controls.Add(this.searchByCityRadioButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cityListView
            // 
            this.cityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialColumnHeader,
            this.cityNameColumnHeader,
            this.aboutColumnHeader,
            this.countryColumnHeader});
            this.cityListView.FullRowSelect = true;
            this.cityListView.GridLines = true;
            this.cityListView.Location = new System.Drawing.Point(7, 65);
            this.cityListView.Name = "cityListView";
            this.cityListView.Size = new System.Drawing.Size(466, 172);
            this.cityListView.TabIndex = 3;
            this.cityListView.UseCompatibleStateImageBehavior = false;
            this.cityListView.View = System.Windows.Forms.View.Details;
            this.cityListView.DoubleClick += new System.EventHandler(this.cityListView_DoubleClick);
            // 
            // serialColumnHeader
            // 
            this.serialColumnHeader.Text = "Serial";
            this.serialColumnHeader.Width = 53;
            // 
            // cityNameColumnHeader
            // 
            this.cityNameColumnHeader.Text = "City Name";
            this.cityNameColumnHeader.Width = 108;
            // 
            // aboutColumnHeader
            // 
            this.aboutColumnHeader.Text = "About";
            this.aboutColumnHeader.Width = 206;
            // 
            // countryColumnHeader
            // 
            this.countryColumnHeader.Text = "Country";
            this.countryColumnHeader.Width = 92;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(351, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByCountryRadioButton
            // 
            this.searchByCountryRadioButton.AutoSize = true;
            this.searchByCountryRadioButton.Location = new System.Drawing.Point(16, 42);
            this.searchByCountryRadioButton.Name = "searchByCountryRadioButton";
            this.searchByCountryRadioButton.Size = new System.Drawing.Size(112, 17);
            this.searchByCountryRadioButton.TabIndex = 2;
            this.searchByCountryRadioButton.TabStop = true;
            this.searchByCountryRadioButton.Text = "Search by Country";
            this.searchByCountryRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByCityRadioButton
            // 
            this.searchByCityRadioButton.AutoSize = true;
            this.searchByCityRadioButton.Location = new System.Drawing.Point(16, 19);
            this.searchByCityRadioButton.Name = "searchByCityRadioButton";
            this.searchByCityRadioButton.Size = new System.Drawing.Size(93, 17);
            this.searchByCityRadioButton.TabIndex = 1;
            this.searchByCityRadioButton.TabStop = true;
            this.searchByCityRadioButton.Text = "Search by City";
            this.searchByCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(158, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(177, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // CityInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CityInformationUI";
            this.Text = "City Information";
            this.Load += new System.EventHandler(this.CityInformationUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox aboutCityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView cityListView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton searchByCountryRadioButton;
        private System.Windows.Forms.RadioButton searchByCityRadioButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ColumnHeader serialColumnHeader;
        private System.Windows.Forms.ColumnHeader cityNameColumnHeader;
        private System.Windows.Forms.ColumnHeader aboutColumnHeader;
        private System.Windows.Forms.ColumnHeader countryColumnHeader;
    }
}

