using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatsClothesShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patClothesShopDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patClothesShopDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.patClothesShopDataSet.Customer);
            // TODO: This line of code loads data into the 'patClothesShopDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.patClothesShopDataSet.Customer);
            // TODO: This line of code loads data into the 'patClothesShopDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.patClothesShopDataSet.Customer);
            // TODO: This line of code loads data into the 'patClothesShopDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.patClothesShopDataSet.Customer);

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patClothesShopDataSet);

        }

        private void customerBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patClothesShopDataSet);

        }

        private void customerBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patClothesShopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.Show();
        }
    }
}
