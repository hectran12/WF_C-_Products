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
    public partial class frmChooseCategory : Form
    {
        static string sessName = "";
        static string sessCode = "";
        public frmChooseCategory()
        {
            InitializeComponent();
        }

        private void frmChooseCategory_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllGateGory();
            } catch { }
            txt_more_category.Text = "";
        }

        // hiện tất cả danh mục
        private void LoadAllGateGory()
        {
            lsb_catgory.Items.Clear();
            List<Category> cate = frmQuanLySanPham.categories;
            foreach (Category c in cate)
            {
                lsb_catgory.Items.Add(c);
            }
        }


        // kiểm tra sự thay đổi ở txtb_code 
        private void txtb_code_TextChanged(object sender, EventArgs e)
        {
            if (checkspecialchar(txtb_code.Text) || CheckString(txtb_code))
            {
                hideerror.SetError(txtb_code, "Không được ghi kí tự đặt biệt, hoạc có chữ viết!");
                DeleteSpecialChar(txtb_code);
            } else
            {
                sessCode = txtb_code.Text;
                hideerror.SetError(txtb_code, "");
                UpdateInfoMore();
            }

        }

        // cập nhật thông tin cho info more
        private void UpdateInfoMore ()
        {
            txt_more_category.Text = "Tên gategory: " + sessName + "\nMã gategory: " + sessCode;
        }
        // xóa kí tự đặt biệt
        private void DeleteSpecialChar (Control cons)
        {
            string special = "%$^&*#";
            var tochar_arr = special.ToArray();
            foreach (var c in tochar_arr)
            {
                if (cons.Text.Contains(Convert.ToString(c)))
                {
                    cons.Text = cons.Text.Replace(Convert.ToString(c), "");
                }
            }
        }
        // kiểm tra coi có kí tuej đặt biệt hay không
        private bool checkspecialchar (string text)
        {
            bool status = false;
            string special = "%$^&*#";
            var tochar_arr = special.ToArray();
            foreach (var c in tochar_arr)
            {
                if (text.Contains(Convert.ToString(c)))
                {
                    status = true;
                }
            }
            return status;
        }

        // kiểm tra có văn bản trong control không?
        private bool CheckString(Control cons)
        {
            bool status = false;
            string character = "qwertyuiopasdfghjklzxcvbnm";
            var to_char_arr = character.ToArray();
            foreach (var c in to_char_arr)
            {
                if (cons.Text.Contains(Convert.ToString(c)))
                {
                    cons.Text = cons.Text.Replace(Convert.ToString(c), "");
                    status = true;
                }
            }
            return status;
        }
        // kiểm tra sự thay đổi ở textb_name_gategory
        private void txtb_name_gategory_TextChanged(object sender, EventArgs e)
        {
            if (checkspecialchar(txtb_name_gategory.Text))
            {
                hideerror.SetError(txtb_name_gategory, "Không được ghi kí tự đặt biệt");
                DeleteSpecialChar(txtb_name_gategory);
                
            }
            else
            {
                sessName = txtb_name_gategory.Text;
                hideerror.SetError(txtb_name_gategory, "");
                UpdateInfoMore();
            }
        }

        // save button
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txtb_code.Text != "" || txtb_name_gategory.Text != "")
            {
                if (checkContainsCateGory(txtb_code.Text))
                {
                    Category cate = new Category();
                    cate.NameGategory = txtb_name_gategory.Text;
                    cate.CodeGategory = txtb_code.Text;
                    frmQuanLySanPham.categories.Add(cate);
                    LoadAllGateGory();
                    txtb_name_gategory.Text = "";
                    txtb_code.Text = "";
                    frmQuanLySanPham.ChangeQuestion = true;
                } else
                {
                    MessageBox.Show("Có lỗi trùng mã", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } else
            {
                MessageBox.Show("Chưa nhập tên và mã!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool checkContainsCateGory(string ma)
        {
            foreach (Category cate in frmQuanLySanPham.categories)
            {
                if (cate.CodeGategory.Contains(ma))
                {
                    return false;    
                }
            }
            return true;
        }
        // btn remove item
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(lsb_catgory.SelectedIndex != -1)
            {
                frmQuanLySanPham.categories.RemoveAt(lsb_catgory.SelectedIndex);
                LoadAllGateGory();
                txtb_name_gategory.Text = "";
                txtb_code.Text = "";
                frmQuanLySanPham.ChangeQuestion = true;
            } else
            {
                MessageBox.Show("Không có nhóm nào được chọn!","Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// close tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_closetab_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn đóng chứ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(check == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Hủy tác vụ thành công", "Thành công!");
            }
        }
        // check chọn gategory
        private void lsb_catgory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cate = (Category)lsb_catgory.Items[lsb_catgory.SelectedIndex];
            txtb_code.Text = cate.CodeGategory;
            txtb_name_gategory.Text = cate.NameGategory;
        }
    }
}
