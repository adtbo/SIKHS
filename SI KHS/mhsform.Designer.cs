namespace SI_KHS
{
    partial class mhsform
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KHS = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combosem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listkhs = new System.Windows.Forms.DataGridView();
            this.namamk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterambil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KELAS = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboidkls = new System.Windows.Forms.ComboBox();
            this.ambilbutton = new System.Windows.Forms.Button();
            this.jumlahmhslabel = new System.Windows.Forms.Label();
            this.Namadsnlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combokls = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.KHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listkhs)).BeginInit();
            this.KELAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "5112100184";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KHS);
            this.tabControl1.Controls.Add(this.KELAS);
            this.tabControl1.Location = new System.Drawing.Point(1, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 261);
            this.tabControl1.TabIndex = 4;
            // 
            // KHS
            // 
            this.KHS.Controls.Add(this.label7);
            this.KHS.Controls.Add(this.label3);
            this.KHS.Controls.Add(this.label6);
            this.KHS.Controls.Add(this.combosem);
            this.KHS.Controls.Add(this.label5);
            this.KHS.Controls.Add(this.label4);
            this.KHS.Controls.Add(this.listkhs);
            this.KHS.Location = new System.Drawing.Point(4, 22);
            this.KHS.Name = "KHS";
            this.KHS.Padding = new System.Windows.Forms.Padding(3);
            this.KHS.Size = new System.Drawing.Size(526, 235);
            this.KHS.TabIndex = 0;
            this.KHS.Text = "KHS";
            this.KHS.UseVisualStyleBackColor = true;
            this.KHS.Click += new System.EventHandler(this.KHS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semester";
            // 
            // combosem
            // 
            this.combosem.FormattingEnabled = true;
            this.combosem.Location = new System.Drawing.Point(64, 181);
            this.combosem.Name = "combosem";
            this.combosem.Size = new System.Drawing.Size(45, 21);
            this.combosem.TabIndex = 4;
            this.combosem.SelectedIndexChanged += new System.EventHandler(this.combosem_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "IPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IPK";
            // 
            // listkhs
            // 
            this.listkhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listkhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namamk,
            this.semesterambil,
            this.nilai});
            this.listkhs.Location = new System.Drawing.Point(64, 3);
            this.listkhs.Name = "listkhs";
            this.listkhs.Size = new System.Drawing.Size(394, 164);
            this.listkhs.TabIndex = 0;
            // 
            // namamk
            // 
            this.namamk.HeaderText = "Matakuliah";
            this.namamk.Name = "namamk";
            this.namamk.Width = 150;
            // 
            // semesterambil
            // 
            this.semesterambil.HeaderText = "Semester";
            this.semesterambil.Name = "semesterambil";
            // 
            // nilai
            // 
            this.nilai.HeaderText = "Nilai";
            this.nilai.Name = "nilai";
            // 
            // KELAS
            // 
            this.KELAS.Controls.Add(this.label11);
            this.KELAS.Controls.Add(this.label10);
            this.KELAS.Controls.Add(this.comboidkls);
            this.KELAS.Controls.Add(this.ambilbutton);
            this.KELAS.Controls.Add(this.jumlahmhslabel);
            this.KELAS.Controls.Add(this.Namadsnlabel);
            this.KELAS.Controls.Add(this.label9);
            this.KELAS.Controls.Add(this.label8);
            this.KELAS.Controls.Add(this.combokls);
            this.KELAS.Location = new System.Drawing.Point(4, 22);
            this.KELAS.Name = "KELAS";
            this.KELAS.Padding = new System.Windows.Forms.Padding(3);
            this.KELAS.Size = new System.Drawing.Size(526, 235);
            this.KELAS.TabIndex = 1;
            this.KELAS.Text = "KELAS";
            this.KELAS.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Matakuliah";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "KELAS";
            // 
            // comboidkls
            // 
            this.comboidkls.FormattingEnabled = true;
            this.comboidkls.Location = new System.Drawing.Point(410, 28);
            this.comboidkls.Name = "comboidkls";
            this.comboidkls.Size = new System.Drawing.Size(108, 21);
            this.comboidkls.TabIndex = 6;
            this.comboidkls.SelectedIndexChanged += new System.EventHandler(this.comboidkls_SelectedIndexChanged);
            // 
            // ambilbutton
            // 
            this.ambilbutton.Location = new System.Drawing.Point(203, 126);
            this.ambilbutton.Name = "ambilbutton";
            this.ambilbutton.Size = new System.Drawing.Size(103, 32);
            this.ambilbutton.TabIndex = 5;
            this.ambilbutton.Text = "Ambil";
            this.ambilbutton.UseVisualStyleBackColor = true;
            this.ambilbutton.Click += new System.EventHandler(this.ambilbutton_Click);
            // 
            // jumlahmhslabel
            // 
            this.jumlahmhslabel.AutoSize = true;
            this.jumlahmhslabel.Location = new System.Drawing.Point(78, 78);
            this.jumlahmhslabel.Name = "jumlahmhslabel";
            this.jumlahmhslabel.Size = new System.Drawing.Size(10, 13);
            this.jumlahmhslabel.TabIndex = 4;
            this.jumlahmhslabel.Text = "-";
            // 
            // Namadsnlabel
            // 
            this.Namadsnlabel.AutoSize = true;
            this.Namadsnlabel.Location = new System.Drawing.Point(78, 54);
            this.Namadsnlabel.Name = "Namadsnlabel";
            this.Namadsnlabel.Size = new System.Drawing.Size(10, 13);
            this.Namadsnlabel.TabIndex = 3;
            this.Namadsnlabel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kapasitas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dosen";
            // 
            // combokls
            // 
            this.combokls.FormattingEnabled = true;
            this.combokls.Location = new System.Drawing.Point(10, 28);
            this.combokls.Name = "combokls";
            this.combokls.Size = new System.Drawing.Size(394, 21);
            this.combokls.TabIndex = 0;
            this.combokls.SelectedIndexChanged += new System.EventHandler(this.combokls_SelectedIndexChanged);
            // 
            // mhsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 282);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mhsform";
            this.Text = "mhsform";
            this.tabControl1.ResumeLayout(false);
            this.KHS.ResumeLayout(false);
            this.KHS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listkhs)).EndInit();
            this.KELAS.ResumeLayout(false);
            this.KELAS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KHS;
        private System.Windows.Forms.DataGridView listkhs;
        private System.Windows.Forms.TabPage KELAS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combosem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamk;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterambil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ambilbutton;
        private System.Windows.Forms.Label jumlahmhslabel;
        private System.Windows.Forms.Label Namadsnlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combokls;
        private System.Windows.Forms.ComboBox comboidkls;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;


    }
}