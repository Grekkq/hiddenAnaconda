using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    public class routeElementModel {
        private string _name;
        private string _city;
        private string _way;
        private TimeSpan _timeSpan;

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public string Way { get => _way; set => _way = value; }
        public string ArrivalTime {
            get { return _timeSpan.ToString("hh':'mm"); }
            set { _timeSpan = TimeSpan.Parse(value); }
        }

        public routeElementModel() { }

        public routeElementModel(string name, string city, string arrivalTime, string way) {
            this.Name = name;
            this.City = city;
            this.Way = way;
            this.ArrivalTime = arrivalTime;
        }

        public routeElementModel(string name, string city, TimeSpan arrivalTime, string way) {
            this.Name = name;
            this.City = city;
            this.Way = way;
            this._timeSpan = arrivalTime;
        }

        // Parse record from ListBox
        public routeElementModel(string element) {

            String newcontent = element.Substring(element.IndexOf(") ") + 2);

            this.City = newcontent.Substring(0, newcontent.IndexOf(", ")).Trim();
            newcontent = newcontent.Substring(newcontent.IndexOf(", ") + 2).TrimStart();


            this.Name = newcontent.Substring(0, newcontent.IndexOf(", ")).Trim();
            newcontent = newcontent.Substring(newcontent.IndexOf(", ") + 2).TrimStart();


            int index = Constants.FindArrivalTimeInString.Match(newcontent).Index;
            this.Way = newcontent.Substring(0, index).Trim();
            newcontent = newcontent.Substring(index).Trim();

            this.ArrivalTime = newcontent;
        }

        // Add new record in ListBox
        public void putInListBox(ListBox listBox) {
            int index = listBox.Items.Count + 1;
            string newcontent = (index + ") ").PadRight(5, ' ') + City + ", " + Name + ", " + Way;
            newcontent = newcontent.PadRight(45, ' ') + ArrivalTime;
            listBox.Items.Add(newcontent);
        }

        // Add new record in ListBox at index
        public void putInListBoxAt(ListBox listBox, int index) {
            string newcontent = (index + 1 + ") ").PadRight(5, ' ') + City + ", " + Name + ", " + Way;
            newcontent = newcontent.PadRight(45, ' ') + ArrivalTime;
            listBox.Items.Insert(index, newcontent);
        }
    }
}
