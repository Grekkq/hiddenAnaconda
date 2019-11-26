namespace hiddenAnaconda.Models {
    public class routeElementModel {
        private string _name;
        private string _city;
        private string _arrivalTime;

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public string ArrivalTime { get => _arrivalTime; set => _arrivalTime = value; }

        public routeElementModel() { }

        public routeElementModel(string name, string city, string arrivalTime) {
            this.Name = name;
            this.City = city;
            this.ArrivalTime = arrivalTime;
        }
        
    }
}
