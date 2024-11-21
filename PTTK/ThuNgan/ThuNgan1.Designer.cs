namespace PTTK.ThuNgan
{
    partial class ThuNgan1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuNgan1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xemcp = new System.Windows.Forms.Button();
            this.dgv_thungan = new System.Windows.Forms.DataGridView();
            this.dtp_Thangnam = new System.Windows.Forms.DateTimePicker();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_Mindoanhthu = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thungan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu ngân";
            // 
            // btn_xemcp
            // 
            this.btn_xemcp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xemcp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemcp.Location = new System.Drawing.Point(406, 285);
            this.btn_xemcp.Name = "btn_xemcp";
            this.btn_xemcp.Size = new System.Drawing.Size(149, 33);
            this.btn_xemcp.TabIndex = 1;
            this.btn_xemcp.Text = "Xem chi phí tháng";
            this.btn_xemcp.UseVisualStyleBackColor = false;
            this.btn_xemcp.Click += new System.EventHandler(this.btn_xemcp_Click);
            // 
            // dgv_thungan
            // 
            this.dgv_thungan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thungan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_thungan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_thungan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thungan.Location = new System.Drawing.Point(126, 54);
            this.dgv_thungan.Name = "dgv_thungan";
            this.dgv_thungan.RowHeadersWidth = 51;
            this.dgv_thungan.RowTemplate.Height = 24;
            this.dgv_thungan.Size = new System.Drawing.Size(534, 201);
            this.dgv_thungan.TabIndex = 2;
            // 
            // dtp_Thangnam
            // 
            this.dtp_Thangnam.CustomFormat = "MM/yyyy";
            this.dtp_Thangnam.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Thangnam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Thangnam.Location = new System.Drawing.Point(126, 289);
            this.dtp_Thangnam.Name = "dtp_Thangnam";
            this.dtp_Thangnam.Size = new System.Drawing.Size(237, 22);
            this.dtp_Thangnam.TabIndex = 3;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(693, 404);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(95, 34);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_Mindoanhthu
            // 
            this.txt_Mindoanhthu.Location = new System.Drawing.Point(125, 392);
            this.txt_Mindoanhthu.Name = "txt_Mindoanhthu";
            this.txt_Mindoanhthu.Size = new System.Drawing.Size(223, 22);
            this.txt_Mindoanhthu.TabIndex = 5;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(406, 386);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(149, 28);
            this.btn_timkiem.TabIndex = 6;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập mức doanh thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xem Top Khách hàng";
            // 
            // ThuNgan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_Mindoanhthu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dtp_Thangnam);
            this.Controls.Add(this.dgv_thungan);
            this.Controls.Add(this.btn_xemcp);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ThuNgan1";
            this.Text = "ThuNgan1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thungan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xemcp;
        private System.Windows.Forms.DataGridView dgv_thungan;
        private System.Windows.Forms.DateTimePicker dtp_Thangnam;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_Mindoanhthu;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}