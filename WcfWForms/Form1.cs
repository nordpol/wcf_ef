using System;
using System.Windows.Forms;
using WcfWForms.CategoryServiceReference;
using WcfWForms.ProductServiceReference;

namespace WcfWForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int id = 1;
            CategoryClient client = new CategoryClient();
            client.Open();
            txtCategoryID.Text = client.GetCategoryID(id).ToString();
            txtCategoryName.Text = client.GetCategoryName(id);
            client.Close();

            ProductsClient productClient = new ProductsClient();
            productClient.Open();
            txtProductID.Text = id.ToString();
            txtProductName.Text = productClient.GetProductName(id).ToString();
            txtProductCategoryID.Text = productClient.GetCategoryID(id).ToString();
            txtProductCategoryName.Text = productClient.GetCategoryName(id).ToString();
            txtProductQty.Text = productClient.GetProductQty(id).ToString();
            productClient.Close();
        }
    }
}
