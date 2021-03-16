namespace NumberGuessingGame
{
    partial class NumberGuessingGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberGuessingGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUserNumber = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.listBoxUserPrediction = new System.Windows.Forms.ListBox();
            this.labelDif = new System.Windows.Forms.Label();
            this.labelSame = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPrediction = new System.Windows.Forms.TextBox();
            this.buttonPredictNumberUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxComputer = new System.Windows.Forms.GroupBox();
            this.listBoxComputerPrediction = new System.Windows.Forms.ListBox();
            this.comboBoxDifOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxSameOrder = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonPredictNumberComputer = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestart = new System.Windows.Forms.PictureBox();
            this.pictureBoxInformation = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(733, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilgisayar";
            // 
            // LabelUserNumber
            // 
            this.LabelUserNumber.AutoSize = true;
            this.LabelUserNumber.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelUserNumber.Location = new System.Drawing.Point(0, 39);
            this.LabelUserNumber.Name = "LabelUserNumber";
            this.LabelUserNumber.Size = new System.Drawing.Size(292, 128);
            this.LabelUserNumber.TabIndex = 0;
            this.LabelUserNumber.Text = "_ _ _ _";
            this.LabelUserNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.listBoxUserPrediction);
            this.groupBoxUser.Controls.Add(this.labelDif);
            this.groupBoxUser.Controls.Add(this.labelSame);
            this.groupBoxUser.Controls.Add(this.pictureBox2);
            this.groupBoxUser.Controls.Add(this.pictureBox1);
            this.groupBoxUser.Controls.Add(this.textBoxPrediction);
            this.groupBoxUser.Controls.Add(this.buttonPredictNumberUser);
            this.groupBoxUser.Controls.Add(this.LabelUserNumber);
            this.groupBoxUser.Location = new System.Drawing.Point(575, 79);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(550, 435);
            this.groupBoxUser.TabIndex = 2;
            this.groupBoxUser.TabStop = false;
            // 
            // listBoxUserPrediction
            // 
            this.listBoxUserPrediction.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBoxUserPrediction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxUserPrediction.FormattingEnabled = true;
            this.listBoxUserPrediction.ItemHeight = 17;
            this.listBoxUserPrediction.Location = new System.Drawing.Point(279, 13);
            this.listBoxUserPrediction.Name = "listBoxUserPrediction";
            this.listBoxUserPrediction.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxUserPrediction.Size = new System.Drawing.Size(260, 395);
            this.listBoxUserPrediction.TabIndex = 6;
            // 
            // labelDif
            // 
            this.labelDif.AutoSize = true;
            this.labelDif.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDif.Location = new System.Drawing.Point(192, 408);
            this.labelDif.Name = "labelDif";
            this.labelDif.Size = new System.Drawing.Size(0, 29);
            this.labelDif.TabIndex = 5;
            // 
            // labelSame
            // 
            this.labelSame.AutoSize = true;
            this.labelSame.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSame.Location = new System.Drawing.Point(113, 408);
            this.labelSame.Name = "labelSame";
            this.labelSame.Size = new System.Drawing.Size(0, 29);
            this.labelSame.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(180, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPrediction
            // 
            this.textBoxPrediction.BackColor = System.Drawing.Color.White;
            this.textBoxPrediction.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrediction.Location = new System.Drawing.Point(92, 192);
            this.textBoxPrediction.MaxLength = 4;
            this.textBoxPrediction.Name = "textBoxPrediction";
            this.textBoxPrediction.Size = new System.Drawing.Size(150, 39);
            this.textBoxPrediction.TabIndex = 3;
            this.textBoxPrediction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrediction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrediction_KeyPress);
            // 
            // buttonPredictNumberUser
            // 
            this.buttonPredictNumberUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPredictNumberUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPredictNumberUser.ForeColor = System.Drawing.Color.White;
            this.buttonPredictNumberUser.Location = new System.Drawing.Point(92, 237);
            this.buttonPredictNumberUser.Name = "buttonPredictNumberUser";
            this.buttonPredictNumberUser.Size = new System.Drawing.Size(150, 40);
            this.buttonPredictNumberUser.TabIndex = 2;
            this.buttonPredictNumberUser.Text = "Tahmin Et";
            this.buttonPredictNumberUser.UseVisualStyleBackColor = false;
            this.buttonPredictNumberUser.Click += new System.EventHandler(this.buttonPredictNumberUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 128);
            this.label3.TabIndex = 0;
            this.label3.Text = "_ _ _ _";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxComputer
            // 
            this.groupBoxComputer.Controls.Add(this.listBoxComputerPrediction);
            this.groupBoxComputer.Controls.Add(this.comboBoxDifOrder);
            this.groupBoxComputer.Controls.Add(this.comboBoxSameOrder);
            this.groupBoxComputer.Controls.Add(this.pictureBox4);
            this.groupBoxComputer.Controls.Add(this.pictureBox3);
            this.groupBoxComputer.Controls.Add(this.buttonPredictNumberComputer);
            this.groupBoxComputer.Controls.Add(this.label3);
            this.groupBoxComputer.Location = new System.Drawing.Point(12, 78);
            this.groupBoxComputer.Name = "groupBoxComputer";
            this.groupBoxComputer.Size = new System.Drawing.Size(550, 435);
            this.groupBoxComputer.TabIndex = 2;
            this.groupBoxComputer.TabStop = false;
            // 
            // listBoxComputerPrediction
            // 
            this.listBoxComputerPrediction.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBoxComputerPrediction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxComputerPrediction.FormattingEnabled = true;
            this.listBoxComputerPrediction.ItemHeight = 17;
            this.listBoxComputerPrediction.Location = new System.Drawing.Point(280, 13);
            this.listBoxComputerPrediction.Name = "listBoxComputerPrediction";
            this.listBoxComputerPrediction.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxComputerPrediction.Size = new System.Drawing.Size(260, 395);
            this.listBoxComputerPrediction.TabIndex = 6;
            // 
            // comboBoxDifOrder
            // 
            this.comboBoxDifOrder.BackColor = System.Drawing.Color.White;
            this.comboBoxDifOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDifOrder.FormattingEnabled = true;
            this.comboBoxDifOrder.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4"});
            this.comboBoxDifOrder.Location = new System.Drawing.Point(142, 193);
            this.comboBoxDifOrder.Name = "comboBoxDifOrder";
            this.comboBoxDifOrder.Size = new System.Drawing.Size(121, 39);
            this.comboBoxDifOrder.TabIndex = 5;
            // 
            // comboBoxSameOrder
            // 
            this.comboBoxSameOrder.BackColor = System.Drawing.Color.White;
            this.comboBoxSameOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSameOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSameOrder.FormattingEnabled = true;
            this.comboBoxSameOrder.Items.AddRange(new object[] {
            "0",
            "+1",
            "+2",
            "+3",
            "+4"});
            this.comboBoxSameOrder.Location = new System.Drawing.Point(15, 193);
            this.comboBoxSameOrder.Name = "comboBoxSameOrder";
            this.comboBoxSameOrder.Size = new System.Drawing.Size(121, 39);
            this.comboBoxSameOrder.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(175, 247);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(48, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // buttonPredictNumberComputer
            // 
            this.buttonPredictNumberComputer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPredictNumberComputer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPredictNumberComputer.ForeColor = System.Drawing.Color.White;
            this.buttonPredictNumberComputer.Location = new System.Drawing.Point(63, 329);
            this.buttonPredictNumberComputer.Name = "buttonPredictNumberComputer";
            this.buttonPredictNumberComputer.Size = new System.Drawing.Size(150, 40);
            this.buttonPredictNumberComputer.TabIndex = 1;
            this.buttonPredictNumberComputer.Text = "Başlat";
            this.buttonPredictNumberComputer.UseVisualStyleBackColor = false;
            this.buttonPredictNumberComputer.Click += new System.EventHandler(this.buttonPredictNumberComputer_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.InitialImage = null;
            this.pictureBoxClose.Location = new System.Drawing.Point(1064, 22);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxRestart
            // 
            this.pictureBoxRestart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestart.Image")));
            this.pictureBoxRestart.InitialImage = null;
            this.pictureBoxRestart.Location = new System.Drawing.Point(1008, 22);
            this.pictureBoxRestart.Name = "pictureBoxRestart";
            this.pictureBoxRestart.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestart.TabIndex = 4;
            this.pictureBoxRestart.TabStop = false;
            this.pictureBoxRestart.Click += new System.EventHandler(this.pictureBoxRestart_Click);
            // 
            // pictureBoxInformation
            // 
            this.pictureBoxInformation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInformation.Image")));
            this.pictureBoxInformation.InitialImage = null;
            this.pictureBoxInformation.Location = new System.Drawing.Point(952, 22);
            this.pictureBoxInformation.Name = "pictureBoxInformation";
            this.pictureBoxInformation.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxInformation.TabIndex = 4;
            this.pictureBoxInformation.TabStop = false;
            this.pictureBoxInformation.Click += new System.EventHandler(this.pictureBoxInformation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(90, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 45);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(617, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 45);
            this.label5.TabIndex = 6;
            // 
            // NumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1131, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxInformation);
            this.Controls.Add(this.pictureBoxRestart);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.groupBoxComputer);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NumberGuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxComputer.ResumeLayout(false);
            this.groupBoxComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelUserNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxComputer;
        private System.Windows.Forms.Button buttonPredictNumberUser;
        private System.Windows.Forms.TextBox textBoxPrediction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDif;
        private System.Windows.Forms.Label labelSame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonPredictNumberComputer;
        private System.Windows.Forms.ComboBox comboBoxDifOrder;
        private System.Windows.Forms.ComboBox comboBoxSameOrder;
        private System.Windows.Forms.ListBox listBoxUserPrediction;
        private System.Windows.Forms.ListBox listBoxComputerPrediction;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxRestart;
        private System.Windows.Forms.PictureBox pictureBoxInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

