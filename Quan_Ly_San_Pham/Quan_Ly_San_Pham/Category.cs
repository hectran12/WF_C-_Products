using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_San_Pham
{
    public class Category
    {
        public string NameGategory { get; set; }
        public string CodeGategory { get; set; }
        public List<Product> listpro = new List<Product>();

        public override string ToString()
        {
            return NameGategory;
        }
        // thêm sản phảm
        public void AddProduct (Product produc)
        {
            if(listpro.Contains(produc) == false)
            {
                listpro.Add(produc);
                MessageBox.Show("Thêm thành công sản phẩm [" + produc.NameProduct + "] vào danh mục [" + this.NameGategory + "]", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Không thể thêm, vì có khả năng bị trùng sản phẩm!","Lỗi!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
