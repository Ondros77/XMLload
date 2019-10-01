using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using Newtonsoft.Json;

namespace SearchAndSortToXML {
    public partial class Form1 : Form {

        public Database virtualDatabase = new Database();
        public Person virtualPerson = new Person();
        public string jsonString;

        public Form1() {
            InitializeComponent();
            //virtualDatabase.fillDatabase();
        }

        private void btLoad_Click(object sender, EventArgs e) {
            clearAllText();
            LoadXMLfile();
            //virtualDatabase.fillDatabase();
            //LoadJSONfile();
            showAllData();
        }

        private void btSortId_Click(object sender, EventArgs e) {
            virtualDatabase.DatabaseOfPeople.Sort();
            clearAllText();
            showAllData();
        }

        private void btSortName_Click(object sender, EventArgs e) {
            virtualDatabase.DatabaseOfPeople.Sort(virtualPerson);
            clearAllText();
            showAllData();
        }

        private void btSearchName_Click(object sender, EventArgs e) {
            //virtualDatabase.fillDatabase();
            search();
        }

        private void btSave_Click(object sender, EventArgs e) {
            CreateXMLfile();
            //CreateJSONfile();
        }

        private void btExit_Click(object sender, EventArgs e) {
            Close();
        }


        private void CreateXMLfile() {
            FileStream fs = new FileStream(@"C:\Users\mujno\source\repos\SearchAndSortToXML\DatabaseXML.xml", FileMode.Create);
            SoapFormatter sf = new SoapFormatter();
            foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                sf.Serialize(fs, p);
            }
        }

        private void LoadXMLfile() {
            FileStream fs = new FileStream(@"C:\Users\mujno\source\repos\SearchAndSortToXML\DatabaseXML.xml", FileMode.Open);
            SoapFormatter sf = new SoapFormatter();
            int i = 0;
            try {
                while (fs.CanRead) {
                    fs.Seek(i, SeekOrigin.Begin);
                    Person p1 = (Person)sf.Deserialize(fs);
                    virtualDatabase.DatabaseOfPeople.Add(p1);
                    i++;
                }
            } catch (Exception e) {
                fs.Close();
                Console.WriteLine(e.Message);
            }
        }

        private void CreateJSONfile() {
            StreamWriter sw = new StreamWriter(@"C:\Users\mujno\source\repos\SearchAndSortToXML\DatabaseJSON.txt", true);
            foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                jsonString = JsonConvert.SerializeObject(p);
                sw.WriteLine(jsonString);
            }
            sw.Close();
        }

        private void LoadJSONfile() {
            StreamReader sr = new StreamReader(@"C:\Users\mujno\source\repos\SearchAndSortToXML\DatabaseJSON.txt");
            while (!sr.EndOfStream) {
                jsonString = sr.ReadLine();
                virtualDatabase.DatabaseOfPeople.Add(JsonConvert.DeserializeObject<Person>(jsonString));
            }
        }


        private void showDiscount() {
            foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                switch (p.DiscountCode) {
                    case "A":
                        tbRate.Text += "3 %" + System.Environment.NewLine;
                        break;
                    case "B":
                        tbRate.Text += "7 %" + System.Environment.NewLine;
                        break;
                    case "C":
                        tbRate.Text += "10 %" + System.Environment.NewLine;
                        break;
                    case "D":
                        tbRate.Text += "14 %" + System.Environment.NewLine;
                        break;
                }
            }
        }

        private void showDiscountCode() {
            foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                tbCode.Text += p.DiscountCode + System.Environment.NewLine;
            }
        }

        private void showNames() {
            foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                tbName.Text += p.Name + System.Environment.NewLine;
            }
        }

        private void showId() {
            foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                tbId.Text += p.Id + System.Environment.NewLine;
            }
        }

        private void showAllData() {
            showId();
            showNames();
            showDiscountCode();
            showDiscount();
        }

        private void clearAllText() {
            tbId.Clear();
            tbName.Clear();
            tbCode.Clear();
            tbRate.Clear();
            tbSearchResult.Clear();
        }

        private void search() {
            if (tbSearchName.Text != "") {
                foreach (Person p in virtualDatabase.DatabaseOfPeople) {
                    if (p.Name.Contains(tbSearchName.Text)) {
                        tbSearchResult.Text = "Name: " + p.Name + " Id: " + p.Id + " Discount code: " + p.DiscountCode;
                    }
                }
            }
        }


    }
}
