using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace SearchAndSortToXML {
    [Serializable]
    public class Person :IComparable<Person>,IComparer<Person> {
        int id;
        string name, discountCode;

        //Constructors
        public Person() { }

        public Person(int id, string name, string discountCode) {
            this.id = id; this.name = name; this.discountCode = discountCode;
        }
  
        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DiscountCode { get => discountCode; set => discountCode = value; }

        public int CompareTo(Person other) {
            return this.id.CompareTo(other.id);
        }
        public int Compare(Person p1, Person p2) {
            return p1.name.CompareTo(p2.name);
        }

    }
}
