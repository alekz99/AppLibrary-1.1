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

    public partial class MainForm : Form
    {
		string fileName = "Library.xml";
		public MainForm()
        {
			//CreateXML();
			InitializeComponent();
        }

		public void CreateXML()
		{
			int idCard = 0;

			XDocument doc = new XDocument(
				new XElement("BookCollection",
					new XElement("Book",
						new XElement("IdCard", idCard++),
						new XElement("LastName", "Заплатин"),
						new XElement("DataOfIssue", "19.03.2020"),
						new XElement("DataReturn", 30),
						new XElement("Author", "Виктор Пелевин"),
						new XElement("NameBook", "S.N.U.F.F."),
						new XElement("YearOfPublishing", 2011),
						new XElement("PublishingHouse", "Азбука-Аттикус"),
						new XElement("Price", 450)),
					new XElement("Book",
						new XElement("IdCard", idCard++),
						new XElement("LastName", "Заплатин"),
						new XElement("DataOfIssue", "20.04.2020"),
						new XElement("DataReturn", 30),
						new XElement("Author", "Стендаль"),
						new XElement("NameBook", "Красное и черное"),
						new XElement("YearOfPublishing", 1992),
						new XElement("PublishingHouse", "Искусство"),
						new XElement("Price", 250)),
					new XElement("Book",
						new XElement("IdCard", idCard++),
						new XElement("LastName", "Сухомлинов"),
						new XElement("DataOfIssue", "25.11.2019"),
						new XElement("DataReturn", 20),
						new XElement("Author", "Виктор Пелевин"),
						new XElement("NameBook", "Чапаев и пустота"),
						new XElement("YearOfPublishing", 2008),
						new XElement("PublishingHouse", "Мир книг"),
						new XElement("Price", 300))));
			doc.Save(fileName);
		}

		public bool CheckValue(string IdCard, string DataReturn, string YearOfPublishing,
			string Price, string DataOfIssue, string LastName, string NameBook, string Author, string PublishingHouse)
		{
			try
			{
				Int32.Parse(IdCard);
				Int32.Parse(DataReturn);
				Int32.Parse(YearOfPublishing);
				Int32.Parse(Price);
				DateTime.Parse(DataOfIssue);
				if (DateTime.Parse(DataOfIssue) > DateTime.Today) { throw new Exception(); };
				if (!LastName.All(c => char.IsLetter(c))) { throw new Exception(); };
				if (NameBook.All(c => c == ' ')) { throw new Exception(); };
				if (Author.All(c => c == ' ')) { throw new Exception(); };
				if (PublishingHouse.All(c => c == ' ')) { throw new Exception(); };
				if (Int32.Parse(Price) <= 0) { throw new Exception(); };
				if (Int32.Parse(YearOfPublishing) < 1400 || Int32.Parse(YearOfPublishing) > 2020) { throw new Exception(); };
				if (String.IsNullOrEmpty(IdCard)
					|| String.IsNullOrEmpty(DataReturn)
					|| String.IsNullOrEmpty(YearOfPublishing)
					|| String.IsNullOrEmpty(Price)
					|| String.IsNullOrEmpty(DataOfIssue)
					|| String.IsNullOrEmpty(LastName)
					|| String.IsNullOrEmpty(NameBook)
					|| String.IsNullOrEmpty(Author)
					|| String.IsNullOrEmpty(PublishingHouse)) { throw new Exception(); };
			}
			catch
			{
				return false;
			}
			return true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				loadFromXML(fileName);
			}
			catch
			{
				MessageBox.Show(
				   "Невозможно считать данные",
				   "Ошибка",
				   MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				Close();
			}
		}
        

        public void loadFromXML(string xmlPath)
		{
			XDocument doc;

			try
			{
				doc = XDocument.Load(xmlPath);
			}
			catch
			{
				throw new ArgumentException();
			}

			foreach (XElement el in doc.Root.Elements())
			{
				if (!CheckValue(
					el.Element("IdCard").Value,
					el.Element("DataReturn").Value,
					el.Element("YearOfPublishing").Value,
					el.Element("Price").Value,
					el.Element("DataOfIssue").Value,
					el.Element("LastName").Value,
					el.Element("NameBook").Value,
					el.Element("Author").Value,
					el.Element("PublishingHouse").Value))
				{
					throw new Exception();
				}
				var row = new string[] {el.Element("IdCard").Value, el.Element("LastName").Value, el.Element("DataOfIssue").Value,
						el.Element("DataReturn").Value, el.Element("Author").Value, el.Element("NameBook").Value,
						el.Element("YearOfPublishing").Value, el.Element("PublishingHouse").Value, el.Element("Price").Value};
				var lvi = new ListViewItem(row);
				listViewBooks.Items.Add(lvi);
			}
		}


		private void button_Find_Click(object sender, EventArgs e)
		{
			listViewBooks.Items.Clear();
			XDocument doc = XDocument.Load(fileName);
			IEnumerable<XElement> books = doc.Root.Descendants("Book");
			string input = textBox1.Text;

			switch (comboBox1.SelectedIndex)
			{
				case 0:
					books = doc.Root.Descendants("Book").Where(
						book => book.Element("IdCard").Value == input).ToList();
					break;
				case 1:
					books = doc.Root.Descendants("Book").Where(
						book => book.Element("Author").Value == input).ToList();
					break;
				case 2:
					books = doc.Root.Descendants("Book").Where(
						book => book.Element("PublishingHouse").Value == input).ToList();
					break;

			}

			foreach (XElement el in books)
			{
				var row = new string[] {el.Element("IdCard").Value, el.Element("LastName").Value, el.Element("DataOfIssue").Value,
				el.Element("DataReturn").Value, el.Element("Author").Value, el.Element("NameBook").Value,
				el.Element("YearOfPublishing").Value, el.Element("PublishingHouse").Value, el.Element("Price").Value};
				var lvi = new ListViewItem(row);
				listViewBooks.Items.Add(lvi);
			}
		}

		private void button_Clear_Click(object sender, EventArgs e)
		{
			listViewBooks.Items.Clear();
			XDocument doc = XDocument.Load(fileName);
			IEnumerable<XElement> books = doc.Root.Descendants("Book").OrderBy(
				book => book.Element("IdCard").Value);
			textBox1.Clear();
			foreach (XElement el in books)
			{
				var row = new string[] {el.Element("IdCard").Value, el.Element("LastName").Value, el.Element("DataOfIssue").Value,
				el.Element("DataReturn").Value, el.Element("Author").Value, el.Element("NameBook").Value,
				el.Element("YearOfPublishing").Value, el.Element("PublishingHouse").Value, el.Element("Price").Value};
				var lvi = new ListViewItem(row);
				listViewBooks.Items.Add(lvi);
			}
		}

		private void button_Filter4_Click(object sender, EventArgs e)
		{
			listViewBooks.Items.Clear();
			textBox1.Clear();
			XDocument doc = XDocument.Load(fileName);
			IEnumerable<XElement> books = doc.Root.Descendants("Book");
			DateTime today = DateTime.Today;
			books = doc.Root.Descendants("Book").Where(
						book => Int32.Parse(book.Element("DataReturn").Value) < 
						(int)today.Subtract(DateTime.Parse(book.Element("DataOfIssue").Value)).Days).ToList();

			foreach (XElement el in books)
			{
				var row = new string[] {el.Element("IdCard").Value, el.Element("LastName").Value, el.Element("DataOfIssue").Value,
				el.Element("DataReturn").Value, el.Element("Author").Value, el.Element("NameBook").Value,
				el.Element("YearOfPublishing").Value, el.Element("PublishingHouse").Value, el.Element("Price").Value};
				var lvi = new ListViewItem(row);
				listViewBooks.Items.Add(lvi);
			}
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			AddForm form = new AddForm();
			form.ShowDialog();
			button_Clear.PerformClick();

		}

		private void button_Delete_Click(object sender, EventArgs e)
		{
			DeleteForm form = new DeleteForm();
			form.ShowDialog();
			button_Clear.PerformClick();

		}
	}
}
