using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Fillcombo();
			//Fillcombo2();
			//Fillcombo3();
			pictureBox1.Controls.Add(pictureBox2);
			pictureBox1.BackColor = Color.Transparent;
			pictureBox2.Controls.Add(pictureBox3);
			pictureBox2.Location = new Point(0, 0);
			pictureBox2.BackColor = Color.Transparent;
			pictureBox3.Location = new Point(0, 0);
			pictureBox3.BackColor = Color.Transparent;
			chart1.ChartAreas[0].AxisX.Interval = 0.5;
		}
        void Fillcombo()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=admin";
            string Query = "select * from project3.provincies_totaal; ";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string sName = myReader.GetString("Provincie");
                    comboBox2.Items.Add(sName);
                    comboBox3.Items.Add(sName);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=admin;database=project3";
            string Query = "select ROUND(misdrijven_2015, 0), ROUND(misdrijven_2016), ROUND(bevolking_2015, 0), ROUND(bevolking_2016) from misdrijven_2015_2016 INNER JOIN provincies_totaal ON provincies_totaal.provincie = misdrijven_2015_2016.provincies where provincies = '" + comboBox2.Text + "' LIMIT 0, 1";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            
            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    List<int> yValues = new List<int>();
                    int count = myReader.FieldCount;
                    while (myReader.Read())
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            yValues.Add(Int32.Parse(myReader.GetString(i)));
                            Console.WriteLine(myReader.GetValue(i));
                        }
                    }
                    string[] xValues = {"Misdrijven_2015", "Misdrijven_2016", "Bevolking_2015", "Bevolking_2016" };
                    //string[] xValues2 = {"Misdrijven_2016", "Bevolking_2016" };
                    chart1.Series[0].Points.DataBindXY(xValues, yValues);
                    //Chart1.Series[1].Points.DataBindXY(xValues2, yValues);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
			List<string> drenthe = new List<string>() { "Drenthe" };
			List<string> flevoland = new List<string>() { "Flevoland" };
			List<string> friesland = new List<string>() { "Friesland" };
			List<string> gelderland = new List<string>() { "Gelderland" };
			List<string> groningen = new List<string>() { "Groningen" };
			List<string> limburg = new List<string>() { "Limburg" };
			List<string> noordbrabent = new List<string>() { "Noord-Brabant" };
			List<string> noordholland = new List<string>() { "Noord-Holland" };
			List<string> overijssel = new List<string>() { "Overijssel" };
			List<string> utrecht = new List<string>() { "Utrecht" };
			List<string> zeeland = new List<string>() { "Zeeland" };
			List<string> zuidholland = new List<string>() { "Zuid-Holland" };

			if (drenthe.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Drenthe-Dark.png");
				pictureBox2.Image = image;
			}
			if (flevoland.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Flevoland-Dark.png");
				pictureBox2.Image = image;
			}
			if (gelderland.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Gelderland-Dark.png");
				pictureBox2.Image = image;
			}
			if (groningen.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Groningen-Dark.png");
				pictureBox2.Image = image;
			}
			if (noordbrabent.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Noord-Brabant-Dark.png");
				pictureBox2.Image = image;
			}
			if (noordholland.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Noord-Holland-Dark.png");
				pictureBox2.Image = image;
			}
			if (overijssel.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Overijssel-Dark.png");
				pictureBox2.Image = image;
			}
			if (utrecht.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Utrecht-Dark.png");
				pictureBox2.Image = image;
			}
			if (zeeland.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Zeeland-Dark.png");
				pictureBox2.Image = image;
			}
			if (zuidholland.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Zuid-Holland-Dark.png");
				pictureBox2.Image = image;
			}
			if (friesland.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Friesland-Dark.png");
				pictureBox2.Image = image;
			}
			if (limburg.Any(r => r == comboBox2.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Limburg-Dark.png");
				pictureBox2.Image = image;
			}
			else
			{

			}
		}

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=admin;database=project3";
            string Query = "select ROUND(misdrijven_2015, 0), ROUND(misdrijven_2016), ROUND(bevolking_2015, 0), ROUND(bevolking_2016) from misdrijven_2015_2016 INNER JOIN provincies_totaal ON provincies_totaal.provincie = misdrijven_2015_2016.provincies where provincies = '" + comboBox3.Text + "' LIMIT 0, 1";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;


            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    List<int> yValues = new List<int>();
                    int count = myReader.FieldCount;
                    while (myReader.Read())
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            yValues.Add(Int32.Parse(myReader.GetString(i)));
                            Console.WriteLine(myReader.GetValue(i));
                        }
                    }
                    string[] xValues = { "Misdrijven_2015", "Misdrijven_2016", "Bevolking_2015", "Bevolking_2016" };
                    chart2.Series[0].Points.DataBindXY(xValues, yValues);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
			List<string> drenthe = new List<string>() { "Drenthe" };
			List<string> flevoland = new List<string>() { "Flevoland" };
			List<string> friesland = new List<string>() { "Friesland" };
			List<string> gelderland = new List<string>() { "Gelderland" };
			List<string> groningen = new List<string>() { "Groningen" };
			List<string> limburg = new List<string>() { "Limburg" };
			List<string> noordbrabent = new List<string>() { "Noord-Brabant" };
			List<string> noordholland = new List<string>() { "Noord-Holland" };
			List<string> overijssel = new List<string>() { "Overijssel" };
			List<string> utrecht = new List<string>() { "Utrecht" };
			List<string> zeeland = new List<string>() { "Zeeland" };
			List<string> zuidholland = new List<string>() { "Zuid-Holland" };


			if (drenthe.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Drenthe-Light.png");
				pictureBox3.Image = image;
			}
			if (flevoland.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Flevoland-Light.png");
				pictureBox3.Image = image;
			}
			if (gelderland.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Gelderland-Medium.png");
				pictureBox3.Image = image;
			}
			if (groningen.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Groningen-Light.png");
				pictureBox3.Image = image;
			}
			if (noordbrabent.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Noord-Brabant-Light.png");
				pictureBox3.Image = image;
			}
			if (noordholland.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Noord-Holland-Light.png");
				pictureBox3.Image = image;
			}
			if (overijssel.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Overijssel-Light.png");
				pictureBox3.Image = image;
			}
			if (utrecht.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Utrecht-Light.png");
				pictureBox3.Image = image;
			}
			if (zeeland.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Zeeland-Light.png");
				pictureBox3.Image = image;
			}
			if (zuidholland.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Zuid-Holland-Light.png");
				pictureBox3.Image = image;
			}
			if (friesland.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Friesland-Light.png");
				pictureBox3.Image = image;
			}
			if (limburg.Any(r => r == comboBox3.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Limburg-Light.png");
				pictureBox3.Image = image;
			}
			else
			{

			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=admin";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * project3.provincies_totaal ;", myConn);
                myDataAdapter.SelectCommand = new MySqlCommand("select * project3.misdrijven_2015_2016;", myConn);
                //myDataAdapter.SelectCommand = new MySqlCommand("select * project3.misdrijf_2016_gemeente;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                MessageBox.Show("Connected");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
