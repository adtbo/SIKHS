namespace SI_KHS
{
    partial class dsnform
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
            this.niplabel = new System.Windows.Forms.Label();
            this.namalabel = new System.Windows.Forms.Label();
            this.kelascom = new System.Windows.Forms.ComboBox();
            this.tabelnilailist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nrpmhslabel = new System.Windows.Forms.Label();
            this.namamhslabel = new System.Windows.Forms.Label();
            this.nilaicom = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comtahun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelnilailist)).BeginInit();
            this.SuspendLayout();
            // 
            // niplabel
            // 
            this.niplabel.AutoSize = true;
            this.niplabel.Location = new System.Drawing.Point(12, 9);
            this.niplabel.Name = "niplabel";
            this.niplabel.Size = new System.Drawing.Size(25, 13);
            this.niplabel.TabIndex = 0;
            this.niplabel.Text = "NIP";
            // 
            // namalabel
            // 
            this.namalabel.AutoSize = true;
            this.namalabel.Location = new System.Drawing.Point(196, 9);
            this.namalabel.Name = "namalabel";
            this.namalabel.Size = new System.Drawing.Size(10, 13);
            this.namalabel.TabIndex = 1;
            this.namalabel.Text = "-";
            // 
            // kelascom
            // 
            this.kelascom.FormattingEnabled = true;
            this.kelascom.Location = new System.Drawing.Point(97, 36);
            this.kelascom.Name = "kelascom";
            this.kelascom.Size = new System.Drawing.Size(240, 21);
            this.kelascom.TabIndex = 3;
            this.kelascom.Text = "==Pilih Kelas==";
            this.kelascom.SelectedIndexChanged += new System.EventHandler(this.kelascom_SelectedIndexChanged);
            // 
            // tabelnilailist
            // 
            this.tabelnilailist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelnilailist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrp,
            this.namamhs,
            this.nilai});
            this.tabelnilailist.Location = new System.Drawing.Point(12, 63);
            this.tabelnilailist.Name = "tabelnilailist";
            this.tabelnilailist.Size = new System.Drawing.Size(349, 207);
            this.tabelnilailist.TabIndex = 4;
            this.tabelnilailist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelnilailist_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NRP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai";
            // 
            // nrpmhslabel
            // 
            this.nrpmhslabel.AutoSize = true;
            this.nrpmhslabel.Location = new System.Drawing.Point(403, 75);
            this.nrpmhslabel.Name = "nrpmhslabel";
            this.nrpmhslabel.Size = new System.Drawing.Size(10, 13);
            this.nrpmhslabel.TabIndex = 9;
            this.nrpmhslabel.Text = "-";
            // 
            // namamhslabel
            // 
            this.namamhslabel.AutoSize = true;
            this.namamhslabel.Location = new System.Drawing.Point(403, 110);
            this.namamhslabel.Name = "namamhslabel";
            this.namamhslabel.Size = new System.Drawing.Size(10, 13);
            this.namamhslabel.TabIndex = 10;
            this.namamhslabel.Text = "-";
            // 
            // nilaicom
            // 
            this.nilaicom.FormattingEnabled = true;
            this.nilaicom.Items.AddRange(new object[] {
            "A",
            "AB",
            "B",
            "BC",
            "C",
            "D",
            "E"});
            this.nilaicom.Location = new System.Drawing.Point(406, 140);
            this.nilaicom.Name = "nilaicom";
            this.nilaicom.Size = new System.Drawing.Size(51, 21);
            this.nilaicom.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Masukkan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nrp
            // 
            this.nrp.HeaderText = "NRP";
            this.nrp.Name = "nrp";
            // 
            // namamhs
            // 
            this.namamhs.HeaderText = "NAMA";
            this.namamhs.Name = "namamhs";
            // 
            // nilai
            // 
            this.nilai.HeaderText = "NILAI";
            this.nilai.Name = "nilai";
            // 
            // comtahun
            // 
            this.comtahun.FormattingEnabled = true;
            this.comtahun.Location = new System.Drawing.Point(12, 36);
            this.comtahun.Name = "comtahun";
            this.comtahun.Size = new System.Drawing.Size(79, 21);
            this.comtahun.TabIndex = 14;
            this.comtahun.Tag = "";
            this.comtahun.Text = "Tahun";
            this.comtahun.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dsnform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 282);
            this.Controls.Add(this.comtahun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nilaicom);
            this.Controls.Add(this.namamhslabel);
            this.Controls.Add(this.nrpmhslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabelnilailist);
            this.Controls.Add(this.kelascom);
            this.Controls.Add(this.namalabel);
            this.Controls.Add(this.niplabel);
            this.Name = "dsnform";
            this.Text = "Dosen";
            ((System.ComponentModel.ISupportInitialize)(this.tabelnilailist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label niplabel;
        private System.Windows.Forms.Label namalabel;
        private System.Windows.Forms.ComboBox kelascom;
        private System.Windows.Forms.DataGridView tabelnilailist;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nrpmhslabel;
        private System.Windows.Forms.Label namamhslabel;
        private System.Windows.Forms.ComboBox nilaicom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comtahun;
    }
}