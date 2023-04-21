namespace MySQL_Output_Generator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.RichTextBox();
            this.lblQueryStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListView();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboOutputFolder = new System.Windows.Forms.ComboBox();
            this.lnkCreateOutputFolder = new System.Windows.Forms.LinkLabel();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.txtOutputLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySQL Output Generator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConnectionStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRoot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Configuration";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.lblConnectionStatus.Location = new System.Drawing.Point(3, 95);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(1040, 23);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Not Connected";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.btnConnect.Location = new System.Drawing.Point(912, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 38);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(629, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(372, 48);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(149, 26);
            this.txtRoot.TabIndex = 3;
            this.txtRoot.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserId:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(96, 48);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(184, 26);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Query:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.AcceptsTab = true;
            this.codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeTextBox.DetectUrls = false;
            this.codeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(21, 225);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(1046, 124);
            this.codeTextBox.TabIndex = 3;
            this.codeTextBox.Text = "";
            this.codeTextBox.WordWrap = false;
            this.codeTextBox.SelectionChanged += new System.EventHandler(this.codeTextBox_SelectionChanged);
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            this.codeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeTextBox_KeyDown);
            // 
            // lblQueryStatus
            // 
            this.lblQueryStatus.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.lblQueryStatus.Location = new System.Drawing.Point(18, 352);
            this.lblQueryStatus.Name = "lblQueryStatus";
            this.lblQueryStatus.Size = new System.Drawing.Size(1046, 23);
            this.lblQueryStatus.TabIndex = 8;
            this.lblQueryStatus.Text = "Query Status";
            this.lblQueryStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Output:";
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.GridLines = true;
            this.lstOutput.HideSelection = false;
            this.lstOutput.Location = new System.Drawing.Point(18, 433);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(1046, 199);
            this.lstOutput.TabIndex = 10;
            this.lstOutput.UseCompatibleStateImageBehavior = false;
            this.lstOutput.View = System.Windows.Forms.View.Details;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuteQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.btnExecuteQuery.Location = new System.Drawing.Point(930, 389);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(134, 38);
            this.btnExecuteQuery.TabIndex = 8;
            this.btnExecuteQuery.Text = "Execute Query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 664);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Folder:";
            // 
            // cboOutputFolder
            // 
            this.cboOutputFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOutputFolder.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOutputFolder.FormattingEnabled = true;
            this.cboOutputFolder.Location = new System.Drawing.Point(80, 661);
            this.cboOutputFolder.Name = "cboOutputFolder";
            this.cboOutputFolder.Size = new System.Drawing.Size(162, 27);
            this.cboOutputFolder.TabIndex = 12;
            // 
            // lnkCreateOutputFolder
            // 
            this.lnkCreateOutputFolder.AutoSize = true;
            this.lnkCreateOutputFolder.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateOutputFolder.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.lnkCreateOutputFolder.Location = new System.Drawing.Point(248, 664);
            this.lnkCreateOutputFolder.Name = "lnkCreateOutputFolder";
            this.lnkCreateOutputFolder.Size = new System.Drawing.Size(115, 19);
            this.lnkCreateOutputFolder.TabIndex = 13;
            this.lnkCreateOutputFolder.TabStop = true;
            this.lnkCreateOutputFolder.Text = "+ Create New";
            this.lnkCreateOutputFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateOutputFolder_LinkClicked);
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(128)))), ((int)(((byte)(40)))));
            this.btnSaveOutput.Location = new System.Drawing.Point(744, 694);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(134, 38);
            this.btnSaveOutput.TabIndex = 14;
            this.btnSaveOutput.Text = "Save Output";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.btnOutputFolder.Location = new System.Drawing.Point(884, 694);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(177, 38);
            this.btnOutputFolder.TabIndex = 15;
            this.btnOutputFolder.Text = "Open Output Folder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // txtOutputLabel
            // 
            this.txtOutputLabel.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputLabel.Location = new System.Drawing.Point(579, 661);
            this.txtOutputLabel.Name = "txtOutputLabel";
            this.txtOutputLabel.Size = new System.Drawing.Size(485, 27);
            this.txtOutputLabel.TabIndex = 9;
            this.txtOutputLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Label:";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(15, 694);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(545, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "Note: The output label is the label displayed in the bottom of the output.\r\nLeave" +
    " empty if you don\'t want bottom label in output. fig. will be added by deafult";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 747);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOutputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.lnkCreateOutputFolder);
            this.Controls.Add(this.cboOutputFolder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQueryStatus);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Output Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox codeTextBox;
        private System.Windows.Forms.Label lblQueryStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstOutput;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboOutputFolder;
        private System.Windows.Forms.LinkLabel lnkCreateOutputFolder;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TextBox txtOutputLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

