using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLib;
using System.Xml.Linq;
using System.IO;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void checkForIncorrectXMLFileInput()
        {
            MainForm form = new MainForm();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(
                new XElement("BookCollection",
                    new XElement("Book",
                        new XElement("DataOfIssue", "19.03.99999"),
                        new XElement("DataReturn", 30),
                        new XElement("Author", "Виктор Пелевин"),
                        new XElement("NameBook", "S.N.U.F.F."),
                        new XElement("YearOfPublishing", 2011),
                        new XElement("PublishingHouse", "Азбука-Аттикус"),
                        new XElement("Price", 450)),
                    new XElement("Book",
                        new XElement("IdCardddd", 78),
                        new XElement("LastName", "Заплатин"),
                        new XElement("DataOfIssue", "20.04.2020"),
                        new XElement("DataReturn", 30),
                        new XElement("Author", "Стендаль"),
                        new XElement("PublishingHouse", "Искусство"),
                        new XElement("Price", 250))));
            doc.Save(fileName);

            form.loadFromXML(fileName);
        }

        [TestMethod]
        public void checkForCorrectXMLFileInput()
        {
            MainForm form = new MainForm();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(
                new XElement("BookCollection",
                    new XElement("Book",
                        new XElement("IdCard", 12),
                        new XElement("LastName", "Заплатин"),
                        new XElement("DataOfIssue", "19.03.2020"),
                        new XElement("DataReturn", 30),
                        new XElement("Author", "Виктор Пелевин"),
                        new XElement("NameBook", "S.N.U.F.F."),
                        new XElement("YearOfPublishing", 2011),
                        new XElement("PublishingHouse", "Азбука-Аттикус"),
                        new XElement("Price", 450))));
            doc.Save(fileName);
            form.loadFromXML(fileName);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void checkForEmptyPathXMLFileInput()
        {
            MainForm form = new MainForm();

            form.loadFromXML(String.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void checkForEmptyXMLFile()
        {
            MainForm form = new MainForm();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(new XElement("Book"));
            doc.Save(fileName);

            File.WriteAllText(fileName, String.Empty);
            form.loadFromXML(fileName);
        }

        [TestMethod]
        public void checkValueForEmptyInput()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("", "", "", "", "", "", "", "", "");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkValueForCorrectInput()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("134", "3000", "2011", "450", "19.03.2020", "vlad", "Виктор Пелевин", "S.N.U.F.F.",
                "Азбука-Аттикус");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkValueForIntParsing()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("f41", "vlad", "19.03.2020", "30", "Виктор Пелевин", "S.N.U.F.F.",
               "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", "vlad", "19.03.2020", "335f0  fdf", "Виктор Пелевин", "S.N.U.F.F.",
               "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("100", "3033", "2011", "45023", "19.03.2020", "vlad", "Виктор Пелевин", "S.N.U.F.F.",
                 "Азбука-Аттикус");
            Assert.IsTrue(result);

            result = form.CheckValue("134", "3000", "2011", "450", "19.03.2020", "vlad", "Виктор Пелевин", "S.N.U.F.F.",
                "Азбука-Аттикус");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkValueForDateParsing()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("1", "vlad", "19.03.9999899", "30", "Виктор Пелевин", "S.N.U.F.F.",
                "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", "vlad", "-19.03.1834", "30", "Виктор Пелевин", "S.N.U.F.F.",
                "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", "vlad", "34.23.tr433", "30", "Виктор Пелевин", "S.N.U.F.F.",
                "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", "30", "2011", "450", "19.03.2020", "vlad", "Виктор Пелевин", "S.N.U.F.F.",
                "Азбука-Аттикус");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkValueForNullInput()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("1", "vlad", "19.03.9999", "30", "Виктор Пелевин", null,
                "2011", null, "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", null, "19.03.1834", "30", "Виктор Пелевин", "S.N.U.F.F.",
                "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue(null, null, null, null, null, null, null, null, null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkValueForInputWithSpecSymbols()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("*&(#$", "*)$#", ")(*$#", "&*(#", "()#", "#(*&", "^#*", "&(%#", ")#$  323");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkValueForCorrectYearOfPublishing()
        {
            MainForm form = new MainForm();

            bool result = form.CheckValue("1", "vlad", "19.03.9999", "30", "Виктор Пелевин", "S.N.U.F.F.",
                "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", "vlad", "19.03.1834", "30", "Виктор Пелевин", "S.N.U.F.F.",
                "2011", "Азбука-Аттикус", "450");
            Assert.IsFalse(result);

            result = form.CheckValue("1", "30", "2011", "450", "19.03.2020", "vlad", "Виктор Пелевин", "S.N.U.F.F.",
                "Азбука-Аттикус");
            Assert.IsTrue(result);
        }
    }
}
