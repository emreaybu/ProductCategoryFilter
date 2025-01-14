using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListofProdcuts();
            ListCategories();

        }

        private void ListofProdcuts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.ToList();

            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();

            }
        }

        private void SearchProductByName(string name)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(P=>P.ProductName.StartsWith(name)).ToList();

            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            { 
                

            }
        }

        private void tbxProducts_TextChanged(object sender, EventArgs e)
        {
            string key = tbxProducts.Text;

            if (string.IsNullOrEmpty(key)) 
            {
                ListofProdcuts();
            }
            else
            {
                SearchProductByName(tbxProducts.Text);

            }
        }
    }
}
