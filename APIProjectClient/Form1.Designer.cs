namespace APIProjectClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbRequestUrl = new System.Windows.Forms.TextBox();
            this.txbJson = new System.Windows.Forms.TextBox();
            this.lstbResponse = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(51, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request URL";
            // 
            // txbRequestUrl
            // 
            this.txbRequestUrl.Location = new System.Drawing.Point(574, 486);
            this.txbRequestUrl.Name = "txbRequestUrl";
            this.txbRequestUrl.Size = new System.Drawing.Size(447, 26);
            this.txbRequestUrl.TabIndex = 1;
            // 
            // txbJson
            // 
            this.txbJson.Location = new System.Drawing.Point(215, 552);
            this.txbJson.Multiline = true;
            this.txbJson.Name = "txbJson";
            this.txbJson.Size = new System.Drawing.Size(932, 162);
            this.txbJson.TabIndex = 2;
            // 
            // lstbResponse
            // 
            this.lstbResponse.FormattingEnabled = true;
            this.lstbResponse.HorizontalScrollbar = true;
            this.lstbResponse.ItemHeight = 20;
            this.lstbResponse.Location = new System.Drawing.Point(56, 753);
            this.lstbResponse.Name = "lstbResponse";
            this.lstbResponse.Size = new System.Drawing.Size(1091, 264);
            this.lstbResponse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(419, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ontario School API";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(865, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "301028039 Kyungjin Jeong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(865, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "301023639 Yeseul Jang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(51, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "JSON Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(51, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Response";
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExecute.Location = new System.Drawing.Point(1040, 479);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(107, 41);
            this.btnExecute.TabIndex = 9;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_ClickAsync);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.comboBoxMethod.Location = new System.Drawing.Point(428, 486);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(129, 28);
            this.comboBoxMethod.TabIndex = 13;
            this.comboBoxMethod.Text = "==Method==";
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Items.AddRange(new object[] {
            "PublicSchool",
            "PrivateSchool",
            "PrivateSchoolRate",
            "EnrolmentByGender",
            "EnrolmentBySchool"});
            this.comboBoxTarget.Location = new System.Drawing.Point(215, 485);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(207, 28);
            this.comboBoxTarget.TabIndex = 14;
            this.comboBoxTarget.Text = "==Target==";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(120, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 77);
            this.label7.TabIndex = 15;
            this.label7.Text = "PublicSchool\r\n    - PublicSchool\r\n    - PublicSchool/{id}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(336, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 77);
            this.label8.TabIndex = 16;
            this.label8.Text = "PrivateSchool\r\n    - PrivateSchool\r\n    - PrivateSchool/{id}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(564, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 77);
            this.label9.TabIndex = 17;
            this.label9.Text = "EnrolmentByGender\r\n    - EnrolmentByGender\r\n    - EnrolmentByGender/{id}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(842, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 77);
            this.label10.TabIndex = 18;
            this.label10.Text = "EnrolmentBySchool\r\n    - EnrolmentBySchool\r\n    - EnrolmentBySchool/{id}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(120, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(677, 102);
            this.label11.TabIndex = 19;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 1059);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTarget);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbResponse);
            this.Controls.Add(this.txbJson);
            this.Controls.Add(this.txbRequestUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consume RESTful API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRequestUrl;
        private System.Windows.Forms.TextBox txbJson;
        private System.Windows.Forms.ListBox lstbResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

