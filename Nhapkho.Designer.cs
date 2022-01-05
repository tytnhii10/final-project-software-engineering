
namespace cuoi_ki
{
    partial class Nhapkho
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
            this.label7 = new System.Windows.Forms.Label();
            this.grnhap = new System.Windows.Forms.GroupBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMannhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdetail = new System.Windows.Forms.GroupBox();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtmactn = new System.Windows.Forms.TextBox();
            this.chitietnhap = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbManhap = new System.Windows.Forms.ComboBox();
            this.dateNhap = new System.Windows.Forms.TextBox();
            this.grnhap.SuspendLayout();
            this.grdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitietnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nhập kho";
            // 
            // grnhap
            // 
            this.grnhap.Controls.Add(this.dateNhap);
            this.grnhap.Controls.Add(this.btnCreate);
            this.grnhap.Controls.Add(this.cbManv);
            this.grnhap.Controls.Add(this.label6);
            this.grnhap.Controls.Add(this.label5);
            this.grnhap.Controls.Add(this.txtMannhap);
            this.grnhap.Controls.Add(this.label4);
            this.grnhap.Location = new System.Drawing.Point(12, 48);
            this.grnhap.Name = "grnhap";
            this.grnhap.Size = new System.Drawing.Size(816, 140);
            this.grnhap.TabIndex = 17;
            this.grnhap.TabStop = false;
            this.grnhap.Text = "Nhập kho";
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(154, 82);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(195, 24);
            this.cbManv.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtMannhap
            // 
            this.txtMannhap.Location = new System.Drawing.Point(154, 29);
            this.txtMannhap.Name = "txtMannhap";
            this.txtMannhap.Size = new System.Drawing.Size(195, 22);
            this.txtMannhap.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã nhập";
            // 
            // grdetail
            // 
            this.grdetail.Controls.Add(this.cbManhap);
            this.grdetail.Controls.Add(this.cbmasp);
            this.grdetail.Controls.Add(this.label14);
            this.grdetail.Controls.Add(this.label13);
            this.grdetail.Controls.Add(this.label12);
            this.grdetail.Controls.Add(this.label2);
            this.grdetail.Controls.Add(this.label10);
            this.grdetail.Controls.Add(this.txtsl);
            this.grdetail.Controls.Add(this.txtGia);
            this.grdetail.Controls.Add(this.txtmactn);
            this.grdetail.Controls.Add(this.chitietnhap);
            this.grdetail.Location = new System.Drawing.Point(12, 214);
            this.grdetail.Name = "grdetail";
            this.grdetail.Size = new System.Drawing.Size(816, 279);
            this.grdetail.TabIndex = 18;
            this.grdetail.TabStop = false;
            this.grdetail.Text = "Chi tiết nhập";
            // 
            // cbmasp
            // 
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(470, 25);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(121, 24);
            this.cbmasp.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Mã nhập";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(335, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Mã sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(335, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Số lượng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mã chi tiết nhập";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(470, 67);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(121, 22);
            this.txtsl.TabIndex = 27;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(688, 27);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 26;
            // 
            // txtmactn
            // 
            this.txtmactn.Location = new System.Drawing.Point(165, 29);
            this.txtmactn.Name = "txtmactn";
            this.txtmactn.Size = new System.Drawing.Size(100, 22);
            this.txtmactn.TabIndex = 24;
            // 
            // chitietnhap
            // 
            this.chitietnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chitietnhap.Location = new System.Drawing.Point(6, 113);
            this.chitietnhap.Name = "chitietnhap";
            this.chitietnhap.RowHeadersWidth = 51;
            this.chitietnhap.RowTemplate.Height = 24;
            this.chitietnhap.Size = new System.Drawing.Size(804, 160);
            this.chitietnhap.TabIndex = 23;
            this.chitietnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chitietnhap_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(591, 511);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(753, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(672, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(735, 101);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbManhap
            // 
            this.cbManhap.FormattingEnabled = true;
            this.cbManhap.Location = new System.Drawing.Point(165, 72);
            this.cbManhap.Name = "cbManhap";
            this.cbManhap.Size = new System.Drawing.Size(100, 24);
            this.cbManhap.TabIndex = 37;
            // 
            // dateNhap
            // 
            this.dateNhap.Location = new System.Drawing.Point(579, 29);
            this.dateNhap.Name = "dateNhap";
            this.dateNhap.Size = new System.Drawing.Size(195, 22);
            this.dateNhap.TabIndex = 23;
            // 
            // Nhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 565);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdetail);
            this.Controls.Add(this.grnhap);
            this.Controls.Add(this.label7);
            this.Name = "Nhapkho";
            this.Text = "Nhapkho";
            this.Load += new System.EventHandler(this.Nhapkho_Load);
            this.grnhap.ResumeLayout(false);
            this.grnhap.PerformLayout();
            this.grdetail.ResumeLayout(false);
            this.grdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitietnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grnhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMannhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.GroupBox grdetail;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtmactn;
        private System.Windows.Forms.DataGridView chitietnhap;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbManhap;
        private System.Windows.Forms.TextBox dateNhap;
    }
}