namespace PTTK
{
    partial class soluongsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soluongsach));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_kho2 = new System.Windows.Forms.DataGridView();
            this.btn_xemkho = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_thoatkho = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHO SÁCH";
            // 
            // dgv_kho2
            // 
            this.dgv_kho2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kho2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_kho2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kho2.Location = new System.Drawing.Point(121, 76);
            this.dgv_kho2.Name = "dgv_kho2";
            this.dgv_kho2.RowHeadersWidth = 51;
            this.dgv_kho2.RowTemplate.Height = 24;
            this.dgv_kho2.Size = new System.Drawing.Size(591, 201);
            this.dgv_kho2.TabIndex = 1;
            // 
            // btn_xemkho
            // 
            this.btn_xemkho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemkho.Location = new System.Drawing.Point(208, 306);
            this.btn_xemkho.Name = "btn_xemkho";
            this.btn_xemkho.Size = new System.Drawing.Size(103, 32);
            this.btn_xemkho.TabIndex = 2;
            this.btn_xemkho.Text = "Xem kho";
            this.btn_xemkho.UseVisualStyleBackColor = true;
            this.btn_xemkho.Click += new System.EventHandler(this.btn_xemkho_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nhập sách";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_thoatkho
            // 
            this.btn_thoatkho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoatkho.Location = new System.Drawing.Point(713, 405);
            this.btn_thoatkho.Name = "btn_thoatkho";
            this.btn_thoatkho.Size = new System.Drawing.Size(75, 33);
            this.btn_thoatkho.TabIndex = 4;
            this.btn_thoatkho.Text = "Thoát";
            this.btn_thoatkho.UseVisualStyleBackColor = true;
            this.btn_thoatkho.Click += new System.EventHandler(this.btn_thoatkho_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sách sắp hết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // soluongsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_thoatkho);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_xemkho);
            this.Controls.Add(this.dgv_kho2);
            this.Controls.Add(this.label1);
            this.Name = "soluongsach";
            this.Text = "soluongsach";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_kho2;
        private System.Windows.Forms.Button btn_xemkho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_thoatkho;
        private System.Windows.Forms.Button button1;
    }
}