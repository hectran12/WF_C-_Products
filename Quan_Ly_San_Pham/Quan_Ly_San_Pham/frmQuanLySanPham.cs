using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_San_Pham
{
    public partial class frmQuanLySanPham : Form
    {
        public static List<Category> categories = new List<Category>();
        public static bool ChangeQuestion = false;
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // OPEN THE "FRMCHOOSECATEGORY"
        private void btn_moregat_Click(object sender, EventArgs e)
        {
            // open frm
            frmChooseCategory category = new frmChooseCategory();
            if(category.ShowDialog() == DialogResult.OK)
            {
                LoadListCategoryInComboBox();
            }
        }

        // hiện tất cả danh sách danh mục
        private void LoadListCategoryInComboBox()
        {
            cmb_listgat.Items.Clear();
            foreach (Category category in categories)
            {
                cmb_listgat.Items.Add(category);
            }
        }
        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            
        }

        // UPDATE INFO
        private void txtb_product_TextChanged(object sender, EventArgs e)
        {
            txt_view_product.Text = "Tên sản phẩm: " + txtb_product.Text;
        }
        // UPDATE INFO
        private void txtb_price_TextChanged(object sender, EventArgs e)
        {
            txt_live_price.Text = "Đơn giá: " + txtb_price.Text;
        }
        // UPDATE INFO
        private void txtb_orgin_TextChanged(object sender, EventArgs e)
        {
            txt_live_orgin.Text = "Xuất xứ: "+txtb_orgin.Text;
        }
        // UPDATE INFO
        private void dtp_exp_ValueChanged(object sender, EventArgs e)
        {
            txt_live_exp.Text = "Hạn dùng: " + dtp_exp.Value;
        }
        // khi ấn vào save
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(lsb_product.SelectedIndex != -1)
            {
                Product pr = lsb_product.SelectedItem as Product;
                Category cate = cmb_listgat.SelectedItem as Category;
                pr.NameProduct = txtb_product.Text;
                pr.PriceProduct = txtb_price.Text + "";
                pr.OrginProduct = txtb_orgin.Text;
                pr.ExpProduct = dtp_exp.Value;
                pr.CateGroup = cate;
                resetInput();
                reloadListItem();
                MessageBox.Show("Thay đổi thành công!", "Thành Công!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                if (cmb_listgat.SelectedIndex != -1)
                {
                    if (txtb_price.Text == "" || txtb_orgin.Text == "" || txtb_product.Text == "")
                    {
                        MessageBox.Show("Nhập thiếu dữ liệu , không thể thêm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Category cate = cmb_listgat.SelectedItem as Category;
                        Product pr = new Product();
                        pr.NameProduct = txtb_product.Text;
                        pr.PriceProduct = txtb_price.Text + "";
                        pr.OrginProduct = txtb_orgin.Text;
                        pr.ExpProduct = dtp_exp.Value;
                        pr.CateGroup = cate;
                        cate.AddProduct(pr);
                        resetInput();
                        reloadListItem();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn danh mục!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        // hàm làm mới nhập
        private void resetInput()
        {
            txtb_product.Text = "";
            txtb_price.Text = "";
            txtb_orgin.Text = "";
            txtb_product.Focus();
        }
        // hàm load lại listbox 
        private void reloadListItem()
        {
            lsb_product.Items.Clear();
            foreach (Category cate in categories)
            {
                 foreach(Product items in cate.listpro)
                {
                    lsb_product.Items.Add(items);
                }
            }
        }
        // hàm kiểm tra sự thay đổi
        private void lsb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsb_product.SelectedIndex != -1)
            {
                Product pr = (Product)lsb_product.SelectedItem as Product;
                cmb_listgat.Text = pr.CateGroup.NameGategory;
                txtb_orgin.Text = pr.OrginProduct;
                txtb_product.Text = pr.NameProduct;
                txtb_price.Text = pr.PriceProduct;
                dtp_exp.Text = pr.ExpProduct.ToString();
            }
        }
        // hàm reset click
        private void btn_noselect_Click(object sender, EventArgs e)
        {
            lsb_product.SelectedIndex = -1;
        }
        // hàm thoát
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn thuốc chứ?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                this.Close();
            } else
            {
                MessageBox.Show("Đã hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // hàm xóa sản phẩm
        private void btn_remove_Click(object sender, EventArgs e)
        {
            
            if(lsb_product.SelectedIndex != -1)
            {
                Product pr = (Product)lsb_product.SelectedItem as Product;
                pr.CateGroup.listpro.Remove(pr);
                lsb_product.Items.Remove(pr);
                MessageBox.Show("Xóa thành công!", "Trạng thái xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}