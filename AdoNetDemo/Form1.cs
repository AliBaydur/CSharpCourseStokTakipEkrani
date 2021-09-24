using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            timer1.Start();
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProduct();
            MessageBox.Show("Product Added!");

        }

     

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateStockAmount.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text)
            };
            _productDal.Update(product);
            LoadProduct();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProduct();
            MessageBox.Show("Deleted!");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          lblDate.Text =  DateTime.Now.ToString();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
