using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace hiddenAnaconda.Models {
    class AddingVehicles {
        ReportDataContext dc;
        public AddingVehicles() {
            dc = new ReportDataContext();
        }

        public bool AddVehicle(string plateNumber, string vinNumber, string model, string brand, DateTime productionDate, bool isLowFloor, bool isWorking) {
            pojazd vehicle = new pojazd();
            vehicle.nr_rejestracyjny = plateNumber;
            vehicle.nr_VIN = vinNumber;
            vehicle.model = model;
            vehicle.marka = brand;
            vehicle.data_produkcji = productionDate;
            vehicle.czy_niskopodlogowy = isLowFloor;
            vehicle.czy_sprawny = isWorking;

            if (checkIfVehicleExist(plateNumber)) {
                MessageBox.Show("Pojazd o podanym numerze rejestracyjnym istnieje już w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else {
                try {
                    dc.pojazds.InsertOnSubmit(vehicle);
                    dc.SubmitChanges();
                } catch {
                    MessageBox.Show("Nie udało się utworzyć pojazdu. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Pomyślnie utworzono nowy pojazd.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool checkIfVehicleExist(string plateNumber) { //sprawdzanie czy pojazd już istnieje
            if (dc.pojazds.Any(u => u.nr_rejestracyjny == plateNumber))
                return true;
            return false;
        }
    }
}
