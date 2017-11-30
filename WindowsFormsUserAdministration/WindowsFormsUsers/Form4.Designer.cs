namespace WindowsFormsUsers
{
    partial class FormAddUser
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
            this.lblEditTitle2 = new System.Windows.Forms.Label();
            this.lblEditUserName2 = new System.Windows.Forms.Label();
            this.lblEditUserID2 = new System.Windows.Forms.Label();
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.lblEditName2 = new System.Windows.Forms.Label();
            this.lblEditLastName2 = new System.Windows.Forms.Label();
            this.lblEditPassword2 = new System.Windows.Forms.Label();
            this.inptEditUserName = new System.Windows.Forms.TextBox();
            this.inptEditName2 = new System.Windows.Forms.TextBox();
            this.inptEditLastName2 = new System.Windows.Forms.TextBox();
            this.inptEditPassword2 = new System.Windows.Forms.TextBox();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditTitle2
            // 
            this.lblEditTitle2.AutoSize = true;
            this.lblEditTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle2.Location = new System.Drawing.Point(222, 26);
            this.lblEditTitle2.Name = "lblEditTitle2";
            this.lblEditTitle2.Size = new System.Drawing.Size(137, 24);
            this.lblEditTitle2.TabIndex = 0;
            this.lblEditTitle2.Text = "Dodaj korisnika";
            // 
            // lblEditUserName2
            // 
            this.lblEditUserName2.AutoSize = true;
            this.lblEditUserName2.Location = new System.Drawing.Point(256, 50);
            this.lblEditUserName2.Name = "lblEditUserName2";
            this.lblEditUserName2.Size = new System.Drawing.Size(57, 13);
            this.lblEditUserName2.TabIndex = 1;
            this.lblEditUserName2.Text = "UserName";
            // 
            // lblEditUserID2
            // 
            this.lblEditUserID2.AutoSize = true;
            this.lblEditUserID2.Location = new System.Drawing.Point(262, 67);
            this.lblEditUserID2.Name = "lblEditUserID2";
            this.lblEditUserID2.Size = new System.Drawing.Size(40, 13);
            this.lblEditUserID2.TabIndex = 2;
            this.lblEditUserID2.Text = "UserID";
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.Location = new System.Drawing.Point(34, 132);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(75, 13);
            this.lblEditUserName.TabIndex = 3;
            this.lblEditUserName.Text = "Korisničko ime";
            // 
            // lblEditName2
            // 
            this.lblEditName2.AutoSize = true;
            this.lblEditName2.Location = new System.Drawing.Point(34, 163);
            this.lblEditName2.Name = "lblEditName2";
            this.lblEditName2.Size = new System.Drawing.Size(24, 13);
            this.lblEditName2.TabIndex = 4;
            this.lblEditName2.Text = "Ime";
            // 
            // lblEditLastName2
            // 
            this.lblEditLastName2.AutoSize = true;
            this.lblEditLastName2.Location = new System.Drawing.Point(34, 189);
            this.lblEditLastName2.Name = "lblEditLastName2";
            this.lblEditLastName2.Size = new System.Drawing.Size(44, 13);
            this.lblEditLastName2.TabIndex = 5;
            this.lblEditLastName2.Text = "Prezime";
            // 
            // lblEditPassword2
            // 
            this.lblEditPassword2.AutoSize = true;
            this.lblEditPassword2.Location = new System.Drawing.Point(34, 219);
            this.lblEditPassword2.Name = "lblEditPassword2";
            this.lblEditPassword2.Size = new System.Drawing.Size(44, 13);
            this.lblEditPassword2.TabIndex = 6;
            this.lblEditPassword2.Text = "Lozinka";
            // 
            // inptEditUserName
            // 
            this.inptEditUserName.Location = new System.Drawing.Point(131, 132);
            this.inptEditUserName.Name = "inptEditUserName";
            this.inptEditUserName.Size = new System.Drawing.Size(333, 20);
            this.inptEditUserName.TabIndex = 7;
            // 
            // inptEditName2
            // 
            this.inptEditName2.Location = new System.Drawing.Point(131, 163);
            this.inptEditName2.Name = "inptEditName2";
            this.inptEditName2.Size = new System.Drawing.Size(333, 20);
            this.inptEditName2.TabIndex = 8;
            // 
            // inptEditLastName2
            // 
            this.inptEditLastName2.Location = new System.Drawing.Point(131, 190);
            this.inptEditLastName2.Name = "inptEditLastName2";
            this.inptEditLastName2.Size = new System.Drawing.Size(333, 20);
            this.inptEditLastName2.TabIndex = 9;
            // 
            // inptEditPassword2
            // 
            this.inptEditPassword2.Location = new System.Drawing.Point(131, 219);
            this.inptEditPassword2.Name = "inptEditPassword2";
            this.inptEditPassword2.Size = new System.Drawing.Size(333, 20);
            this.inptEditPassword2.TabIndex = 10;
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(131, 292);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(120, 30);
            this.btnClose2.TabIndex = 11;
            this.btnClose2.Text = "ZATVORI";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(344, 292);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(120, 30);
            this.btnSave2.TabIndex = 12;
            this.btnSave2.Text = "SPREMI";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 345);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.inptEditPassword2);
            this.Controls.Add(this.inptEditLastName2);
            this.Controls.Add(this.inptEditName2);
            this.Controls.Add(this.inptEditUserName);
            this.Controls.Add(this.lblEditPassword2);
            this.Controls.Add(this.lblEditLastName2);
            this.Controls.Add(this.lblEditName2);
            this.Controls.Add(this.lblEditUserName);
            this.Controls.Add(this.lblEditUserID2);
            this.Controls.Add(this.lblEditUserName2);
            this.Controls.Add(this.lblEditTitle2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditTitle2;
        private System.Windows.Forms.Label lblEditUserName2;
        private System.Windows.Forms.Label lblEditUserID2;
        private System.Windows.Forms.Label lblEditUserName;
        private System.Windows.Forms.Label lblEditName2;
        private System.Windows.Forms.Label lblEditLastName2;
        private System.Windows.Forms.Label lblEditPassword2;
        private System.Windows.Forms.TextBox inptEditUserName;
        private System.Windows.Forms.TextBox inptEditName2;
        private System.Windows.Forms.TextBox inptEditLastName2;
        private System.Windows.Forms.TextBox inptEditPassword2;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnSave2;
    }
}