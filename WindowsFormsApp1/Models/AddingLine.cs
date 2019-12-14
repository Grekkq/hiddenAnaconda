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
    class AddingLine {
        ReportDataContext dc;
        public AddingLine() {
            dc = new ReportDataContext();
        }

        public bool AddLine(int lineNumber, bool isLooping) {
            linia line = new linia();
            line.id_linii = lineNumber;
            line.czy_zapetla = isLooping;
            int czy_zapetla_calc = 0;

            if (checkIfLineExist(lineNumber)) {
                MessageBox.Show("Linia o podanym numerze istnieje już w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else {
                if (isLooping == true) //konwersja bool na int
                    czy_zapetla_calc = 1;
                try {
                    dc.linias.Context.ExecuteCommand("SET IDENTITY_INSERT linia ON; INSERT INTO[dbo].[linia]([id_linii], [czy_zapetla]) VALUES(" + lineNumber + "," + czy_zapetla_calc + "); SET IDENTITY_INSERT linia OFF"); //set indetity -> insert -> set identity
                } catch {
                    MessageBox.Show("Nie udało się utworzyć linii. Spróbuj ponownie.");
                    return false;
                }
            }
            MessageBox.Show("Pomyślnie utworzono linię " + lineNumber + ".", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private bool checkIfLineExist(int lineNumber) { //sprawdzanie czy linia już istnieje
            if (dc.linias.Any(u => u.id_linii == lineNumber))
                return true;
            return false;
        }

    }
}
