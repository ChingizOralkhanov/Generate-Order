using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OrderLibrary
{
    public class SaveDialogProcessor
    {
        private SaveFileDialog saveFile { get; set; }
        private string path = @"C:\Users\user\source\repos\Generate Order\Generate Order\bin\Debug\OutputDocument.docx";
        public SaveDialogProcessor()
        {
            saveFile = new SaveFileDialog();
            saveFile.Filter = "Word files (.docx)|*.doc|All files (*.*)|*.*";
            saveFile.FileName = $"Order from {DateTime.UtcNow.ToShortDateString()}";
            saveFile.Title = "Save new Order";
        }
        
        public void saveFileToDirectory()
        {
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Copy(path, saveFile.FileName, true);
            }
        }
    }
}