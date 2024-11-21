namespace PTTK.ThuNgan
{
    partial class ThuNgan2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuNgan2));
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.dgv_thungan2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thungan2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(271, 359);
            this.txt_thang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(112, 27);
            this.txt_thang.TabIndex = 0;
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(271, 428);
            this.txt_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(112, 27);
            this.txt_nam.TabIndex = 1;
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xem.Location = new System.Drawing.Point(492, 359);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(162, 36);
            this.btn_xem.TabIndex = 2;
            this.btn_xem.Text = "Xem doanh thu";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xuatexcel.Location = new System.Drawing.Point(493, 422);
            this.btn_xuatexcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.Size = new System.Drawing.Size(161, 36);
            this.btn_xuatexcel.TabIndex = 3;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = false;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // dgv_thungan2
            // 
            this.dgv_thungan2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thungan2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_thungan2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thungan2.Location = new System.Drawing.Point(145, 90);
            this.dgv_thungan2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_thungan2.Name = "dgv_thungan2";
            this.dgv_thungan2.RowHeadersWidth = 51;
            this.dgv_thungan2.RowTemplate.Height = 24;
            this.dgv_thungan2.Size = new System.Drawing.Size(590, 224);
            this.dgv_thungan2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(192, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Báo cáo doanh thu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(804, 474);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(92, 34);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // ThuNgan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_thungan2);
            this.Controls.Add(this.btn_xuatexcel);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.txt_thang);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThuNgan2";
            this.Text = "ThuNgan2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thungan2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.DataGridView dgv_thungan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thoat;
    }
}