namespace IPsec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UKR = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.Logfail = new System.Windows.Forms.Label();
            this.PassFail = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.RUS = new System.Windows.Forms.Button();
            this.USA = new System.Windows.Forms.Button();
            this.EUR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIPlogin = new System.Windows.Forms.Label();
            this.labelIPpassword = new System.Windows.Forms.Label();
            this.textBoxIPlogin = new System.Windows.Forms.TextBox();
            this.textBoxIPpassword = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnUpHist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UKR
            // 
            this.UKR.BackColor = System.Drawing.Color.Gainsboro;
            this.UKR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.UKR.Location = new System.Drawing.Point(10, 232);
            this.UKR.Name = "UKR";
            this.UKR.Size = new System.Drawing.Size(124, 37);
            this.UKR.TabIndex = 6;
            this.UKR.Text = "Ukraine";
            this.UKR.UseVisualStyleBackColor = true;
            this.UKR.Click += new System.EventHandler(this.UKR_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordtextBox.Location = new System.Drawing.Point(78, 44);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(176, 20);
            this.PasswordtextBox.TabIndex = 2;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // LogintextBox
            // 
            this.LogintextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogintextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogintextBox.Location = new System.Drawing.Point(78, 12);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(176, 20);
            this.LogintextBox.TabIndex = 1;
            // 
            // IPtextBox
            // 
            this.IPtextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.IPtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPtextBox.ForeColor = System.Drawing.Color.Black;
            this.IPtextBox.Location = new System.Drawing.Point(78, 117);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.ReadOnly = true;
            this.IPtextBox.Size = new System.Drawing.Size(176, 26);
            this.IPtextBox.TabIndex = 3;
            this.IPtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(10, 14);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 15);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(10, 46);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 15);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelIP.Location = new System.Drawing.Point(10, 123);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(19, 15);
            this.labelIP.TabIndex = 6;
            this.labelIP.Text = "IP";
            // 
            // Logfail
            // 
            this.Logfail.AutoSize = true;
            this.Logfail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logfail.ForeColor = System.Drawing.Color.Red;
            this.Logfail.Location = new System.Drawing.Point(260, 16);
            this.Logfail.Name = "Logfail";
            this.Logfail.Size = new System.Drawing.Size(14, 16);
            this.Logfail.TabIndex = 7;
            this.Logfail.Text = "*";
            this.Logfail.Visible = false;
            // 
            // PassFail
            // 
            this.PassFail.AutoSize = true;
            this.PassFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PassFail.ForeColor = System.Drawing.Color.Red;
            this.PassFail.Location = new System.Drawing.Point(260, 48);
            this.PassFail.Name = "PassFail";
            this.PassFail.Size = new System.Drawing.Size(14, 16);
            this.PassFail.TabIndex = 8;
            this.PassFail.Text = "*";
            this.PassFail.Visible = false;
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelConnect.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelConnect.Location = new System.Drawing.Point(75, 79);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(0, 19);
            this.labelConnect.TabIndex = 9;
            this.labelConnect.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(10, 82);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(37, 15);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "User:";
            this.labelUser.Visible = false;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelHistory.Location = new System.Drawing.Point(114, 381);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(79, 15);
            this.labelHistory.TabIndex = 13;
            this.labelHistory.Text = "ShortHistory";
            this.labelHistory.Visible = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(199, 377);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonHistory.TabIndex = 10;
            this.buttonHistory.Text = "Show";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Visible = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // RUS
            // 
            this.RUS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.RUS.Location = new System.Drawing.Point(150, 232);
            this.RUS.Name = "RUS";
            this.RUS.Size = new System.Drawing.Size(122, 36);
            this.RUS.TabIndex = 7;
            this.RUS.Text = "Russia";
            this.RUS.UseVisualStyleBackColor = true;
            this.RUS.Click += new System.EventHandler(this.RUS_Click);
            // 
            // USA
            // 
            this.USA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.USA.Location = new System.Drawing.Point(10, 275);
            this.USA.Name = "USA";
            this.USA.Size = new System.Drawing.Size(122, 36);
            this.USA.TabIndex = 8;
            this.USA.Text = "USA";
            this.USA.UseVisualStyleBackColor = true;
            this.USA.Click += new System.EventHandler(this.USA_Click);
            // 
            // EUR
            // 
            this.EUR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.EUR.Location = new System.Drawing.Point(150, 275);
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(122, 36);
            this.EUR.TabIndex = 9;
            this.EUR.Text = "Europe";
            this.EUR.UseVisualStyleBackColor = true;
            this.EUR.Click += new System.EventHandler(this.EUR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Show IP address from region:";
            // 
            // labelIPlogin
            // 
            this.labelIPlogin.AutoSize = true;
            this.labelIPlogin.ForeColor = System.Drawing.Color.Blue;
            this.labelIPlogin.Location = new System.Drawing.Point(78, 153);
            this.labelIPlogin.Name = "labelIPlogin";
            this.labelIPlogin.Size = new System.Drawing.Size(46, 13);
            this.labelIPlogin.TabIndex = 19;
            this.labelIPlogin.Text = "IP Login";
            this.labelIPlogin.Visible = false;
            // 
            // labelIPpassword
            // 
            this.labelIPpassword.AutoSize = true;
            this.labelIPpassword.ForeColor = System.Drawing.Color.Blue;
            this.labelIPpassword.Location = new System.Drawing.Point(78, 182);
            this.labelIPpassword.Name = "labelIPpassword";
            this.labelIPpassword.Size = new System.Drawing.Size(66, 13);
            this.labelIPpassword.TabIndex = 20;
            this.labelIPpassword.Text = "IP Password";
            this.labelIPpassword.Visible = false;
            // 
            // textBoxIPlogin
            // 
            this.textBoxIPlogin.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIPlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIPlogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIPlogin.Location = new System.Drawing.Point(146, 150);
            this.textBoxIPlogin.Name = "textBoxIPlogin";
            this.textBoxIPlogin.ReadOnly = true;
            this.textBoxIPlogin.Size = new System.Drawing.Size(108, 22);
            this.textBoxIPlogin.TabIndex = 4;
            this.textBoxIPlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIPlogin.Visible = false;
            // 
            // textBoxIPpassword
            // 
            this.textBoxIPpassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIPpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIPpassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIPpassword.Location = new System.Drawing.Point(146, 179);
            this.textBoxIPpassword.Name = "textBoxIPpassword";
            this.textBoxIPpassword.ReadOnly = true;
            this.textBoxIPpassword.Size = new System.Drawing.Size(108, 22);
            this.textBoxIPpassword.TabIndex = 5;
            this.textBoxIPpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIPpassword.Visible = false;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Image = global::IPsec.Properties.Resources.copy;
            this.buttonCopy.Location = new System.Drawing.Point(254, 117);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(26, 26);
            this.buttonCopy.TabIndex = 23;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Visible = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(0, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "v1.0 beta";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Последние изменения";
            // 
            // BtnUpHist
            // 
            this.BtnUpHist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpHist.Location = new System.Drawing.Point(10, 329);
            this.BtnUpHist.Name = "BtnUpHist";
            this.BtnUpHist.Size = new System.Drawing.Size(262, 42);
            this.BtnUpHist.TabIndex = 25;
            this.BtnUpHist.Text = "Upload History";
            this.BtnUpHist.UseVisualStyleBackColor = true;
            this.BtnUpHist.Visible = false;
            this.BtnUpHist.Click += new System.EventHandler(this.BtnUpHist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.BtnUpHist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxIPpassword);
            this.Controls.Add(this.textBoxIPlogin);
            this.Controls.Add(this.labelIPpassword);
            this.Controls.Add(this.labelIPlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EUR);
            this.Controls.Add(this.USA);
            this.Controls.Add(this.RUS);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.PassFail);
            this.Controls.Add(this.Logfail);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.IPtextBox);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UKR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Form1";
            this.Text = "IPsec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UKR;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label Logfail;
        private System.Windows.Forms.Label PassFail;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button RUS;
        private System.Windows.Forms.Button USA;
        private System.Windows.Forms.Button EUR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIPlogin;
        private System.Windows.Forms.Label labelIPpassword;
        private System.Windows.Forms.TextBox textBoxIPlogin;
        private System.Windows.Forms.TextBox textBoxIPpassword;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnUpHist;
    }
}

