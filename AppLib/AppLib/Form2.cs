using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppLib
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("Library.xml");
            try
            {
                
                DateTime.Parse(textBox_DataIssue.Text);
                if (DateTime.Parse(textBox_DataIssue.Text) > DateTime.Today) { throw new Exception(); };
                if (!textBox_LastName.Text.All(c => char.IsLetter(c))) { throw new Exception(); };
                if (textBox_NameBook.Text.All(c => c == ' ')) { throw new Exception(); };
                if (textBox_Author.Text.All(c => c == ' ')) { throw new Exception(); };
                if (textBox_PublishingHouse.Text.All(c => c == ' ')) { throw new Exception(); };
                XElement Book = new XElement("Book",
                        new XElement("IdCard", Int32.Parse(textBox_Id.Text)),
                        new XElement("LastName", textBox_LastName.Text),
                        new XElement("DataOfIssue", textBox_DataIssue.Text),
                        new XElement("DataReturn", Int32.Parse(textBox_DataReturn.Text)),
                        new XElement("Author", textBox_Author.Text),
                        new XElement("NameBook", textBox_NameBook.Text),
                        new XElement("YearOfPublishing", Int32.Parse(textBox_YearPublishing.Text)),
                        new XElement("PublishingHouse", textBox_PublishingHouse.Text),
                        new XElement("Price", Int32.Parse(textBox_Price.Text)));
                doc.Root.Add(Book);
                doc.Save("Library.xml");

                Close();
            }
            catch
            {
                MessageBox.Show(
                    "Введены некорректные данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
