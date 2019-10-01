using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortToXML {
    public class Database {
        public List<Person> DatabaseOfPeople = new List<Person>();

        public void fillDatabase() {
            DatabaseOfPeople.Add(new Person(001, "Jones Jonathan", "A"));
            DatabaseOfPeople.Add(new Person(034, "Cormier Daniel", "B"));
            DatabaseOfPeople.Add(new Person(028, "Stephens Jeremy", "A"));
            DatabaseOfPeople.Add(new Person(004, "Sandhagen Corry", "D"));
            DatabaseOfPeople.Add(new Person(097, "Bisping Michael", "C"));
            DatabaseOfPeople.Add(new Person(071, "Nunez Amanda", "C"));
            DatabaseOfPeople.Add(new Person(018, "Tate Miesha", "D"));
            DatabaseOfPeople.Add(new Person(033, "Adesanya Israel", "D"));
            DatabaseOfPeople.Add(new Person(081, "Fitch John", "B"));
            DatabaseOfPeople.Add(new Person(009, "Holm Holly", "A"));
        }

        
    }
}
