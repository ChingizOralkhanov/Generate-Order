using System.Collections.Generic;
using System.Windows.Forms;
using System.Web;
using OrderLibrary;
using System.Linq;
using System.IO;
using TemplateEngine.Docx;
using System;
using OrderLibrary.TemplateEngineProcessing;

namespace Generate_Order
{
    public partial class CreateProductForm : Form
    {
        List<ProductModel> ProductsList = new List<ProductModel>();
        List<ProductModel> AvailableProducts = new List<ProductModel>();
        public CreateProductForm()
        {
            InitializeComponent();
        }
        private void AddProductButton_Click(object sender, System.EventArgs e)
        {
            if (!ValidateForm())
            {
                GenerateProductsList();
                if (ProductsList.Count!=0)
                {
                    File.Delete("OutputDocument.docx");
                    File.Copy("InputTemplate.docx", "OutputDocument.docx");
                    var document = new CreateDocx("InputTemplate.docx", "OutputDocument.docx", ProductsList);
                    document.GenerateDocument();
                    var save = new SaveDialogProcessor();
                    save.saveFileToDirectory();
                    MessageBox.Show("Order has been created");
                }
                else
                {
                    MessageBox.Show("Form is Invalid.");
                }
            
            }
            else
            {
                MessageBox.Show("Form is Invalid. Please check and try again");
            }
        }
        private void AddToDbButton_Click(object sender, System.EventArgs e)
        {
            GenerateProductsList();
            foreach (var product in ProductsList)
            {
                GlobalConfig.Connection.CreateProduct(product);
            }
           

        }

        private void GetAllProductsButton_Click(object sender, System.EventArgs e)
        {
            AvailableProducts = GlobalConfig.Connection.GetProductsAll();
        }

        private bool ValidateForm()
        {
            bool output = false;
            int Amount = 0;
            var AmountsValid = new List<bool>();
            var CollectedTextBoxAmounts = GetAllAmounts();
            bool AmountValid;
            foreach (var text in CollectedTextBoxAmounts)
            {
                AmountValid = int.TryParse(text, out Amount);
                if (!AmountValid)
                {
                    output = true;
                }
            }
            return output;
        }
        private void GenerateProductsList()
        {
            var ProductName = GetAllNames();
            var ProductAmount = GetAllAmounts();
            for (int i = 0; i < ProductAmount.Count; i++)
            {
                if (ProductAmount[i] != "0" && ProductName[i] != "")
                {
                    var model = new ProductModel(ProductName[i], int.Parse(ProductAmount[i]));
                    ProductsList.Add(model);
                }

            }

        }
        private List<string> GetAllAmounts()
        {
            var output = new List<string>();

            output.Add(AmountTextBox1.Text);
            output.Add(AmountTextBox2.Text);
            output.Add(AmountTextBox3.Text);
            output.Add(AmountTextBox4.Text);
            output.Add(AmountTextBox5.Text);
            return output;
        }
        private List<string> GetAllNames()
        {
            var output = new List<string>();

            output.Add(ProductDropDown1.Text);
            output.Add(ProductDropDown2.Text);
            output.Add(ProductDropDown3.Text);
            output.Add(ProductDropDown4.Text);
            output.Add(ProductDropDown5.Text);
            return output;
        }
    }

}
