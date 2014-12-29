namespace SI_KHS
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginidbox = new System.Windows.Forms.TextBox();
            this.loginpassbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "SI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "KHS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // previl
            // 
            this.previl.FormattingEnabled = true;
            this.previl.Items.AddRange(new object[] {
            "Admin",
            "Mahasiswa",
            "Dosen"});
            this.previl.Location = new System.Drawing.Point(115, 122);
            this.previl.Name = "previl";
            this.previl.Size = new System.Drawing.Size(141, 21);
            this.previl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "PASS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginidbox
            // 
            this.loginidbox.Location = new System.Drawing.Point(159, 149);
            this.loginidbox.Name = "loginidbox";
            this.loginidbox.Size = new System.Drawing.Size(97, 20);
            this.loginidbox.TabIndex = 6;
            // 
            // loginpassbox
            // 
            this.loginpassbox.Location = new System.Drawing.Point(159, 175);
            this.loginpassbox.Name = "loginpassbox";
            this.loginpassbox.PasswordChar = '●';
            this.loginpassbox.Size = new System.Drawing.Size(97, 20);
            this.loginpassbox.TabIndex = 7;
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(132, 201);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(104, 33);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "ENTER";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(378, 243);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.loginpassbox);
            this.Controls.Add(this.loginidbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.previl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox previl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loginidbox;
        private System.Windows.Forms.TextBox loginpassbox;
        private System.Windows.Forms.Button loginbutton;
    }
}

