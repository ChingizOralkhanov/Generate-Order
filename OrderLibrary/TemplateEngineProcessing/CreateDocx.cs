using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateEngine.Docx;

namespace OrderLibrary.TemplateEngineProcessing
{
    public class CreateDocx : IDocumentCreator
    {
        public List<ProductModel> productsList { get; set; }
        public string templateName { get; set; }
        public string documentName { get; set; }
        public TableContent tableContent { get; set; }
        public FieldContent dateOfDocument { get; set; }
        public TemplateProcessor templateProcessor { get; set; }

        public CreateDocx(string templatename, string documentname, List<ProductModel> products)
        {
            productsList = products;
            templateName = templatename;
            documentName = documentname;
            tableContent = generateTableContent(products);
            dateOfDocument = getDocumentDate();
            //File.Delete(documentName);
            //File.Copy(templateName, documentName);
        }
        public void GenerateDocument()
        {
            var table = generateTableContent(productsList);
            var valuesToFill = getNewContent(table);
            var datetoFill = getNewContent(getDocumentDate());
            fillInAllContent(datetoFill, valuesToFill);
        }
        public void fillInAllContent(Content date, Content tableContentItems)
        {
            using (var outputDocument = new TemplateProcessor(documentName)
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(tableContentItems);
                outputDocument.FillContent(date);
                outputDocument.SaveChanges();
            }
            productsList.Clear();
        }
        public TableContent generateTableContent(List<ProductModel> products)
        {
            tableContent = new TableContent("Order Table");
            int productNumber = 1;
            foreach (var product in products)
            {
                tableContent.AddRow(
                  new FieldContent("Number", productNumber.ToString()),
                  new FieldContent("Product Code", product.ProductCode),
                  new FieldContent("Product Name", product.ProductName),
                  new FieldContent("Product Amount", product.Amount.ToString())
                 );
                productNumber++;
            }
            return tableContent;

        }
        public FieldContent getDocumentDate()
        {
            return new FieldContent("Time", DateTime.UtcNow.ToShortDateString());
        }
        public Content getNewContent(IContentItem content)
        {
            return new Content(content);
        }

    }
}
