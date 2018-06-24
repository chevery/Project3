namespace Project_3
{
	partial class Form5
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(746, 659);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(1206, 659);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// chart1
			// 
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(567, 22);
			this.chart1.Name = "chart1";
			series5.ChartArea = "ChartArea1";
			series5.Color = System.Drawing.SystemColors.MenuHighlight;
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(442, 629);
			this.chart1.TabIndex = 5;
			this.chart1.Text = "chart1";
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// chart2
			// 
			chartArea6.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea6);
			legend6.Name = "Legend1";
			this.chart2.Legends.Add(legend6);
			this.chart2.Location = new System.Drawing.Point(1028, 22);
			this.chart2.Name = "chart2";
			series6.ChartArea = "ChartArea1";
			series6.Legend = "Legend1";
			series6.Name = "Series1";
			this.chart2.Series.Add(series6);
			this.chart2.Size = new System.Drawing.Size(420, 631);
			this.chart2.TabIndex = 6;
			this.chart2.Text = "chart2";
			this.chart2.Click += new System.EventHandler(this.chart2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(28, 22);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(521, 629);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 14;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(28, 22);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(521, 629);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(28, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(521, 629);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1484, 701);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form5";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

