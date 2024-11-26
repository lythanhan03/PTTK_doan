using System.Windows.Forms;

namespace PTTK
{
    partial class Formkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formkho));
            this.btn_themtudong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_kho1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_tacgia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoatkho = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_matheloai = new System.Windows.Forms.TextBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_themtudong
            // 
            this.btn_themtudong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_themtudong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themtudong.Location = new System.Drawing.Point(602, 203);
            this.btn_themtudong.Name = "btn_themtudong";
            this.btn_themtudong.Size = new System.Drawing.Size(168, 36);
            this.btn_themtudong.TabIndex = 0;
            this.btn_themtudong.Text = "Thêm sách tự động";
            this.btn_themtudong.UseVisualStyleBackColor = false;
            this.btn_themtudong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm sách ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_kho1
            // 
            this.dgv_kho1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_kho1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kho1.Location = new System.Drawing.Point(12, 65);
            this.dgv_kho1.Name = "dgv_kho1";
            this.dgv_kho1.RowHeadersWidth = 51;
            this.dgv_kho1.RowTemplate.Height = 24;
            this.dgv_kho1.Size = new System.Drawing.Size(529, 174);
            this.dgv_kho1.TabIndex = 2;
            this.dgv_kho1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kho1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.btn_them.Location = new System.Drawing.Point(485, 269);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(83, 29);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(127, 270);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(100, 22);
            this.txt_masach.TabIndex = 4;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(127, 334);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(100, 22);
            this.txt_tensach.TabIndex = 5;
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.Location = new System.Drawing.Point(356, 272);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(100, 22);
            this.txt_tacgia.TabIndex = 6;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(356, 334);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 22);
            this.txt_soluong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label2.Location = new System.Drawing.Point(27, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label3.Location = new System.Drawing.Point(27, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên sách";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label.Location = new System.Drawing.Point(251, 270);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 18);
            this.label.TabIndex = 10;
            this.label.Text = "Tác giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label5.Location = new System.Drawing.Point(251, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.btn_sua.Location = new System.Drawing.Point(485, 328);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(83, 34);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.btn_xoa.Location = new System.Drawing.Point(486, 382);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 34);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoatkho
            // 
            this.btn_thoatkho.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.btn_thoatkho.Location = new System.Drawing.Point(693, 405);
            this.btn_thoatkho.Name = "btn_thoatkho";
            this.btn_thoatkho.Size = new System.Drawing.Size(95, 33);
            this.btn_thoatkho.TabIndex = 15;
            this.btn_thoatkho.Text = "Thoát";
            this.btn_thoatkho.UseVisualStyleBackColor = true;
            this.btn_thoatkho.Click += new System.EventHandler(this.btn_thoatkho_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.button1.Location = new System.Drawing.Point(620, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thêm thể loại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.button2.Location = new System.Drawing.Point(620, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thêm NCC";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label4.Location = new System.Drawing.Point(250, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhà xuất bản";
            // 
            // txt_nxb
            // 
            this.txt_nxb.Location = new System.Drawing.Point(356, 388);
            this.txt_nxb.Name = "txt_nxb";
            this.txt_nxb.Size = new System.Drawing.Size(100, 22);
            this.txt_nxb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.label6.Location = new System.Drawing.Point(27, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Thể loại (mã)";
            // 
            // txt_matheloai
            // 
            this.txt_matheloai.Location = new System.Drawing.Point(127, 386);
            this.txt_matheloai.Name = "txt_matheloai";
            this.txt_matheloai.Size = new System.Drawing.Size(100, 22);
            this.txt_matheloai.TabIndex = 21;
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(356, 427);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(100, 22);
            this.txt_giaban.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Giá bán";
            // 
            // Formkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_matheloai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_thoatkho);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tacgia);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_kho1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_themtudong);
            this.Name = "Formkho";
            this.Text = "Formkho";
            this.Load += new System.EventHandler(this.Formkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_themtudong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_kho1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_tacgia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoatkho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_matheloai;
        private TextBox txt_giaban;
        private Label label7;
    }
}