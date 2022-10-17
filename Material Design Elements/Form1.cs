using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material_Design_Elements
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal200, Accent.Pink200, TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private DateTime dateTime;

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void materialRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            label2.Text  += serialPort1.ReadExisting();
            // this.Invoke(new EventHandler(displayData_event));
        }
        private void displayData_event(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            string time = dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
            label2.Text = time + "\t\t\t\t\t" + "this is a certified hood classic";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            materialTabControl2.SelectedIndex=0;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            materialTabControl2.SelectedIndex=1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
