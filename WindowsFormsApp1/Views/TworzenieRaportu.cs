using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class TworzenieRaportu : Form {
        public TworzenieRaportu() {
            InitializeComponent();
        }

        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        bool ErrorIsOn = false;

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(exit);
        }

        private void TworzenieRaportu_Load(object sender, EventArgs e) {
            label_przystanek.Visible = false;
            comboBox_przystanek.Visible = false;
            label_kierunek.Visible = false;
            comboBox_kierunek.Visible = false;

            //przykladowe dane
            this.comboBox_miasto.Items.Clear();
            this.comboBox_przystanek.Items.Clear();
            this.comboBox_kierunek.Items.Clear();
            this.comboBox_miasto.Items.Add("Katowice");
            this.comboBox_miasto.Items.Add("Gliwice");
            this.comboBox_miasto.Items.Add("Knurów");
            this.comboBox_miasto.Items.Add("Zabrze");
            this.comboBox_miasto.Items.Add("Radzionków");
            this.comboBox_przystanek.Items.Add("Szpitalna");
            this.comboBox_przystanek.Items.Add("Cegielnia");
            this.comboBox_przystanek.Items.Add("Wrocławska");
            this.comboBox_przystanek.Items.Add("Nowy Świat");
            this.comboBox_przystanek.Items.Add("Szpitalna");
            this.comboBox_kierunek.Items.Add("Gliwice-Knurów");
            this.comboBox_kierunek.Items.Add("Knurów-Gliwice");
            this.comboBox_kierunek.Items.Add("Gliwice-Zabrze");
            this.comboBox_kierunek.Items.Add("Zabrze-Gliwice");

            sharedView.LoadCitiesIntoComboBox(comboBox_miasto);
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void comboBox_przystanek_SelectedIndexChanged(object sender, EventArgs e) {
            label_kierunek.Visible = true;
            comboBox_kierunek.Visible = true;
            comboBox_kierunek.Focus();
            sharedView.LoadTrailDirectionIntoComboBox(comboBox_kierunek, comboBox_przystanek.Text, comboBox_miasto.Text);
        }

        private void comboBox_miasto_SelectedIndexChanged(object sender, EventArgs e) {
            label_przystanek.Visible = true;
            comboBox_przystanek.Visible = true;
            comboBox_przystanek.Focus();
            sharedView.LoadBusStopsIntoComboBox(comboBox_przystanek, comboBox_miasto.Text);
            comboBox_kierunek.Items.Clear();
        }

        private void comboBox_miasto_Validating(object sender, CancelEventArgs e) {
            if (comboBox_miasto.SelectedIndex == -1) {
                errorProvider1.SetError(comboBox_miasto, "Nie wybrano miasta");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_miasto, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_przystanek_Validating(object sender, CancelEventArgs e) {
            if (comboBox_przystanek.SelectedIndex == -1) {
                errorProvider1.SetError(comboBox_przystanek, "Nie wybrano przystanku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_przystanek, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_kierunek_Validating(object sender, CancelEventArgs e) {
            if (comboBox_kierunek.SelectedIndex == -1) {
                errorProvider1.SetError(comboBox_kierunek, "Nie wybrano kierunku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_kierunek, null);
                ErrorIsOn = false;
            }
        }

        private void create_Click(object sender, EventArgs e) {
            if (ErrorIsOn == false) {
                Dictionary<string, string> argsForTimeTableConstructor = new Dictionary<string, string>();
                argsForTimeTableConstructor.Add(Constants.BusStopCityName, comboBox_miasto.Text);
                argsForTimeTableConstructor.Add(Constants.BusStopName, comboBox_przystanek.Text);
                argsForTimeTableConstructor.Add(Constants.BusStopWay, comboBox_kierunek.Text);
                using (Views.ZapiszJako InnerForm = new Views.ZapiszJako(argsForTimeTableConstructor)) {
                    if (InnerForm.ShowDialog() == DialogResult.OK) {

                    }
                };
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            var Renderer = new IronPdf.HtmlToPdf();
            Renderer.PrintOptions.InputEncoding = System.Text.Encoding.UTF8;

            var Pdf = Renderer.RenderHtmlAsPdf(@"
<html>
<head>
    <style>
        .CityBusStop {
            font-size: 20px;
            color: gainsboro;
        }

        #busstop {
            font-weight: bolder;
            font-size: 25px;
            color: white;
        }

        .przystanek {
            font-size: 18px;
            color: white;
            text-align: left;
        }

        th {
            background-color: black;
            color: white;
        }

        #lineName {
            width: 70px;
            font-size: 30px;
        }

        #arrows {
            font-size: 28px;
            color: white;
        }

        #way {
            color: white;
            text-align: left;
            width: 350px;
        }
        th.rotate {
            background-color: white;
            height: 140px;
            white-space: nowrap;
        }

        #test {
            -webkit-transform: rotate(315deg) translate(-17px,54px);
            width: 30px;
        }
        
        th.rotate>div>span {
        border-bottom: 1px solid #ccc;
        padding: 4px 15px;
        color: black;
        }
        
        th.arrow{
            width: 40px;
            text-align: center;
            border-radius: 2px;
        }
        .ar{
            padding-right: 10px;
            width: 22px;
        }
        #first{
            background-color: white;
        }
        #przys{
            border-collapse: separate;
            border-spacing: 0px;
        }
        #firstb{
            border-radius: 5px 0px 0px 5px;
        }
        #lastb{
            border-radius: 0px 5px 5px 0px;
        }
        th.time{
            background-color: white;
            color: black;
            font-size: 30px;
            padding: 4px;
        }
        #period{
            background-color: rgb(187,188,182);
            width: 938px;
            font-size: 20px;
            font-weight: bold;
            margin: 2px;
            
        }
        sup{
            padding: 2px;
            font-size: 25px;
        }
        #selected{
            background-color: yellow;
            border-radius: 10px;
        }
    </style>
