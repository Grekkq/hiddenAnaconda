using System;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    public class routeElementModel {
        private string _name;
        private string _city;
        private TimeSpan _timeSpan;

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public string ArrivalTime {
            get { return _timeSpan.ToString(); }
            set { _timeSpan = TimeSpan.Parse(value); }
        }

        public routeElementModel() { }

        public routeElementModel(string name, string city, string arrivalTime) {
            this.Name = name;
            this.City = city;
            this.ArrivalTime = arrivalTime;
        }

        // Parse record from ListBox
        public routeElementModel(string element) {
            String newcontent = element.Split(new[] { ") " }, 2, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
            this.City = newcontent.Split(new[] { ", " }, 2, StringSplitOptions.RemoveEmptyEntries)[0];
            this.Name = newcontent.Split(new[] { ", " }, 2, StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(new[] { "   " }, 2, StringSplitOptions.RemoveEmptyEntries)[0];
            newcontent = newcontent.Split(new[] { "   " }, 2, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
            this.ArrivalTime = newcontent;
        }

        // Add new record in ListBox
        public void putInListBox(ListBox listBox) {
            int index = listBox.Items.Count + 1;
            string newcontent = (index + ") ").PadRight(5, ' ') + City + ", " + Name;
            newcontent = newcontent.PadRight(38, ' ') + ArrivalTime;
            listBox.Items.Add(newcontent);
        }

        // Add new record in ListBox at index
        public void putInListBoxAt(ListBox listBox, int index) {
            string newcontent = (index+1 + ") ").PadRight(5, ' ') + City + ", " + Name;
            newcontent = newcontent.PadRight(38, ' ') + ArrivalTime;
            listBox.Items.Insert(index, newcontent);
        }
    }
}
