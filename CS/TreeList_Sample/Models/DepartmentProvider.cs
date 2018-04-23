using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeList_Sample.Models {
    public static class DepartmentsProvider {
        public static List<Department> GetDepartments() {
            return new List<Department>() {
                new Department(1, 0, "Corporate Headquarters", 1000000, "Monterey", "(408) 555-1234"),
                new Department(2, 1, "Sales and Marketing", 22000, "San Francisco", "(415) 555-1234"),
                new Department(3, 2, "Field Office: Canada", 500000, "Toronto", "(416) 677-1000", "(416) 555-1234"),
                new Department(4, 2, "Field Office: East Coast", 500000, "Boston", "(617) 555-4234", "(415) 555-1234"),
                new Department(5, 2, "Pacific Rim Headquarters", 600000, "Kuaui", "(808) 555-1234"),
                new Department(6, 5, "Field Office: Singapore", 300000, "Singapore", "(606) 555-5486", "(606) 555-5786"),
                new Department(7, 5, "Field Office: Japan", 500000, "Tokyo", "(707) 555-1526", "(707) 555-5432"),
                new Department(8, 2, "Marketing", 1500000, "San Francisco", "(415) 555-1234"),
                new Department(9, 1, "Finance", 40000, "Monterey", "(408) 555-1234"),
                new Department(10, 1, "Engineering", 1100000, "Monterey", "(408) 555-1234"),
                new Department(11, 10, "Consumer Electronics Div.", 1150000, "Burlington, VT", "(802) 555-1234"),
                new Department(12, 11, "Software Development", 40000, "Monterey", "(408) 555-1234"),
                new Department(13, 10, "Software Products Div.", 1200000, "Monterey", "(408) 555-1234"),
                new Department(14, 13, "Quality Assurance", 48000, "Monterey", "(408) 555-1234", "(408) 555-1234"),
                new Department(15, 13, "Customer Support", 38000, "Monterey", "(408) 555-1234"),
                new Department(16, 13, "Research and Development", 460000, "Burlington, VT", "(802) 555-1234"),
                new Department(17, 13, "Customer Services", 850000, "Burlington, VT", "(802) 555-1234")
            };
        }
    }

    public class Department {
        int id;
        string name;
        string location;
        int budget;
        int parentID;
        string phone1;
        string phone2;

        public Department(int id, int parentID, string name, int budget, string location, string phone1, string phone2 = null) {
            this.id = id;
            this.parentID = parentID;
            this.name = name;
            this.budget = budget;
            this.location = location;
            this.phone1 = phone1;
            this.phone2 = string.IsNullOrEmpty(phone2) ? phone1 : phone2;
        }

        public int ID { get { return id; } }
        public int ParentID { get { return parentID; } }
        public string Name { get { return name; } }
        public int Budget { get { return budget; } }
        public string Location { get { return location; } }
        public string Phone1 { get { return phone1; } }
        public string Phone2 { get { return phone2; } }
    }
}