</head>
<body>
    <table>
        <tr>
            <th id='lineName' style='font-family: MS PGothic'>
                710
            </th>
            <th>
                <div class='przystanek' style='font-family: MS PGothic'>
                    &nbsp przystanek: 
                    <br> 
                </div> 
                <span class='CityBusStop' id='city' style='font-family: MS PGothic'>
                    &nbsp;
                    Knurów
                    <span id='busstop'>
                    Wojska Polskiego
                    </span> 
                    <span id = 'arrows' style='font-family: Bahnschrift Condensed'> 
                        &nbsp;&nbsp;> >&nbsp;&nbsp;
                    </span> 
                    <br>
                </span>
            </th>
            <th>
                <div class='przystanek' style='font-family: MS PGothic'>&nbsp kierunek: 
                </div> 
                <div class='CityBusStop' id='way' style='font-family: MS PGothic'>
                    &nbsp;
                    Jednokierunkowy
                    <span id='arrows'> &nbsp; 
                    </span> <br>
                </div>
            </th>
        </tr>
    </table><br><br>
    <br>

    <table id = 'przys'>
        <tr>
            <th class='rotate'>
                <div id='test'><span style = 'font-family: MS PGothic' > Plac Piastów, Gliwice</span></div>
            </th>
            <th class='rotate'>
                <div id='test'><span style = 'font-family: MS PGothic' > Strzody, Gliwice</span></div>
            </th>
        </tr>
        <tr>
            <th class='ar' id='first'>
                <div><span></span></div>
            </th>
            <th class='ar' id='firstb'>
                <div><span>></span></div>
            </th>
            <th class='ar' id='lastb'>
                <div><span>></span></div>
            </th>
        </tr>
    </table>
    <br>
    <br>
    
    <table>
        <tr>
            <p id = 'period' style='font-family: Arial'>Od Poniedziałku do Piątku</p>
        </tr>
        <tr>
           <th class='time' style='font-family: MS PGothic'>
            5<sup>13</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            6<sup>03</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            7<sup>08</sup><sup>38</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            8<sup>08</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            9<sup>08</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            10<sup>08</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            11<sup>08</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            12<sup>08</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            13<sup>08</sup>
            </th>
                    <th class='time' style='font-family: MS PGothic'>
            14<sup>08</sup><sup>58</sup>
            </th>
            
        </tr>
        <tr>

            <th class='time' style='font-family: MS PGothic'>
            15<sup>38</sup>
            </th>
            <th class='time' style='font-family: MS PGothic'>
            16<sup>38</sup>&nbsp;
            </th><th class='time' style='font-family: MS PGothic'>
            17<sup>13</sup><sup>53</sup>&nbsp;
            </th>
            <th class='time' style='font-family: MS PGothic'>
            18<sup>33</sup>&nbsp;
            </th>
            <th class='time' style='font-family: MS PGothic'>
            19<sup>27</sup>&nbsp;
            </th><th class='time' style='font-family: MS PGothic'>
            20<sup>07</sup>&nbsp;
            </th>
            <th class='time' style='font-family: MS PGothic'>
            21<sup>07</sup><sup>37</sup>&nbsp;
            </th>
            <th class='time' style='font-family: MS PGothic'>
            22<sup>05</sup><sup>27</sup>&nbsp;
            </th>
        </tr>
    </table>
</body>
</html>
");


            Pdf.SaveAs("rotated1.pdf");
        }
    }
}
