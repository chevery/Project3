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

namespace Project3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Fillcombo();
			Fillcombo3();
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
			string Query = "select * from project3.gemeentemisdrijven; ";
			MySqlConnection myConn = new MySqlConnection(myConnection);
			MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
			MySqlDataReader myReader;
			try
			{
				myConn.Open();
				myReader = cmdDatabase.ExecuteReader();

				while (myReader.Read())
				{

					string sName = myReader.GetString("Gemeenten");
					comboBox1.Items.Add(sName);

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		void Fillcombo3()
		{
			string myConnection = "datasource=localhost;port=3306;username=root;password=admin";
			string Query = "select * from project3.gemeentemisdrijven; ";
			MySqlConnection myConn = new MySqlConnection(myConnection);
			MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
			MySqlDataReader myReader;
			try
			{
				myConn.Open();
				myReader = cmdDatabase.ExecuteReader();

				while (myReader.Read())
				{

					string sName = myReader.GetString("Gemeenten");
					comboBox3.Items.Add(sName);

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}


		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			string constring = "datasource=localhost;port=3306;username=root;password=admin";
			string Query = "select * from project3.gemeentemisdrijven where Gemeenten = '" + comboBox1.Text + "' LIMIT 0, 1";
			MySqlConnection conDataBase = new MySqlConnection(constring);
			MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
			MySqlDataReader myReader;

			try
			{
				conDataBase.Open();
				myReader = cmdDataBase.ExecuteReader();
				if (myReader.HasRows)
				{
					List<int> yValues = new List<int>();
					int count = myReader.FieldCount;
					while (myReader.Read())
					{

						for (int i = 1; i < 19; i++)
						{
							yValues.Add(Int32.Parse(myReader.GetString(i)));
							Console.WriteLine(myReader.GetValue(i));
						}


					}

					string[] xValues = {"Bedreigingen","Brand/ontploffingen", "Diefstal van motorvoertuigen", "Diefstal uit/vanaf motorvoertuigen", "Diefstal/inbraak bedrijven/instellingen", "Diefstal/inbraak garage/schuur/tuinhuis", "Drugshandel", "HIC: Diefstal/inbraak woning, voltooid", "HIC: Diefstal/inbraak woning, pogingen", "HIC: Geweldsmisdrijven", "HIC: Straatroof", "HIC: Overvallen", "Huisvredebreuk","Huisvredebreuk",
"Mishandeling","Openlijk geweld (persoon)","Vernieling cq. zaakbeschadiging","Wapenhandel" };
					chart1.Series[1].Points.DataBindXY(xValues, yValues);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			List<string> drenthe = new List<string>() { "Aa en Hunze", "Assen", "Borger - Odoorn", "Coevorden", "Emmen", "Hoogeveen", "Meppel", "Midden - Drenthe", "Noordenveld", "Tynaarlo", "Westerveld", "De Wolden" };
			List<string> flevoland = new List<string>() { "Almere", "Dronten", "Lelystad", "Noordoostpolder", "Urk", "Zeewolde" };
			List<string> friesland = new List<string>() { "Achtkarspelen", "Ameland", "Dantumadeel", "Dongeradeel", "Ferwerderadeel", "De Friese Meren", "Harlingen", "Heerenveen", "Kollumerland en Nieuwkruisland", "Leeuwarden", "Ooststellingwerf", "Opsterland", "Schiermonnikoog", "Smallingerland", "Súdwest-Fryslân", "Terschelling", "Tietjerksteradeel", "Vlieland", "Waadhoeke", "Weststellingwerf" };
			List<string> gelderland = new List<string>() { "Aalten", "Apeldoorn", "Arnhem", "Barneveld", "Berg en Dal", "Berkelland", "Beuningen", "Bronckhorst", "Brummen", "Buren", "Culemborg", "Doesburg", "Doetinchem", "Druten", "Duiven", "Ede", "Elburg", "Epe", "Ermelo", "Geldermalsen", "Harderwijk", "Hattem", "Heerde", "Heumen", "Lingewaal", "Lingewaard", "Lochem", "Maasdriel", "Montferland", "Neder-Betuwe", "Neerijnen", "Nijkerk", "Nijmegen", "Nunspeet", "Oldebroek", "Oost Gelre", "Oude IJsselstreek", "Overbetuwe", "Putten", "Renkum", "Rheden", "Rozendaal", "Scherpenzeel", "Tiel", "Voorst", "Wageningen", "West Maas en Waal", "Westervoort", "Wijchen", "Winterswijk", "Zaltbommel", "Zevenaar", "Zutphen" };
			List<string> groningen = new List<string>() { "Appingedam", "Bedum", "Ten Boer", "Delfzijl", "Eemsmond", "Groningen", "Grootegast", "Haren", "Leek", "Loppersum", "De Marne", "Marum", "Midden-Groningen", "Oldambt", "Pekela", "Stadskanaal", "Veendam", "Westerwolde", "Winsum", "Zuidhorn" };
			List<string> limburg = new List<string>() { "Beek (L.)", "Beesel", "Bergen", "Brunssum", "Echt-Susteren", "Eijsden-Margraten", "Gennep", "Gulpen-Wittem", "Heerlen", "Horst aan de Maas", "Kerkrade", "Landgraaf", "Leudal", "Maasgouw", "Maastricht", "Meerssen", "Mook en Middelaar", "Nederweert", "Nuth", "Onderbanken", "Peel en Maas", "Roerdalen", "Roermond", "Schinnen", "Simpelveld", "Sittard-Geleen", "Stein", "Vaals", "Valkenburg aan de Geul", "Venlo", "Venray", "Voerendaal", "Weert" };
			List<string> noordbrabent = new List<string>() { "Aalburg", "Alphen-Chaam", "Asten", "Baarle-Nassau", "Bergeijk", "Bergen op Zoom", "Bernheze", "Best", "Bladel", "Boekel", "Boxmeer", "Boxtel", "Breda", "Cranendonck", "Cuijk", "Deurne", "Dongen", "Drimmelen", "Eersel", "Eindhoven", "Etten-Leur", "Geertruidenberg", "Geldrop-Mierlo", "Gemert-Bakel", "Gilze en Rijen", "Goirle", "Grave", "Haaren", "Halderberge", "Heeze-Leende", "Helmond", "'s-Hertogenbosch", "Heusden", "Hilvarenbeek", "Laarbeek", "Landerd", "Loon op Zand", "Meierijstad", "Mill en Sint Hubert", "Moerdijk", "Nuenen, Gerwen en Nederwetten", "Oirschot", "Oisterwijk", "Oosterhout", "Oss", "Reusel-De Mierden", "Roosendaal", "Rucphen", "Sint Anthonis", "Sint-Michielsgestel", "Someren", "Son en Breugel", "Steenbergen", "Tilburg", "Uden", "Valkenswaard", "Veldhoven", "Vught", "Waalre", "Waalwijk", "Werkendam", "Woensdrecht", "Woudrichem", "Zundert" };
			List<string> noordholland = new List<string>() { "Aalsmeer", "Alkmaar", "Amstelveen", "Amsterdam", "Beemster", "Bergen", "Beverwijk", "Blaricum", "Bloemendaal", "Castricum", "Den Helder", "Diemen", "Drechterland", "Edam-Volendam", "Enkhuizen", "Gooise Meren", "Haarlem", "Haarlemmerliede en Spaarnwoude", "Haarlemmermeer", "Heemskerk", "Heemstede", "Heerhugowaard", "Heiloo", "Hilversum", "Hollands Kroon", "Hoorn", "Huizen", "Koggenland", "Landsmeer", "Langedijk", "Laren", "Medemblik", "Oostzaan", "Opmeer", "Ouder-Amstel", "Purmerend", "Schagen", "Stede Broec", "Texel", "Uitgeest", "Uithoorn", "Velsen", "Waterland", "Weesp", "Wijdemeren", "Wormerland", "Zaanstad", "Zandvoort" };
			List<string> overijssel = new List<string>() { "Almelo", "Borne", "Dalfsen", "Deventer", "Dinkelland", "Enschede", "Haaksbergen", "Hardenberg", "Hellendoorn", "Hengelo", "Hof van Twente", "Kampen", "Losser", "Oldenzaal", "Olst-Wijhe", "Ommen", "Raalte", "Rijssen-Holten", "Staphorst", "Steenwijkerland", "Tubbergen", "Twenterand", "Wierden", "Zwartewaterland", "Zwolle" };
			List<string> utrecht = new List<string>() { "Amersfoort", "Baarn", "De Bilt", "Bunnik", "Bunschoten", "Eemnes", "Houten", "IJsselstein", "Leusden", "Lopik", "Montfoort", "Nieuwegein", "Oudewater", "Renswoude", "Rhenen", "De Ronde Venen", "Soest", "Stichtse Vecht", "Utrecht", "Utrechtse Heuvelrug", "Veenendaal", "Vianen", "Wijk bij Duurstede", "Woerden", "Woudenberg", "Zeist" };
			List<string> zeeland = new List<string>() { "Borsele", "Goes", "Hulst", "Kapelle", "Middelburg", "Noord-Beveland", "Reimerswaal", "Schouwen-Duiveland", "Sluis", "Terneuzen", "Tholen", "Veere", "Vlissingen" };
			List<string> zuidholland = new List<string>() { "Alblasserdam", "Albrandswaard", "Alphen aan den Rijn", "Barendrecht", "Binnenmaas", "Bodegraven-Reeuwijk", "Brielle", "Capelle aan den IJssel", "Cromstrijen", "Delft", "Den Haag ('s Gravenhage)", "Dordrecht", "Giessenlanden", "Goeree-Overflakkee", "Gorinchem", "Gouda", "Hardinxveld-Giessendam", "Hellevoetsluis", "Hendrik-Ido-Ambacht", "Hillegom", "Kaag en Braassem", "Katwijk", "Korendijk", "Krimpen aan den IJssel", "Krimpenerwaard", "Lansingerland", "Leerdam", "Leiden", "Leiderdorp", "Leidschendam-Voorburg", "Lisse", "Maassluis", "Midden-Delfland", "Molenwaard", "Nieuwkoop", "Nissewaard", "Noordwijk", "Noordwijkerhout", "Oegstgeest", "Oud-Beijerland", "Papendrecht", "Pijnacker-Nootdorp", "Ridderkerk", "Rijswijk", "Rotterdam", "Schiedam", "Sliedrecht", "Strijen", "Teylingen", "Vlaardingen", "Voorschoten", "Waddinxveen", "Wassenaar", "Westland", "Westvoorne", "Zederik", "Zoetermeer", "Zoeterwoude", "Zuidplas", "Zwijndrecht" };


			if (drenthe.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Drenthe-Dark.png");
				pictureBox2.Image = image;
			}
			if (flevoland.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Flevoland-Dark.png");
				pictureBox2.Image = image;
			}
			if (gelderland.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Gelderland-Dark.png");
				pictureBox2.Image = image;
			}
			if (groningen.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Groningen-Dark.png");
				pictureBox2.Image = image;
			}
			if (noordbrabent.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Noord-Brabant-Dark.png");
				pictureBox2.Image = image;
			}
			if (noordholland.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Noord-Holland-Dark.png");
				pictureBox2.Image = image;
			}
			if (overijssel.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Overijssel-Dark.png");
				pictureBox2.Image = image;
			}
			if (utrecht.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Utrecht-Dark.png");
				pictureBox2.Image = image;
			}
			if (zeeland.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Zeeland-Dark.png");
				pictureBox2.Image = image;
			}
			if (zuidholland.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Zuid-Holland-Dark.png");
				pictureBox2.Image = image;
			}
			if (friesland.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Friesland-Dark.png");
				pictureBox2.Image = image;
				MessageBox.Show("gelukt");
			}
			if (limburg.Any(r => r == comboBox1.SelectedItem.ToString()))
			{
				Image image = Image.FromFile(@"C:\Users\Claudio\Dropbox\Informatica\Project\project 3\landkaart\Limburg-Dark.png");
				pictureBox2.Image = image;
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
				myDataAdapter.SelectCommand = new MySqlCommand("select * project.gemeentemisdrijven ;", myConn);
				myDataAdapter.SelectCommand = new MySqlCommand("select * project.gemeentenreactie;", myConn);
				myDataAdapter.SelectCommand = new MySqlCommand("select * project.gemeentenaantal;", myConn);
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string myConnection = "datasource=localhost;port=3306;username=root;password=admin";
			MySqlConnection myConn = new MySqlConnection(myConnection);
			MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
			MySqlCommand cmdDatabase = new MySqlCommand("select * from project3.gemeentemisdrijven; & select * from project3.misdrijven;", myConn);
			MySqlDataReader myReader;
			try
			{
				myConn.Open();
				myReader = cmdDatabase.ExecuteReader();

				while (myReader.Read())
				{

					this.chart1.Series["Gemeenten"].Points.AddXY(myReader.GetString("Gemeenten").ToString(), myReader.GetInt32("Bedreigingen").ToString());

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}



		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			

			
		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form4 f = new Form4();
			f.ShowDialog();
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			string constring = "datasource=localhost;port=3306;username=root;password=admin";
			string Query = "select * from project3.gemeentemisdrijven where Gemeenten = '" + comboBox3.Text + "' LIMIT 0, 1";
			MySqlConnection conDataBase = new MySqlConnection(constring);
			MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
			MySqlDataReader myReader;

			try
			{
				conDataBase.Open();
				myReader = cmdDataBase.ExecuteReader();
				if (myReader.HasRows)
				{
					List<int> yValues = new List<int>();
					int count = myReader.FieldCount;
					while (myReader.Read())
					{

						for (int i = 1; i < 19; i++)
						{
							yValues.Add(Int32.Parse(myReader.GetString(i)));
							Console.WriteLine(myReader.GetValue(i));
						}


					}

					string[] xValues = {"Bedreigingen","Brand/ontploffingen", "Diefstal van motorvoertuigen", "Diefstal uit/vanaf motorvoertuigen", "Diefstal/inbraak bedrijven/instellingen", "Diefstal/inbraak garage/schuur/tuinhuis", "Drugshandel", "HIC: Diefstal/inbraak woning, voltooid", "HIC: Diefstal/inbraak woning, pogingen", "HIC: Geweldsmisdrijven", "HIC: Straatroof", "HIC: Overvallen", "Huisvredebreuk","Huisvredebreuk",
"Mishandeling","Openlijk geweld (persoon)","Vernieling cq. zaakbeschadiging","Wapenhandel" };
					chart1.Series[0].Points.DataBindXY(xValues, yValues);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			List<string> drenthe = new List<string>() { "Aa en Hunze", "Assen", "Borger - Odoorn", "Coevorden", "Emmen", "Hoogeveen", "Meppel", "Midden - Drenthe", "Noordenveld", "Tynaarlo", "Westerveld", "De Wolden" };
			List<string> flevoland = new List<string>() { "Almere", "Dronten", "Lelystad", "Noordoostpolder", "Urk", "Zeewolde" };
			List<string> friesland = new List<string>() { "Achtkarspelen", "Ameland", "Dantumadeel", "Dongeradeel", "Ferwerderadeel", "De Friese Meren", "Harlingen", "Heerenveen", "Kollumerland en Nieuwkruisland", "Leeuwarden", "Ooststellingwerf", "Opsterland", "Schiermonnikoog", "Smallingerland", "Súdwest-Fryslân", "Terschelling", "Tietjerksteradeel", "Vlieland", "Waadhoeke", "Weststellingwerf" };
			List<string> gelderland = new List<string>() { "Aalten", "Apeldoorn", "Arnhem", "Barneveld", "Berg en Dal", "Berkelland", "Beuningen", "Bronckhorst", "Brummen", "Buren", "Culemborg", "Doesburg", "Doetinchem", "Druten", "Duiven", "Ede", "Elburg", "Epe", "Ermelo", "Geldermalsen", "Harderwijk", "Hattem", "Heerde", "Heumen", "Lingewaal", "Lingewaard", "Lochem", "Maasdriel", "Montferland", "Neder-Betuwe", "Neerijnen", "Nijkerk", "Nijmegen", "Nunspeet", "Oldebroek", "Oost Gelre", "Oude IJsselstreek", "Overbetuwe", "Putten", "Renkum", "Rheden", "Rozendaal", "Scherpenzeel", "Tiel", "Voorst", "Wageningen", "West Maas en Waal", "Westervoort", "Wijchen", "Winterswijk", "Zaltbommel", "Zevenaar", "Zutphen" };
			List<string> groningen = new List<string>() { "Appingedam", "Bedum", "Ten Boer", "Delfzijl", "Eemsmond", "Groningen", "Grootegast", "Haren", "Leek", "Loppersum", "De Marne", "Marum", "Midden-Groningen", "Oldambt", "Pekela", "Stadskanaal", "Veendam", "Westerwolde", "Winsum", "Zuidhorn" };
			List<string> limburg = new List<string>() { "Beek (L.)", "Beesel", "Bergen", "Brunssum", "Echt-Susteren", "Eijsden-Margraten", "Gennep", "Gulpen-Wittem", "Heerlen", "Horst aan de Maas", "Kerkrade", "Landgraaf", "Leudal", "Maasgouw", "Maastricht", "Meerssen", "Mook en Middelaar", "Nederweert", "Nuth", "Onderbanken", "Peel en Maas", "Roerdalen", "Roermond", "Schinnen", "Simpelveld", "Sittard-Geleen", "Stein", "Vaals", "Valkenburg aan de Geul", "Venlo", "Venray", "Voerendaal", "Weert" };
			List<string> noordbrabent = new List<string>() { "Aalburg", "Alphen-Chaam", "Asten", "Baarle-Nassau", "Bergeijk", "Bergen op Zoom", "Bernheze", "Best", "Bladel", "Boekel", "Boxmeer", "Boxtel", "Breda", "Cranendonck", "Cuijk", "Deurne", "Dongen", "Drimmelen", "Eersel", "Eindhoven", "Etten-Leur", "Geertruidenberg", "Geldrop-Mierlo", "Gemert-Bakel", "Gilze en Rijen", "Goirle", "Grave", "Haaren", "Halderberge", "Heeze-Leende", "Helmond", "'s-Hertogenbosch", "Heusden", "Hilvarenbeek", "Laarbeek", "Landerd", "Loon op Zand", "Meierijstad", "Mill en Sint Hubert", "Moerdijk", "Nuenen, Gerwen en Nederwetten", "Oirschot", "Oisterwijk", "Oosterhout", "Oss", "Reusel-De Mierden", "Roosendaal", "Rucphen", "Sint Anthonis", "Sint-Michielsgestel", "Someren", "Son en Breugel", "Steenbergen", "Tilburg", "Uden", "Valkenswaard", "Veldhoven", "Vught", "Waalre", "Waalwijk", "Werkendam", "Woensdrecht", "Woudrichem", "Zundert" };
			List<string> noordholland = new List<string>() { "Aalsmeer", "Alkmaar", "Amstelveen", "Amsterdam", "Beemster", "Bergen", "Beverwijk", "Blaricum", "Bloemendaal", "Castricum", "Den Helder", "Diemen", "Drechterland", "Edam-Volendam", "Enkhuizen", "Gooise Meren", "Haarlem", "Haarlemmerliede en Spaarnwoude", "Haarlemmermeer", "Heemskerk", "Heemstede", "Heerhugowaard", "Heiloo", "Hilversum", "Hollands Kroon", "Hoorn", "Huizen", "Koggenland", "Landsmeer", "Langedijk", "Laren", "Medemblik", "Oostzaan", "Opmeer", "Ouder-Amstel", "Purmerend", "Schagen", "Stede Broec", "Texel", "Uitgeest", "Uithoorn", "Velsen", "Waterland", "Weesp", "Wijdemeren", "Wormerland", "Zaanstad", "Zandvoort" };
			List<string> overijssel = new List<string>() { "Almelo", "Borne", "Dalfsen", "Deventer", "Dinkelland", "Enschede", "Haaksbergen", "Hardenberg", "Hellendoorn", "Hengelo", "Hof van Twente", "Kampen", "Losser", "Oldenzaal", "Olst-Wijhe", "Ommen", "Raalte", "Rijssen-Holten", "Staphorst", "Steenwijkerland", "Tubbergen", "Twenterand", "Wierden", "Zwartewaterland", "Zwolle" };
			List<string> utrecht = new List<string>() { "Amersfoort", "Baarn", "De Bilt", "Bunnik", "Bunschoten", "Eemnes", "Houten", "IJsselstein", "Leusden", "Lopik", "Montfoort", "Nieuwegein", "Oudewater", "Renswoude", "Rhenen", "De Ronde Venen", "Soest", "Stichtse Vecht", "Utrecht", "Utrechtse Heuvelrug", "Veenendaal", "Vianen", "Wijk bij Duurstede", "Woerden", "Woudenberg", "Zeist" };
			List<string> zeeland = new List<string>() { "Borsele", "Goes", "Hulst", "Kapelle", "Middelburg", "Noord-Beveland", "Reimerswaal", "Schouwen-Duiveland", "Sluis", "Terneuzen", "Tholen", "Veere", "Vlissingen" };
			List<string> zuidholland = new List<string>() { "Alblasserdam", "Albrandswaard", "Alphen aan den Rijn", "Barendrecht", "Binnenmaas", "Bodegraven-Reeuwijk", "Brielle", "Capelle aan den IJssel", "Cromstrijen", "Delft", "Den Haag ('s Gravenhage)", "Dordrecht", "Giessenlanden", "Goeree-Overflakkee", "Gorinchem", "Gouda", "Hardinxveld-Giessendam", "Hellevoetsluis", "Hendrik-Ido-Ambacht", "Hillegom", "Kaag en Braassem", "Katwijk", "Korendijk", "Krimpen aan den IJssel", "Krimpenerwaard", "Lansingerland", "Leerdam", "Leiden", "Leiderdorp", "Leidschendam-Voorburg", "Lisse", "Maassluis", "Midden-Delfland", "Molenwaard", "Nieuwkoop", "Nissewaard", "Noordwijk", "Noordwijkerhout", "Oegstgeest", "Oud-Beijerland", "Papendrecht", "Pijnacker-Nootdorp", "Ridderkerk", "Rijswijk", "Rotterdam", "Schiedam", "Sliedrecht", "Strijen", "Teylingen", "Vlaardingen", "Voorschoten", "Waddinxveen", "Wassenaar", "Westland", "Westvoorne", "Zederik", "Zoetermeer", "Zoeterwoude", "Zuidplas", "Zwijndrecht" };


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
	}
}
