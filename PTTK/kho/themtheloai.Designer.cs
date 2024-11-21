namespace PTTK
{
    partial class themtheloai
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
            this.txt_matheloai = new System.Windows.Forms.TextBox();
            this.txt_tentheloai = new System.Windows.Forms.TextBox();
            this.dgv_theloaii = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_them_the_loai = new System.Windows.Forms.Button();
            this.btn_sua_the_loai = new System.Windows.Forms.Button();
            this.btn_xoa_the_loai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thoat_theloaisach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_theloaii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(119, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại";
            // 
            // txt_matheloai
            // 
            this.txt_matheloai.Location = new System.Drawing.Point(208, 318);
            this.txt_matheloai.Name = "txt_matheloai";
            this.txt_matheloai.Size = new System.Drawing.Size(100, 22);
            this.txt_matheloai.TabIndex = 3;
            // 
            // txt_tentheloai
            // 
            this.txt_tentheloai.Location = new System.Drawing.Point(208, 367);
            this.txt_tentheloai.Name = "txt_tentheloai";
            this.txt_tentheloai.Size = new System.Drawing.Size(100, 22);
            this.txt_tentheloai.TabIndex = 4;
            // 
            // dgv_theloaii
            // 
            this.dgv_theloaii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_theloaii.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_theloaii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_theloaii.Location = new System.Drawing.Point(89, 71);
            this.dgv_theloaii.Name = "dgv_theloaii";
            this.dgv_theloaii.RowHeadersWidth = 51;
            this.dgv_theloaii.RowTemplate.Height = 24;
            this.dgv_theloaii.Size = new System.Drawing.Size(579, 183);
            this.dgv_theloaii.TabIndex = 6;
            this.dgv_theloaii.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_theloaii_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.button1.Location = new System.Drawing.Point(417, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_them_the_loai
            // 
            this.btn_them_the_loai.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btn_them_the_loai.Location = new System.Drawing.Point(417, 363);
            this.btn_them_the_loai.Name = "btn_them_the_loai";
            this.btn_them_the_loai.Size = new System.Drawing.Size(88, 38);
            this.btn_them_the_loai.TabIndex = 8;
            this.btn_them_the_loai.Text = "Thêm ";
            this.btn_them_the_loai.UseVisualStyleBackColor = true;
            this.btn_them_the_loai.Click += new System.EventHandler(this.btn_them_the_loai_Click);
            // 
            // btn_sua_the_loai
            // 
            this.btn_sua_the_loai.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btn_sua_the_loai.Location = new System.Drawing.Point(554, 315);
            this.btn_sua_the_loai.Name = "btn_sua_the_loai";
            this.btn_sua_the_loai.Size = new System.Drawing.Size(75, 42);
            this.btn_sua_the_loai.TabIndex = 9;
            this.btn_sua_the_loai.Text = "Sửa ";
            this.btn_sua_the_loai.UseVisualStyleBackColor = true;
            this.btn_sua_the_loai.Click += new System.EventHandler(this.btn_sua_the_loai_Click);
            // 
            // btn_xoa_the_loai
            // 
            this.btn_xoa_the_loai.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btn_xoa_the_loai.Location = new System.Drawing.Point(554, 363);
            this.btn_xoa_the_loai.Name = "btn_xoa_the_loai";
            this.btn_xoa_the_loai.Size = new System.Drawing.Size(75, 38);
            this.btn_xoa_the_loai.TabIndex = 10;
            this.btn_xoa_the_loai.Text = "Xoá";
            this.btn_xoa_the_loai.UseVisualStyleBackColor = true;
            this.btn_xoa_the_loai.Click += new System.EventHandler(this.btn_xoa_the_loai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "THỂ LOẠI SÁCH";
            // 
            // btn_thoat_theloaisach
            // 
            this.btn_thoat_theloaisach.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btn_thoat_theloaisach.Location = new System.Drawing.Point(704, 415);
            this.btn_thoat_theloaisach.Name = "btn_thoat_theloaisach";
            this.btn_thoat_theloaisach.Size = new System.Drawing.Size(84, 33);
            this.btn_thoat_theloaisach.TabIndex = 13;
            this.btn_thoat_theloaisach.Text = "Thoát";
            this.btn_thoat_theloaisach.UseVisualStyleBackColor = true;
            this.btn_thoat_theloaisach.Click += new System.EventHandler(this.btn_thoat_theloaisach_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(89, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 10);
            this.panel1.TabIndex = 14;
            // 
            // themtheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_thoat_theloaisach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_xoa_the_loai);
            this.Controls.Add(this.btn_sua_the_loai);
            this.Controls.Add(this.btn_them_the_loai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_theloaii);
            this.Controls.Add(this.txt_tentheloai);
            this.Controls.Add(this.txt_matheloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "themtheloai";
            this.Text = "capnhattacgia";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_theloaii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matheloai;
        private System.Windows.Forms.TextBox txt_tentheloai;
        private System.Windows.Forms.DataGridView dgv_theloaii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_them_the_loai;
        private System.Windows.Forms.Button btn_sua_the_loai;
        private System.Windows.Forms.Button btn_xoa_the_loai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_thoat_theloaisach;
        private System.Windows.Forms.Panel panel1;
    }
}