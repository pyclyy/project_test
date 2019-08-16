using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test_butotn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  AddOKCancelButtons();
        }

        // Create three buttons and place them on a form using 
        // several size and location related properties. 
        private void AddOKCancelButtons()
        {

            // Set the button size and location using 
            // the Size and Location properties.
            Button buttonOK = new Button();
            buttonOK.Location = new Point(136, 248);
            buttonOK.Size = new Size(75, 25);
            // Set the Text property and make the 
            // button the form's default button. 
            buttonOK.Text = "&OK";
            this.AcceptButton = buttonOK;

            // Set the button size and location using the Top, 
            // Left, Width, and Height properties.
            Button buttonCancel = new Button();
            buttonCancel.Top = buttonOK.Top;
            buttonCancel.Left = buttonOK.Right + 5;
            buttonCancel.Width = buttonOK.Width;
            buttonCancel.Height = buttonOK.Height;
            // Set the Text property and make the 
            // button the form's cancel button.
            buttonCancel.Text = "&Cancel";
            this.CancelButton = buttonCancel;

            // Set the button size and location using 
            // the Bounds property.
            Button buttonHelp = new Button();
            buttonHelp.Bounds = new Rectangle(10, 10, 75, 25);
            // Set the Text property of the button.
            buttonHelp.Text = "&Help";

            // Add the buttons to the form.
            this.tabPage1.Controls.AddRange(new Control[] { buttonOK, buttonCancel, buttonHelp });
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

            AddOKCancelButtons();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
