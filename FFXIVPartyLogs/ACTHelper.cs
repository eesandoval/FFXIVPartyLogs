using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Xml;
namespace FFXIVPartyLogs
{
	class ACTHelper : UserControl , IActPluginV1
	{
		#region Designer Created Code (Avoid editing)
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxZone = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxEncounter = new System.Windows.Forms.ComboBox();
			this.radioExcalibur = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.comboBoxJob = new System.Windows.Forms.ComboBox();
			this.textBoxCharacterName = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.buttonParse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTopDPS = new System.Windows.Forms.Label();
			this.labelTopPercentile = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxZone);
			this.groupBox1.Location = new System.Drawing.Point(13, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 53);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Zone";
			// 
			// comboBoxZone
			// 
			this.comboBoxZone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.comboBoxZone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxZone.FormattingEnabled = true;
			this.comboBoxZone.Location = new System.Drawing.Point(6, 19);
			this.comboBoxZone.Name = "comboBoxZone";
			this.comboBoxZone.Size = new System.Drawing.Size(188, 21);
			this.comboBoxZone.TabIndex = 3;
			this.comboBoxZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxZone_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxEncounter);
			this.groupBox2.Location = new System.Drawing.Point(219, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 53);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Encounter";
			// 
			// comboBoxEncounter
			// 
			this.comboBoxEncounter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.comboBoxEncounter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxEncounter.FormattingEnabled = true;
			this.comboBoxEncounter.Location = new System.Drawing.Point(6, 19);
			this.comboBoxEncounter.Name = "comboBoxEncounter";
			this.comboBoxEncounter.Size = new System.Drawing.Size(188, 21);
			this.comboBoxEncounter.TabIndex = 4;
			// 
			// radioExcalibur
			// 
			this.radioExcalibur.AutoSize = true;
			this.radioExcalibur.Checked = true;
			this.radioExcalibur.Location = new System.Drawing.Point(6, 19);
			this.radioExcalibur.Name = "radioExcalibur";
			this.radioExcalibur.Size = new System.Drawing.Size(68, 17);
			this.radioExcalibur.TabIndex = 4;
			this.radioExcalibur.TabStop = true;
			this.radioExcalibur.Text = "Excalibur";
			this.radioExcalibur.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioExcalibur);
			this.groupBox3.Location = new System.Drawing.Point(544, 14);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(99, 53);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Server";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboBoxJob);
			this.groupBox4.Location = new System.Drawing.Point(425, 14);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(113, 53);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Job";
			// 
			// comboBoxJob
			// 
			this.comboBoxJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.comboBoxJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxJob.FormattingEnabled = true;
			this.comboBoxJob.Location = new System.Drawing.Point(6, 19);
			this.comboBoxJob.Name = "comboBoxJob";
			this.comboBoxJob.Size = new System.Drawing.Size(101, 21);
			this.comboBoxJob.TabIndex = 4;
			// 
			// textBoxCharacterName
			// 
			this.textBoxCharacterName.Location = new System.Drawing.Point(6, 19);
			this.textBoxCharacterName.Name = "textBoxCharacterName";
			this.textBoxCharacterName.Size = new System.Drawing.Size(160, 20);
			this.textBoxCharacterName.TabIndex = 7;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.textBoxCharacterName);
			this.groupBox5.Location = new System.Drawing.Point(13, 73);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(172, 52);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Character Name";
			// 
			// buttonParse
			// 
			this.buttonParse.Location = new System.Drawing.Point(13, 131);
			this.buttonParse.Name = "buttonParse";
			this.buttonParse.Size = new System.Drawing.Size(75, 23);
			this.buttonParse.TabIndex = 9;
			this.buttonParse.Text = "Get Top Log";
			this.buttonParse.UseVisualStyleBackColor = true;
			this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Top DPS:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.labelTopPercentile);
			this.groupBox6.Controls.Add(this.labelTopDPS);
			this.groupBox6.Controls.Add(this.label2);
			this.groupBox6.Controls.Add(this.label1);
			this.groupBox6.Location = new System.Drawing.Point(13, 160);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(200, 100);
			this.groupBox6.TabIndex = 11;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Parse Data";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Top Percentile:";
			// 
			// labelTopDPS
			// 
			this.labelTopDPS.AutoSize = true;
			this.labelTopDPS.Location = new System.Drawing.Point(158, 28);
			this.labelTopDPS.Name = "labelTopDPS";
			this.labelTopDPS.Size = new System.Drawing.Size(0, 13);
			this.labelTopDPS.TabIndex = 13;
			// 
			// labelTopPercentile
			// 
			this.labelTopPercentile.AutoSize = true;
			this.labelTopPercentile.Location = new System.Drawing.Point(157, 57);
			this.labelTopPercentile.Name = "labelTopPercentile";
			this.labelTopPercentile.Size = new System.Drawing.Size(0, 13);
			this.labelTopPercentile.TabIndex = 14;
			// 
			// ACTHelper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.buttonParse);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "ACTHelper";
			this.Size = new System.Drawing.Size(686, 384);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		#endregion

		public ACTHelper()
		{
			InitializeComponent();
		}

		private GroupBox groupBox1;
		private ComboBox comboBoxZone;
		private GroupBox groupBox2;
		private ComboBox comboBoxEncounter;
		private RadioButton radioExcalibur;
		private GroupBox groupBox3;
		Label lblStatus;    // The status label that appears in ACT's Plugin tab
		private Dictionary<int, int> comboBoxZoneToID = new Dictionary<int, int>();
		private Dictionary<int, int> comboBoxEncounterToID = new Dictionary<int, int>();
		private GroupBox groupBox4;
		private ComboBox comboBoxJob;
		private TextBox textBoxCharacterName;
		private GroupBox groupBox5;
		private Button buttonParse;
		private Label label1;
		private GroupBox groupBox6;
		private Label labelTopPercentile;
		private Label labelTopDPS;
		private Label label2;

		public void DeInitPlugin()
		{
			ActGlobals.oFormActMain.AfterCombatAction -= oFormActMain_AfterCombatAction;
			
			lblStatus.Text = "Plugin Exited";
		}

		public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
		{
			lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
			this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space

			// Create some sort of parsing event handler.  After the "+=" hit TAB twice and the code will be generated for you.
			ActGlobals.oFormActMain.AfterCombatAction += new CombatActionDelegate(oFormActMain_AfterCombatAction);

			lblStatus.Text = "Plugin Started";
			Dictionary<int, string> zones = FFLogsHelper.GetZones();
			int i = 0;
			foreach (int id in zones.Keys)
			{
				if (!FFLogsHelper.IsZoneFrozen(id))
				{
					comboBoxZone.Items.Add(zones[id]);
					this.comboBoxZoneToID[i++] = id;
				}
			}
			comboBoxZone.SelectedIndex = 0;
			InitJobs();
			comboBoxZone_SelectedIndexChanged(comboBoxZone, null);
		}

		#pragma warning disable IDE1006 // Naming Styles
		void oFormActMain_AfterCombatAction(bool isImport, CombatActionEventArgs actionInfo)
		#pragma warning restore IDE1006 // Naming Styles
		{
			string player = actionInfo.attacker;
			Parse p = new Parse(player, "Excalibur", "NA");
		}

		#pragma warning disable IDE1006 // Naming Styles
		private void comboBoxZone_SelectedIndexChanged(object sender, EventArgs e)
		#pragma warning restore IDE1006 // Naming Styles
		{
			ComboBox comboBox = (ComboBox)sender;
			if (this.comboBoxZoneToID.ContainsKey(comboBox.SelectedIndex))
			{
				comboBoxEncounter.Items.Clear();
				int i = 0;
				Dictionary<int, string> encounters = FFLogsHelper.GetEncounters(this.comboBoxZoneToID[comboBox.SelectedIndex]);
				foreach (int id in encounters.Keys)
				{
					comboBoxEncounter.Items.Add(encounters[id]);
					this.comboBoxEncounterToID[i++] = id;
				}
			}
			comboBoxEncounter.SelectedIndex = 0;
		}

		#pragma warning disable IDE1006 // Naming Styles
		private void buttonParse_Click(object sender, EventArgs e)
		#pragma warning restore IDE1006 // Naming Styles
		{
			string characterName = this.textBoxCharacterName.Text;
			int zoneID = this.comboBoxZoneToID[this.comboBoxZone.SelectedIndex];
			int encounterID = this.comboBoxEncounterToID[this.comboBoxEncounter.SelectedIndex];
			string job = (string)this.comboBoxJob.SelectedItem;
			Parse parse = new Parse(characterName, "Excalibur", "NA");
			parse.UpdateTopLog(zoneID, encounterID, job);
			this.labelTopDPS.Text = parse.PerSecondAmount.ToString();
			this.labelTopPercentile.Text = parse.Percentile.ToString();
		}

		private void InitJobs()
		{
			comboBoxJob.Items.Clear();
			string[] jobs = new string[] { "Paladin", "Warrior", "Dark Knight", "White Mage", "Scholar", "Astrologian", "Monk",
										"Dragoon", "Ninja", "Samurai", "Bard", "Machinist", "Black Mage", "Summoner", "Red Mage"};
			comboBoxJob.Items.AddRange(jobs);
			comboBoxJob.SelectedIndex = 0;
		}
	}
}
