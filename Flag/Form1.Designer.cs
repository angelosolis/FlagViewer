namespace Flag
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
            this.FlagViewerLabel = new System.Windows.Forms.Label();
            this.TitleCheckBox = new System.Windows.Forms.CheckBox();
            this.PhilippinesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.USARadioButton = new System.Windows.Forms.RadioButton();
            this.ColumbiaRadioButton = new System.Windows.Forms.RadioButton();
            this.FranceRadioButton = new System.Windows.Forms.RadioButton();
            this.CountryNameCheckBox = new System.Windows.Forms.CheckBox();
            this.ProgrammerCheckBox = new System.Windows.Forms.CheckBox();
            this.countryPicture = new System.Windows.Forms.PictureBox();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FlagViewerLabel
            // 
            this.FlagViewerLabel.AutoSize = true;
            this.FlagViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagViewerLabel.Location = new System.Drawing.Point(225, 46);
            this.FlagViewerLabel.Name = "FlagViewerLabel";
            this.FlagViewerLabel.Size = new System.Drawing.Size(283, 42);
            this.FlagViewerLabel.TabIndex = 0;
            this.FlagViewerLabel.Text = "FLAG VIEWER";
            // 
            // TitleCheckBox
            // 
            this.TitleCheckBox.AutoSize = true;
            this.TitleCheckBox.Location = new System.Drawing.Point(17, 19);
            this.TitleCheckBox.Name = "TitleCheckBox";
            this.TitleCheckBox.Size = new System.Drawing.Size(46, 17);
            this.TitleCheckBox.TabIndex = 1;
            this.TitleCheckBox.Text = "Title";
            this.TitleCheckBox.UseVisualStyleBackColor = true;
            this.TitleCheckBox.CheckedChanged += new System.EventHandler(this.TitleCheckBox_CheckedChanged);
            // 
            // PhilippinesRadioButton
            // 
            this.PhilippinesRadioButton.AutoSize = true;
            this.PhilippinesRadioButton.Location = new System.Drawing.Point(20, 19);
            this.PhilippinesRadioButton.Name = "PhilippinesRadioButton";
            this.PhilippinesRadioButton.Size = new System.Drawing.Size(75, 17);
            this.PhilippinesRadioButton.TabIndex = 2;
            this.PhilippinesRadioButton.TabStop = true;
            this.PhilippinesRadioButton.Text = "Philippines";
            this.PhilippinesRadioButton.UseVisualStyleBackColor = true;
            this.PhilippinesRadioButton.CheckedChanged += new System.EventHandler(this.PhilippinesRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgrammerCheckBox);
            this.groupBox1.Controls.Add(this.CountryNameCheckBox);
            this.groupBox1.Controls.Add(this.TitleCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(484, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FranceRadioButton);
            this.groupBox2.Controls.Add(this.ColumbiaRadioButton);
            this.groupBox2.Controls.Add(this.USARadioButton);
            this.groupBox2.Controls.Add(this.PhilippinesRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(37, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country";
            // 
            // USARadioButton
            // 
            this.USARadioButton.AutoSize = true;
            this.USARadioButton.Location = new System.Drawing.Point(20, 42);
            this.USARadioButton.Name = "USARadioButton";
            this.USARadioButton.Size = new System.Drawing.Size(47, 17);
            this.USARadioButton.TabIndex = 2;
            this.USARadioButton.TabStop = true;
            this.USARadioButton.Text = "USA";
            this.USARadioButton.UseVisualStyleBackColor = true;
            this.USARadioButton.CheckedChanged += new System.EventHandler(this.USARadioButton_CheckedChanged);
            // 
            // ColumbiaRadioButton
            // 
            this.ColumbiaRadioButton.AutoSize = true;
            this.ColumbiaRadioButton.Location = new System.Drawing.Point(20, 65);
            this.ColumbiaRadioButton.Name = "ColumbiaRadioButton";
            this.ColumbiaRadioButton.Size = new System.Drawing.Size(68, 17);
            this.ColumbiaRadioButton.TabIndex = 2;
            this.ColumbiaRadioButton.TabStop = true;
            this.ColumbiaRadioButton.Text = "Columbia";
            this.ColumbiaRadioButton.UseVisualStyleBackColor = true;
            this.ColumbiaRadioButton.CheckedChanged += new System.EventHandler(this.ColumbiaRadioButton_CheckedChanged);
            // 
            // FranceRadioButton
            // 
            this.FranceRadioButton.AutoSize = true;
            this.FranceRadioButton.Location = new System.Drawing.Point(20, 88);
            this.FranceRadioButton.Name = "FranceRadioButton";
            this.FranceRadioButton.Size = new System.Drawing.Size(58, 17);
            this.FranceRadioButton.TabIndex = 2;
            this.FranceRadioButton.TabStop = true;
            this.FranceRadioButton.Text = "France";
            this.FranceRadioButton.UseVisualStyleBackColor = true;
            this.FranceRadioButton.CheckedChanged += new System.EventHandler(this.FranceRadioButton_CheckedChanged);
            // 
            // CountryNameCheckBox
            // 
            this.CountryNameCheckBox.AutoSize = true;
            this.CountryNameCheckBox.Location = new System.Drawing.Point(17, 42);
            this.CountryNameCheckBox.Name = "CountryNameCheckBox";
            this.CountryNameCheckBox.Size = new System.Drawing.Size(93, 17);
            this.CountryNameCheckBox.TabIndex = 1;
            this.CountryNameCheckBox.Text = "Country Name";
            this.CountryNameCheckBox.UseVisualStyleBackColor = true;
            this.CountryNameCheckBox.CheckedChanged += new System.EventHandler(this.CountryNameCheckBox_CheckedChanged);
            // 
            // ProgrammerCheckBox
            // 
            this.ProgrammerCheckBox.AutoSize = true;
            this.ProgrammerCheckBox.Location = new System.Drawing.Point(17, 66);
            this.ProgrammerCheckBox.Name = "ProgrammerCheckBox";
            this.ProgrammerCheckBox.Size = new System.Drawing.Size(82, 17);
            this.ProgrammerCheckBox.TabIndex = 1;
            this.ProgrammerCheckBox.Text = "Programmer";
            this.ProgrammerCheckBox.UseVisualStyleBackColor = true;
            this.ProgrammerCheckBox.CheckedChanged += new System.EventHandler(this.ProgrammerCheckBox_CheckedChanged);
            // 
            // countryPicture
            // 
            this.countryPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.countryPicture.Location = new System.Drawing.Point(261, 108);
            this.countryPicture.Name = "countryPicture";
            this.countryPicture.Size = new System.Drawing.Size(206, 116);
            this.countryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryPicture.TabIndex = 5;
            this.countryPicture.TabStop = false;
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameLabel.Location = new System.Drawing.Point(336, 240);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(0, 24);
            this.CountryNameLabel.TabIndex = 0;
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerLabel.Location = new System.Drawing.Point(107, 264);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(0, 18);
            this.ProgrammerLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 364);
            this.Controls.Add(this.countryPicture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.FlagViewerLabel);
            this.Name = "Form1";
            this.Text = "Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlagViewerLabel;
        private System.Windows.Forms.CheckBox TitleCheckBox;
        private System.Windows.Forms.RadioButton PhilippinesRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ProgrammerCheckBox;
        private System.Windows.Forms.CheckBox CountryNameCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FranceRadioButton;
        private System.Windows.Forms.RadioButton ColumbiaRadioButton;
        private System.Windows.Forms.RadioButton USARadioButton;
        private System.Windows.Forms.PictureBox countryPicture;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.Label ProgrammerLabel;
    }
}

