using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    class AddTrail {
        ReportDataContext dc;
        private List<String> lines;

        public AddTrail() {
            dc = new ReportDataContext();
            lines = new List<string>();
        }

        public void LoadLinesIntoComboBox(ComboBox comboBox) {
            if (lines.Count == 0)
                GetLinesFromDb();
            foreach(var line in lines)
                comboBox.Items.Add(line);
        }

        private void GetLinesFromDb() {
            var data = dc.linias;
            foreach (var item in data) {
                lines.Add(item.id_linii.ToString());
            }
        }
    }
}
