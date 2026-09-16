using System;
using System.Windows.Forms;

namespace Experiment_05
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        ComboBox comboBox1;
        RadioButton radioButton1;
        RadioButton radioButton2;
        Button button1;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Student Details";
            this.Width = 400;
            this.Height = 350;

            Label nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Left = 30;
            nameLabel.Top = 30;
            nameLabel.Width = 100;
            this.Controls.Add(nameLabel);

            textBox1 = new TextBox();
            textBox1.Left = 140;
            textBox1.Top = 25;
            textBox1.Width = 180;
            this.Controls.Add(textBox1);

            Label deptLabel = new Label();
            deptLabel.Text = "Department:";
            deptLabel.Left = 30;
            deptLabel.Top = 75;
            deptLabel.Width = 100;
            this.Controls.Add(deptLabel);

            comboBox1 = new ComboBox();
            comboBox1.Left = 140;
            comboBox1.Top = 70;
            comboBox1.Width = 180;

            comboBox1.Items.Add("Information Technology");
            comboBox1.Items.Add("Computer Science");
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Mechanical");
            comboBox1.Items.Add("Civil");

            comboBox1.SelectedIndex = 0;
            this.Controls.Add(comboBox1);

            Label genderLabel = new Label();
            genderLabel.Text = "Gender:";
            genderLabel.Left = 30;
            genderLabel.Top = 120;
            genderLabel.Width = 100;
            this.Controls.Add(genderLabel);

            radioButton1 = new RadioButton();
            radioButton1.Text = "Male";
            radioButton1.Left = 140;
            radioButton1.Top = 115;
            this.Controls.Add(radioButton1);

            radioButton2 = new RadioButton();
            radioButton2.Text = "Female";
            radioButton2.Left = 210;
            radioButton2.Top = 115;
            this.Controls.Add(radioButton2);

            button1 = new Button();
            button1.Text = "Show Details";
            button1.Left = 140;
            button1.Top = 170;
            button1.Width = 120;
            button1.Click += button1_Click;
            this.Controls.Add(button1);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            string name = textBox1.Text;

            string department =
                comboBox1.SelectedItem?.ToString() ?? "";

            string gender = "";

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not Selected";
            }

            string message =
                "Student Details\n" +
                "----------------------\n" +
                "Name : " + name + "\n" +
                "Department : " + department + "\n" +
                "Gender : " + gender;

            MessageBox.Show(
                message,
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}