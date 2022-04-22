namespace Quan_Ly_San_Pham
{
    partial class frmChooseCategory
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsb_catgory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_closetab = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_more_category = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_name_gategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hideerror = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideerror)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsb_catgory);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_closetab);
            this.splitContainer1.Panel2.Controls.Add(this.btn_remove);
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(468, 205);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 0;
            // 
            // lsb_catgory
            // 
            this.lsb_catgory.FormattingEnabled = true;
            this.lsb_catgory.ItemHeight = 15;
            this.lsb_catgory.Location = new System.Drawing.Point(12, 24);
            this.lsb_catgory.Name = "lsb_catgory";
            this.lsb_catgory.Size = new System.Drawing.Size(164, 169);
            this.lsb_catgory.TabIndex = 8;
            this.lsb_catgory.SelectedIndexChanged += new System.EventHandler(this.lsb_catgory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách các danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin danh mục ";
            // 
            // btn_closetab
            // 
            this.btn_closetab.Location = new System.Drawing.Point(189, 176);
            this.btn_closetab.Name = "btn_closetab";
            this.btn_closetab.Size = new System.Drawing.Size(75, 23);
            this.btn_closetab.TabIndex = 4;
            this.btn_closetab.Text = "Đóng";
            this.btn_closetab.UseVisualStyleBackColor = true;
            this.btn_closetab.Click += new System.EventHandler(this.btn_closetab_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(84, 176);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(3, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txt_more_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtb_name_gategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtb_code);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 146);
            this.panel1.TabIndex = 7;
            // 
            // txt_more_category
            // 
            this.txt_more_category.AutoSize = true;
            this.txt_more_category.Location = new System.Drawing.Point(14, 91);
            this.txt_more_category.Name = "txt_more_category";
            this.txt_more_category.Size = new System.Drawing.Size(58, 15);
            this.txt_more_category.TabIndex = 5;
            this.txt_more_category.Text = "thong_tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thông tin thêm:";
            // 
            // txtb_name_gategory
            // 
            this.txtb_name_gategory.Location = new System.Drawing.Point(104, 40);
            this.txtb_name_gategory.Name = "txtb_name_gategory";
            this.txtb_name_gategory.Size = new System.Drawing.Size(148, 23);
            this.txtb_name_gategory.TabIndex = 1;
            this.txtb_name_gategory.TextChanged += new System.EventHandler(this.txtb_name_gategory_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên danh mục:";
            // 
            // txtb_code
            // 
            this.txtb_code.Location = new System.Drawing.Point(104, 11);
            this.txtb_code.Name = "txtb_code";
            this.txtb_code.Size = new System.Drawing.Size(148, 23);
            this.txtb_code.TabIndex = 0;
            this.txtb_code.TextChanged += new System.EventHandler(this.txtb_code_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã danh mục:";
            // 
            // hideerror
            // 
            this.hideerror.ContainerControl = this;
            // 
            // frmChooseCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 205);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmChooseCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn danh mục [HEX TRẦN]";
            this.Load += new System.EventHandler(this.frmChooseCategory_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideerror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lsb_catgory;
        private Label label1;
        private Label label2;
        private Button btn_closetab;
        private Button btn_remove;
        private Button btn_save;
        private Panel panel1;
        private TextBox txtb_name_gategory;
        private Label label4;
        private TextBox txtb_code;
        private Label label3;
        private Label txt_more_category;
        private Label label5;
        private ErrorProvider hideerror;
    }
}