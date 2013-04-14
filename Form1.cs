using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ConversorCSharp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbConversor;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ComboBox cmbDe;
		private System.Windows.Forms.Button btnConverter;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Timers.Timer timer1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbConversor = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbDe = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btnConverter = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.timer1 = new System.Timers.Timer();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbConversor);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Conversor de medidas:";
			// 
			// cmbConversor
			// 
			this.cmbConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbConversor.Items.AddRange(new object[] {
															  "1 - COMPRIMENTO",
															  "2 - PESO",
															  "3 - VOLUME"});
			this.cmbConversor.Location = new System.Drawing.Point(8, 16);
			this.cmbConversor.Name = "cmbConversor";
			this.cmbConversor.Size = new System.Drawing.Size(184, 21);
			this.cmbConversor.TabIndex = 0;
			this.cmbConversor.SelectedIndexChanged += new System.EventHandler(this.cmbConversor_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbDe);
			this.groupBox2.Location = new System.Drawing.Point(8, 63);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 48);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "De:";
			// 
			// cmbDe
			// 
			this.cmbDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDe.Location = new System.Drawing.Point(8, 16);
			this.cmbDe.Name = "cmbDe";
			this.cmbDe.Size = new System.Drawing.Size(184, 21);
			this.cmbDe.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "0,00";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Location = new System.Drawing.Point(8, 119);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 48);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Valor a ser convertido:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGrid1);
			this.groupBox4.Location = new System.Drawing.Point(216, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(288, 160);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Resultado da conversão:";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dataGrid1.BackColor = System.Drawing.Color.GhostWhite;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.Lavender;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.White;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.dataGrid1.Location = new System.Drawing.Point(3, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Teal;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dataGrid1.Size = new System.Drawing.Size(282, 141);
			this.dataGrid1.TabIndex = 0;
			// 
			// btnConverter
			// 
			this.btnConverter.Location = new System.Drawing.Point(320, 184);
			this.btnConverter.Name = "btnConverter";
			this.btnConverter.Size = new System.Drawing.Size(176, 24);
			this.btnConverter.TabIndex = 6;
			this.btnConverter.Text = "Converter !";
			this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(4, 22);
			this.linkLabel1.Location = new System.Drawing.Point(16, 192);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(219, 16);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Por marciusbezerra@aol.com em C# .NET";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.SynchronizingObject = this;
			this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 222);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnConverter);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0;
			this.Text = "Conversor C# 1.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		DataSet ds;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			String[] Conversores = new String[] {"1 - COMPRIMENTO","2 - PESO","3 - VOLUME"};
			String[] De = new String[] {"1 - MILÍMETROS", "2 - CENTÍMENTROS", "3 - METROS",
										   "4 - QUILÔMETROS", "5 - POLEGADAS", "6 - JARDAS", 
										   "7 - MILHAS"};
			cmbConversor.DataSource = Conversores;
			cmbDe.DataSource = De;
			timer1.Enabled = true;
		}

		private void cmbConversor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			String[] De = new String[] {};
			switch (cmbConversor.SelectedIndex) 
			{
				case 0:
					De = new String[] {"1 - MILÍMETROS", "2 - CENTÍMENTROS", "3 - METROS",
										  "4 - QUILÔMETROS", "5 - POLEGADAS", "6 - JARDAS", 
										  "7 - MILHAS"};
					break;
				case 1:
					De = new String[] {"1 - MILIGRAMAS", "2 - GRAMAS", 
										  "3 - QUILOGRAMAS", "4 - TONELADAS", 
										  "5 - ONCAS", "6 - LIBRAS"};
					break;
				case 2:
					De = new String[] {"1 - MILILITROS", "2 - DECILITROS", 
										  "3 - LITROS", "4 - GALÃO AMERICANO", 
										  "5 - GALÃO INGLÊS", "6 - ONCA FLUÍDA"};
					break;
			};
			dataGrid1.DataSource = null;												   
			cmbDe.DataSource = De;
		}

		private void AddLinha(ref DataTable dt, string Unidade, double Valor) 
		{
			DataRow dr = dt.NewRow();
			dr["Unidade"] = Unidade;
			dr["Valor"] = Valor;
			dt.Rows.Add(dr);
		}

		private void btnConverter_Click(object sender, System.EventArgs e)
		{
			btnConverter.Enabled = false;
			try 
			{
				DataTable dt = new DataTable("Resultado das converções");
				DataColumn dc;
				dc = dt.Columns.Add("Unidade", Type.GetType("System.String"));
				dc.ReadOnly = true;
				dc = dt.Columns.Add("Valor", Type.GetType("System.Double"));
				dc.ReadOnly = true;
				ds = new DataSet("Resultado");
				ds.Tables.Add(dt);
				double ValConv;
				try 
				{
					ValConv = Convert.ToDouble(textBox1.Text);
				}
				catch (FormatException ex) 
				{
					MessageBox.Show(this,"Número digitado não é válido\n\n" + ex.Message,"Atenção");
					return;
				};
				switch (cmbConversor.SelectedIndex) 
				{
					case 0:
						switch (cmbDe.SelectedIndex) 
						{
							case 0:
								AddLinha(ref dt, "MM", ValConv);
								AddLinha(ref dt, "CM", ValConv/10);
								AddLinha(ref dt, "M", ValConv/1000);
								AddLinha(ref dt, "KM", ValConv*0.001);
								AddLinha(ref dt, "IN", ValConv*0.03937);
								AddLinha(ref dt, "YD", ValConv*0.0010936);
								AddLinha(ref dt, "MI", ValConv*0.06214);
								break;
							case 1:
								AddLinha(ref dt, "MM", ValConv*10);
								AddLinha(ref dt, "CM", ValConv);
								AddLinha(ref dt, "M", ValConv/100);
								AddLinha(ref dt, "KM", ValConv/100000);
								AddLinha(ref dt, "IN", ValConv*0.03937);
								AddLinha(ref dt, "YD", ValConv*0.0010936);
								AddLinha(ref dt, "MI", ValConv*0.00006);
								break;
							case 2:
								AddLinha(ref dt, "MM", ValConv*1000);
								AddLinha(ref dt, "CM", ValConv*100);
								AddLinha(ref dt, "M", ValConv);
								AddLinha(ref dt, "KM", ValConv*0.001);
								AddLinha(ref dt, "IN", ValConv*0.03937*1000);
								AddLinha(ref dt, "YD", ValConv*0.0010936*1000);
								AddLinha(ref dt, "MI", ValConv*0.0006214);
								break;
							case 3:
								AddLinha(ref dt, "MM", ValConv*1000*1000);
								AddLinha(ref dt, "CM", ValConv*100*1000);
								AddLinha(ref dt, "M", ValConv*1*1000);
								AddLinha(ref dt, "KM", ValConv);
								AddLinha(ref dt, "IN", ValConv*0.03937*100000);
								AddLinha(ref dt, "YD", ValConv*0.0010936*1000000);
								AddLinha(ref dt, "MI", ValConv*0.6213712);
								break;
							case 4:
								AddLinha(ref dt, "MM", ValConv*25.4);
								AddLinha(ref dt, "CM", ValConv*2.54);
								AddLinha(ref dt, "M", ValConv*0.0254);
								AddLinha(ref dt, "KM", ValConv*0.0000254);
								AddLinha(ref dt, "IN", ValConv);
								AddLinha(ref dt, "YD", (ValConv*0.001095)/0.02778);
								AddLinha(ref dt, "MI", ValConv*0.0000158);
								break;
							case 5:
								AddLinha(ref dt, "MM", ValConv*914.4);
								AddLinha(ref dt, "CM", ValConv*91.44);
								AddLinha(ref dt, "M", ValConv*0.9144);
								AddLinha(ref dt, "KM", ValConv*0.00091);
								AddLinha(ref dt, "IN", ValConv*36);
								AddLinha(ref dt, "YD", ValConv);
								AddLinha(ref dt, "MI", ValConv*0.0005);
								break;
							case 6:
								AddLinha(ref dt, "MM", ValConv*1609344);
								AddLinha(ref dt, "CM", ValConv*160934.4);
								AddLinha(ref dt, "M", ValConv*1609.344);
								AddLinha(ref dt, "KM", ValConv*1.609344);
								AddLinha(ref dt, "IN", ValConv*63360);
								AddLinha(ref dt, "YD", ValConv*1760);
								AddLinha(ref dt, "MI", ValConv);
								break;
						};
						break;
					case 1:
						switch (cmbDe.SelectedIndex) 
						{
							case 0:
								AddLinha(ref dt, "MG", ValConv);
								AddLinha(ref dt, "G", ValConv/1000);
								AddLinha(ref dt, "KG", (ValConv/1000)/1000);
								AddLinha(ref dt, "T", ((ValConv/1000)/1000)/1000);
								AddLinha(ref dt, "OZ", (ValConv/1000)*0.03527);
								AddLinha(ref dt, "LB", ((ValConv/1000)/1000)*2.205);
								break;
							case 1:
								AddLinha(ref dt, "MG", ValConv*1000);
								AddLinha(ref dt, "G", ValConv);
								AddLinha(ref dt, "KG", ValConv/1000);
								AddLinha(ref dt, "T", (ValConv/1000)/1000);
								AddLinha(ref dt, "OZ", ValConv*0.03527);
								AddLinha(ref dt, "LB", (ValConv/1000)*2.205);
								break;
							case 2:
								AddLinha(ref dt, "MG", (ValConv*1000)*1000);
								AddLinha(ref dt, "G", (ValConv)*1000);
								AddLinha(ref dt, "KG", ValConv);
								AddLinha(ref dt, "T", ValConv/1000);
								AddLinha(ref dt, "OZ", (ValConv*1000)*0.03527);
								AddLinha(ref dt, "LB", ValConv*2.205);
								break;
							case 3:
								AddLinha(ref dt, "MG", ((ValConv*1000)*1000)*1000);
								AddLinha(ref dt, "G", (ValConv*1000)*1000);
								AddLinha(ref dt, "KG", ValConv*1000);
								AddLinha(ref dt, "T", ValConv);
								AddLinha(ref dt, "OZ", ((ValConv*1000)*1000)*0.03527);
								AddLinha(ref dt, "LB", (ValConv*1000)*2.205);
								break;
							case 4:
								AddLinha(ref dt, "MG", (ValConv*1000)*28.35);
								AddLinha(ref dt, "G", ValConv*28.35);
								AddLinha(ref dt, "KG", (ValConv/1000)*28.35);
								AddLinha(ref dt, "T", ((ValConv/1000)/1000)*28.35);
								AddLinha(ref dt, "OZ", ValConv);
								AddLinha(ref dt, "LB", ValConv/16);
								break;
							case 5:
								AddLinha(ref dt, "MG", ((ValConv*1000)*1000)*0.4536);
								AddLinha(ref dt, "G", (ValConv*1000)*0.4536);
								AddLinha(ref dt, "KG", ValConv*0.4536);
								AddLinha(ref dt, "T", (ValConv/1000)*0.4536);
								AddLinha(ref dt, "OZ", ValConv*16);
								AddLinha(ref dt, "LB", ValConv);
								break;
						};
						break;
					case 2:
						switch (cmbDe.SelectedIndex) 
						{
							case 0:
								AddLinha(ref dt, "ML", ValConv);
								AddLinha(ref dt, "DL", ValConv);
								AddLinha(ref dt, "L", ValConv*0.001);
								AddLinha(ref dt, "GAL US", ValConv*0.000219);
								AddLinha(ref dt, "GAL UK", ValConv*0.000264);
								AddLinha(ref dt, "OZ FL", ValConv*0.0338);
								break;
							case 1:
								AddLinha(ref dt, "ML", ValConv);
								AddLinha(ref dt, "DL", ValConv);
								AddLinha(ref dt, "L", ValConv*0.001);
								AddLinha(ref dt, "GAL US", ValConv*0.000219);
								AddLinha(ref dt, "GAL UK", ValConv*0.000264);
								AddLinha(ref dt, "OZ FL", ValConv*0.033814);
								break;
							case 2:
								AddLinha(ref dt, "ML", ValConv*1000);
								AddLinha(ref dt, "DL", ValConv*1000);
								AddLinha(ref dt, "L", ValConv);
								AddLinha(ref dt, "GAL US", ValConv*0.2199);
								AddLinha(ref dt, "GAL UK", ValConv*0.2642);
								AddLinha(ref dt, "OZ FL", ValConv*33.81402);
								break;
							case 3:
								AddLinha(ref dt, "ML", ValConv*4546.092);
								AddLinha(ref dt, "DL", ValConv*4546.092);
								AddLinha(ref dt, "L", ValConv*4.546092);
								AddLinha(ref dt, "GAL US", ValConv);
								AddLinha(ref dt, "GAL UK", ValConv*1.20095);
								AddLinha(ref dt, "OZ FL", ValConv*153.7217);
								break;
							case 4:
								AddLinha(ref dt, "ML", ValConv*3785.412);
								AddLinha(ref dt, "DL", ValConv*3785.412);
								AddLinha(ref dt, "L", ValConv*3.785412);
								AddLinha(ref dt, "GAL US", ValConv*0.8326738);
								AddLinha(ref dt, "GAL UK", ValConv);
								AddLinha(ref dt, "OZ FL", ValConv*128);
								break;
							case 5:
								AddLinha(ref dt, "ML", ValConv*29.5735);
								AddLinha(ref dt, "DL", ValConv*29.57353);
								AddLinha(ref dt, "L", ValConv*0.0296);
								AddLinha(ref dt, "GAL US", ValConv*0.00781);
								AddLinha(ref dt, "GAL UK", ValConv*0.006505);
								AddLinha(ref dt, "OZ FL", ValConv);
								break;
						};
						break;
				};
				dataGrid1.DataSource = ds.Tables["Resultado das converções"];
			}
			finally 
			{
				btnConverter.Enabled = true;
			};
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			e.Link.Visited = true;
			System.Diagnostics.Process.Start("mailto:marciusbezerra@.aol.com");
		}

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (this.Opacity < 1) 
			{
				this.Opacity += 0.1;
				this.Refresh();
			}
			else
			{
				this.Opacity = 1;
				timer1.Enabled = false;
			}
		}
	}
}
