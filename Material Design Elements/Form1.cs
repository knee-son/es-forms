using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Material_Design_Elements
{
    public partial class Form1 : MaterialForm
    {
        private String txt = "", light = "";
        private bool locked;
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal200, Accent.Pink200, TextShade.WHITE);

            serialPort1.DtrEnable = true;
            serialPort1.ReceivedBytesThreshold = 9;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            serialPort1.Open();
            Console.WriteLine("💩 the bullcrap just began!");
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
            txt = "";
            label2.Text = txt;
            label2.Text = serialPort1.ReadExisting();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String incoming = serialPort1.ReadExisting().ToString();
            if (incoming.Contains("unlock"))
            {
                Console.WriteLine("door unlocked!");
                locked = false;
                this.Invoke(new EventHandler(displayData_event));
            }
            else if (incoming.Contains("lock"))
            {
                Console.WriteLine("door locked!");
                locked = true;
                this.Invoke(new EventHandler(displayData_event));
            }
            else if (incoming.Contains("Light:"))
            {
                //light = incoming.Substring(' ', '%');
            }
            txt += incoming;
            SetText(txt.ToString());
        }
        private void displayData_event(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            string time = "\n\n" + dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
            label3.Text += time + " >>\t\t\t\t\t" + (locked?"Door has been locked!": "Door has been locked!");

            materialLabel2.Text = "Light: "+light;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            materialTabControl2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            materialTabControl2.SelectedIndex = 1;
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label2.Text = text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
