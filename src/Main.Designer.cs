namespace Auth0.LoginTester
{
    partial class Main
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
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.labelLoginDomain = new System.Windows.Forms.Label();
            this.textLoginDomain = new System.Windows.Forms.TextBox();
            this.textLoginClientId = new System.Windows.Forms.TextBox();
            this.labelLoginClientId = new System.Windows.Forms.Label();
            this.textLoginConnection = new System.Windows.Forms.TextBox();
            this.labelLoginConnection = new System.Windows.Forms.Label();
            this.textLoginUsername = new System.Windows.Forms.TextBox();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.textLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textSearchUserId = new System.Windows.Forms.TextBox();
            this.labelSearchUserId = new System.Windows.Forms.Label();
            this.textSearchClientSecret = new System.Windows.Forms.TextBox();
            this.labelSearchClientSecret = new System.Windows.Forms.Label();
            this.textSearchClientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSearchDomain = new System.Windows.Forms.TextBox();
            this.labelSearchDomain = new System.Windows.Forms.Label();
            this.groupLogs = new System.Windows.Forms.GroupBox();
            this.textLogs = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupLogin.SuspendLayout();
            this.groupSearch.SuspendLayout();
            this.groupLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.buttonSignIn);
            this.groupLogin.Controls.Add(this.textLoginPassword);
            this.groupLogin.Controls.Add(this.labelLoginPassword);
            this.groupLogin.Controls.Add(this.textLoginUsername);
            this.groupLogin.Controls.Add(this.labelLoginUsername);
            this.groupLogin.Controls.Add(this.textLoginConnection);
            this.groupLogin.Controls.Add(this.labelLoginConnection);
            this.groupLogin.Controls.Add(this.textLoginClientId);
            this.groupLogin.Controls.Add(this.labelLoginClientId);
            this.groupLogin.Controls.Add(this.textLoginDomain);
            this.groupLogin.Controls.Add(this.labelLoginDomain);
            this.groupLogin.Location = new System.Drawing.Point(12, 12);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(327, 284);
            this.groupLogin.TabIndex = 0;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Login";
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.buttonSearch);
            this.groupSearch.Controls.Add(this.textSearchUserId);
            this.groupSearch.Controls.Add(this.labelSearchDomain);
            this.groupSearch.Controls.Add(this.labelSearchUserId);
            this.groupSearch.Controls.Add(this.textSearchDomain);
            this.groupSearch.Controls.Add(this.textSearchClientSecret);
            this.groupSearch.Controls.Add(this.label3);
            this.groupSearch.Controls.Add(this.labelSearchClientSecret);
            this.groupSearch.Controls.Add(this.textSearchClientId);
            this.groupSearch.Location = new System.Drawing.Point(345, 12);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(336, 284);
            this.groupSearch.TabIndex = 1;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search";
            // 
            // labelLoginDomain
            // 
            this.labelLoginDomain.AutoSize = true;
            this.labelLoginDomain.Location = new System.Drawing.Point(7, 20);
            this.labelLoginDomain.Name = "labelLoginDomain";
            this.labelLoginDomain.Size = new System.Drawing.Size(43, 13);
            this.labelLoginDomain.TabIndex = 0;
            this.labelLoginDomain.Text = "Domain";
            // 
            // textLoginDomain
            // 
            this.textLoginDomain.Location = new System.Drawing.Point(10, 37);
            this.textLoginDomain.Name = "textLoginDomain";
            this.textLoginDomain.Size = new System.Drawing.Size(306, 20);
            this.textLoginDomain.TabIndex = 1;
            this.textLoginDomain.Text = "YOUR_ACCOUNT.auth0.com";
            // 
            // textLoginClientId
            // 
            this.textLoginClientId.Location = new System.Drawing.Point(10, 82);
            this.textLoginClientId.Name = "textLoginClientId";
            this.textLoginClientId.Size = new System.Drawing.Size(306, 20);
            this.textLoginClientId.TabIndex = 3;
            // 
            // labelLoginClientId
            // 
            this.labelLoginClientId.AutoSize = true;
            this.labelLoginClientId.Location = new System.Drawing.Point(7, 65);
            this.labelLoginClientId.Name = "labelLoginClientId";
            this.labelLoginClientId.Size = new System.Drawing.Size(45, 13);
            this.labelLoginClientId.TabIndex = 2;
            this.labelLoginClientId.Text = "Client Id";
            // 
            // textLoginConnection
            // 
            this.textLoginConnection.Location = new System.Drawing.Point(10, 128);
            this.textLoginConnection.Name = "textLoginConnection";
            this.textLoginConnection.Size = new System.Drawing.Size(306, 20);
            this.textLoginConnection.TabIndex = 5;
            // 
            // labelLoginConnection
            // 
            this.labelLoginConnection.AutoSize = true;
            this.labelLoginConnection.Location = new System.Drawing.Point(7, 111);
            this.labelLoginConnection.Name = "labelLoginConnection";
            this.labelLoginConnection.Size = new System.Drawing.Size(61, 13);
            this.labelLoginConnection.TabIndex = 4;
            this.labelLoginConnection.Text = "Connection";
            // 
            // textLoginUsername
            // 
            this.textLoginUsername.Location = new System.Drawing.Point(10, 174);
            this.textLoginUsername.Name = "textLoginUsername";
            this.textLoginUsername.Size = new System.Drawing.Size(306, 20);
            this.textLoginUsername.TabIndex = 7;
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Location = new System.Drawing.Point(7, 157);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(55, 13);
            this.labelLoginUsername.TabIndex = 6;
            this.labelLoginUsername.Text = "Username";
            // 
            // textLoginPassword
            // 
            this.textLoginPassword.Location = new System.Drawing.Point(10, 220);
            this.textLoginPassword.Name = "textLoginPassword";
            this.textLoginPassword.Size = new System.Drawing.Size(306, 20);
            this.textLoginPassword.TabIndex = 9;
            this.textLoginPassword.UseSystemPasswordChar = true;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Location = new System.Drawing.Point(7, 203);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(53, 13);
            this.labelLoginPassword.TabIndex = 8;
            this.labelLoginPassword.Text = "Password";
            // 
            // textSearchUserId
            // 
            this.textSearchUserId.Location = new System.Drawing.Point(19, 174);
            this.textSearchUserId.Name = "textSearchUserId";
            this.textSearchUserId.Size = new System.Drawing.Size(306, 20);
            this.textSearchUserId.TabIndex = 17;
            // 
            // labelSearchUserId
            // 
            this.labelSearchUserId.AutoSize = true;
            this.labelSearchUserId.Location = new System.Drawing.Point(16, 157);
            this.labelSearchUserId.Name = "labelSearchUserId";
            this.labelSearchUserId.Size = new System.Drawing.Size(41, 13);
            this.labelSearchUserId.TabIndex = 16;
            this.labelSearchUserId.Text = "User Id";
            // 
            // textSearchClientSecret
            // 
            this.textSearchClientSecret.Location = new System.Drawing.Point(19, 128);
            this.textSearchClientSecret.Name = "textSearchClientSecret";
            this.textSearchClientSecret.Size = new System.Drawing.Size(306, 20);
            this.textSearchClientSecret.TabIndex = 15;
            // 
            // labelSearchClientSecret
            // 
            this.labelSearchClientSecret.AutoSize = true;
            this.labelSearchClientSecret.Location = new System.Drawing.Point(16, 111);
            this.labelSearchClientSecret.Name = "labelSearchClientSecret";
            this.labelSearchClientSecret.Size = new System.Drawing.Size(67, 13);
            this.labelSearchClientSecret.TabIndex = 14;
            this.labelSearchClientSecret.Text = "Client Secret";
            // 
            // textSearchClientId
            // 
            this.textSearchClientId.Location = new System.Drawing.Point(19, 82);
            this.textSearchClientId.Name = "textSearchClientId";
            this.textSearchClientId.Size = new System.Drawing.Size(306, 20);
            this.textSearchClientId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Client Id";
            // 
            // textSearchDomain
            // 
            this.textSearchDomain.Location = new System.Drawing.Point(19, 37);
            this.textSearchDomain.Name = "textSearchDomain";
            this.textSearchDomain.Size = new System.Drawing.Size(306, 20);
            this.textSearchDomain.TabIndex = 11;
            this.textSearchDomain.Text = "YOUR_ACCOUNT.auth0.com";
            // 
            // labelSearchDomain
            // 
            this.labelSearchDomain.AutoSize = true;
            this.labelSearchDomain.Location = new System.Drawing.Point(16, 20);
            this.labelSearchDomain.Name = "labelSearchDomain";
            this.labelSearchDomain.Size = new System.Drawing.Size(43, 13);
            this.labelSearchDomain.TabIndex = 10;
            this.labelSearchDomain.Text = "Domain";
            // 
            // groupLogs
            // 
            this.groupLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLogs.Controls.Add(this.textLogs);
            this.groupLogs.Location = new System.Drawing.Point(12, 302);
            this.groupLogs.Name = "groupLogs";
            this.groupLogs.Size = new System.Drawing.Size(669, 329);
            this.groupLogs.TabIndex = 2;
            this.groupLogs.TabStop = false;
            this.groupLogs.Text = "Logs";
            // 
            // textLogs
            // 
            this.textLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLogs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogs.Location = new System.Drawing.Point(3, 16);
            this.textLogs.Multiline = true;
            this.textLogs.Name = "textLogs";
            this.textLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLogs.Size = new System.Drawing.Size(663, 310);
            this.textLogs.TabIndex = 0;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(241, 246);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 10;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.OnSignIn);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(250, 246);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.OnSearch);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 646);
            this.Controls.Add(this.groupLogs);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.groupLogin);
            this.Name = "Main";
            this.Text = "Auth0 - Login and Search Tester";
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.groupLogs.ResumeLayout(false);
            this.groupLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLogin;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.TextBox textLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox textLoginUsername;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.TextBox textLoginConnection;
        private System.Windows.Forms.Label labelLoginConnection;
        private System.Windows.Forms.TextBox textLoginClientId;
        private System.Windows.Forms.Label labelLoginClientId;
        private System.Windows.Forms.TextBox textLoginDomain;
        private System.Windows.Forms.Label labelLoginDomain;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearchUserId;
        private System.Windows.Forms.Label labelSearchDomain;
        private System.Windows.Forms.Label labelSearchUserId;
        private System.Windows.Forms.TextBox textSearchDomain;
        private System.Windows.Forms.TextBox textSearchClientSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSearchClientSecret;
        private System.Windows.Forms.TextBox textSearchClientId;
        private System.Windows.Forms.GroupBox groupLogs;
        private System.Windows.Forms.TextBox textLogs;
    }
}

