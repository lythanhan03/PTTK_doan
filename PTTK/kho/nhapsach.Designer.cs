namespace PTTK
{
    partial class nhapsach
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
            this.dgv_nhapsach = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.txt_dongianhap = new System.Windows.Forms.TextBox();
            this.txt_soluongnhap = new System.Windows.Forms.TextBox();
            this.txt_maphieunhap = new System.Windows.Forms.TextBox();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập sách";
            // 
            // dgv_nhapsach
            // 
            this.dgv_nhapsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhapsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_nhapsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapsach.Location = new System.Drawing.Point(23, 58);
            this.dgv_nhapsach.Name = "dgv_nhapsach";
            this.dgv_nhapsach.RowHeadersWidth = 51;
            this.dgv_nhapsach.RowTemplate.Height = 24;
            this.dgv_nhapsach.Size = new System.Drawing.Size(557, 184);
            this.dgv_nhapsach.TabIndex = 1;
            this.dgv_nhapsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapsach_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.button2.Location = new System.Drawing.Point(621, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xem hàng sắp hết";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label4.Location = new System.Drawing.Point(241, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label5.Location = new System.Drawing.Point(225, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã phiếu nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label7.Location = new System.Drawing.Point(241, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã NCC";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(104, 303);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(100, 22);
            this.txt_masach.TabIndex = 12;
            // 
            // txt_dongianhap
            // 
            this.txt_dongianhap.Location = new System.Drawing.Point(335, 303);
            this.txt_dongianhap.Name = "txt_dongianhap";
            this.txt_dongianhap.Size = new System.Drawing.Size(100, 22);
            this.txt_dongianhap.TabIndex = 14;
            // 
            // txt_soluongnhap
            // 
            this.txt_soluongnhap.Location = new System.Drawing.Point(104, 404);
            this.txt_soluongnhap.Name = "txt_soluongnhap";
            this.txt_soluongnhap.Size = new System.Drawing.Size(100, 22);
            this.txt_soluongnhap.TabIndex = 15;
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.Location = new System.Drawing.Point(335, 409);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.Size = new System.Drawing.Size(100, 22);
            this.txt_maphieunhap.TabIndex = 16;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(335, 355);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(100, 22);
            this.txt_mancc.TabIndex = 18;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btn_thoat.Location = new System.Drawing.Point(704, 400);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 38);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.button3.Location = new System.Drawing.Point(621, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Location = new System.Drawing.Point(23, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 8);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label8.Location = new System.Drawing.Point(10, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên Sách";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(104, 353);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(100, 22);
            this.txt_tensach.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label9.Location = new System.Drawing.Point(450, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mã nhân viên";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(559, 303);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(100, 22);
            this.txt_manv.TabIndex = 28;
            // 
            // nhapsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_mancc);
            this.Controls.Add(this.txt_maphieunhap);
            this.Controls.Add(this.txt_soluongnhap);
            this.Controls.Add(this.txt_dongianhap);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_nhapsach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "nhapsach";
            this.Text = "nhapsach";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nhapsach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.TextBox txt_dongianhap;
        private System.Windows.Forms.TextBox txt_soluongnhap;
        private System.Windows.Forms.TextBox txt_maphieunhap;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_manv;
    }
}