namespace Quan_Ly_San_Pham
{
    partial class frmQuanLySanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_noselect = new System.Windows.Forms.Button();
            this.lsb_product = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_live_exp = new System.Windows.Forms.Label();
            this.txt_live_orgin = new System.Windows.Forms.Label();
            this.txt_live_price = new System.Windows.Forms.Label();
            this.txt_view_product = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_exp = new System.Windows.Forms.DateTimePicker();
            this.txtb_orgin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_product = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_moregat = new System.Windows.Forms.Button();
            this.cmb_listgat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_noselect);
            this.splitContainer1.Panel1.Controls.Add(this.lsb_product);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(737, 435);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_noselect
            // 
            this.btn_noselect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_noselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noselect.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_noselect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_noselect.Location = new System.Drawing.Point(12, 394);
            this.btn_noselect.Name = "btn_noselect";
            this.btn_noselect.Size = new System.Drawing.Size(221, 29);
            this.btn_noselect.TabIndex = 2;
            this.btn_noselect.Text = "Không chọn gì hết";
            this.btn_noselect.UseVisualStyleBackColor = false;
            this.btn_noselect.Click += new System.EventHandler(this.btn_noselect_Click);
            // 
            // lsb_product
            // 
            this.lsb_product.FormattingEnabled = true;
            this.lsb_product.ItemHeight = 15;
            this.lsb_product.Location = new System.Drawing.Point(12, 30);
            this.lsb_product.Name = "lsb_product";
            this.lsb_product.Size = new System.Drawing.Size(221, 349);
            this.lsb_product.TabIndex = 1;
            this.lsb_product.SelectedIndexChanged += new System.EventHandler(this.lsb_product_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các sản phẩm trong danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thêm sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_remove);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Location = new System.Drawing.Point(11, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 49);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_exit.Location = new System.Drawing.Point(386, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_remove.Location = new System.Drawing.Point(84, 5);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 38);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_save.Location = new System.Drawing.Point(5, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 38);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtp_exp);
            this.panel1.Controls.Add(this.txtb_orgin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtb_price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtb_product);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_moregat);
            this.panel1.Controls.Add(this.cmb_listgat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 338);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txt_live_exp);
            this.panel3.Controls.Add(this.txt_live_orgin);
            this.panel3.Controls.Add(this.txt_live_price);
            this.panel3.Controls.Add(this.txt_view_product);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(25, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 123);
            this.panel3.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(8, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "*Kiểm tra kĩ thông tin trước khi thêm.";
            // 
            // txt_live_exp
            // 
            this.txt_live_exp.AutoSize = true;
            this.txt_live_exp.Location = new System.Drawing.Point(8, 70);
            this.txt_live_exp.Name = "txt_live_exp";
            this.txt_live_exp.Size = new System.Drawing.Size(63, 15);
            this.txt_live_exp.TabIndex = 4;
            this.txt_live_exp.Text = "Hạn dùng:";
            // 
            // txt_live_orgin
            // 
            this.txt_live_orgin.AutoSize = true;
            this.txt_live_orgin.Location = new System.Drawing.Point(8, 55);
            this.txt_live_orgin.Name = "txt_live_orgin";
            this.txt_live_orgin.Size = new System.Drawing.Size(50, 15);
            this.txt_live_orgin.TabIndex = 3;
            this.txt_live_orgin.Text = "Xuất xứ:";
            // 
            // txt_live_price
            // 
            this.txt_live_price.AutoSize = true;
            this.txt_live_price.Location = new System.Drawing.Point(8, 40);
            this.txt_live_price.Name = "txt_live_price";
            this.txt_live_price.Size = new System.Drawing.Size(51, 15);
            this.txt_live_price.TabIndex = 2;
            this.txt_live_price.Text = "Đơn giá:";
            // 
            // txt_view_product
            // 
            this.txt_view_product.AutoSize = true;
            this.txt_view_product.Location = new System.Drawing.Point(8, 25);
            this.txt_view_product.Name = "txt_view_product";
            this.txt_view_product.Size = new System.Drawing.Size(83, 15);
            this.txt_view_product.TabIndex = 1;
            this.txt_view_product.Text = "Tên sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thông tin tổng thể (live review):";
            // 
            // dtp_exp
            // 
            this.dtp_exp.CustomFormat = "dd/MM/yyyy";
            this.dtp_exp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_exp.Location = new System.Drawing.Point(132, 107);
            this.dtp_exp.Name = "dtp_exp";
            this.dtp_exp.Size = new System.Drawing.Size(200, 23);
            this.dtp_exp.TabIndex = 11;
            this.dtp_exp.ValueChanged += new System.EventHandler(this.dtp_exp_ValueChanged);
            // 
            // txtb_orgin
            // 
            this.txtb_orgin.Location = new System.Drawing.Point(132, 136);
            this.txtb_orgin.Name = "txtb_orgin";
            this.txtb_orgin.Size = new System.Drawing.Size(303, 23);
            this.txtb_orgin.TabIndex = 10;
            this.txtb_orgin.TextChanged += new System.EventHandler(this.txtb_orgin_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "*Xuất sứ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "*Hạn dùng:";
            // 
            // txtb_price
            // 
            this.txtb_price.Location = new System.Drawing.Point(132, 78);
            this.txtb_price.Name = "txtb_price";
            this.txtb_price.Size = new System.Drawing.Size(303, 23);
            this.txtb_price.TabIndex = 6;
            this.txtb_price.TextChanged += new System.EventHandler(this.txtb_price_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Đơn giá:";
            // 
            // txtb_product
            // 
            this.txtb_product.Location = new System.Drawing.Point(132, 49);
            this.txtb_product.Name = "txtb_product";
            this.txtb_product.Size = new System.Drawing.Size(303, 23);
            this.txtb_product.TabIndex = 4;
            this.txtb_product.TextChanged += new System.EventHandler(this.txtb_product_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "*Tên sản phẩm:";
            // 
            // btn_moregat
            // 
            this.btn_moregat.Location = new System.Drawing.Point(350, 20);
            this.btn_moregat.Name = "btn_moregat";
            this.btn_moregat.Size = new System.Drawing.Size(85, 23);
            this.btn_moregat.TabIndex = 2;
            this.btn_moregat.Text = "...";
            this.btn_moregat.UseVisualStyleBackColor = true;
            this.btn_moregat.Click += new System.EventHandler(this.btn_moregat_Click);
            // 
            // cmb_listgat
            // 
            this.cmb_listgat.FormattingEnabled = true;
            this.cmb_listgat.Location = new System.Drawing.Point(132, 20);
            this.cmb_listgat.Name = "cmb_listgat";
            this.cmb_listgat.Size = new System.Drawing.Size(212, 23);
            this.cmb_listgat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Chọn danh mục:";
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm [PROJECT - HEX TRÂN]";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private ListBox lsb_product;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button btn_exit;
        private Button btn_remove;
        private Button btn_save;
        private Panel panel1;
        private Panel panel3;
        private DateTimePicker dtp_exp;
        private TextBox txtb_orgin;
        private Label label8;
        private Label label7;
        private TextBox txtb_price;
        private Label label6;
        private TextBox txtb_product;
        private Label label5;
        private Button btn_moregat;
        private ComboBox cmb_listgat;
        private Label label4;
        private Label label14;
        private Label txt_live_exp;
        private Label txt_live_orgin;
        private Label txt_live_price;
        private Label txt_view_product;
        private Label label9;
        private Button btn_noselect;
    }
}