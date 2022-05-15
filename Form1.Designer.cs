namespace FF5Abridged
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BrowseForGameAssets = new System.Windows.Forms.Button();
			this.extractGameAssets = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.gameAssetsFile = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.BrowseForFolder = new System.Windows.Forms.Button();
			this.NewSeed = new System.Windows.Forms.Button();
			this.RandoSeed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.RandoFlags = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FF5PRFolder = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.NewChecksum = new System.Windows.Forms.Label();
			this.Randomize = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtXPBoost = new System.Windows.Forms.NumericUpDown();
			this.txtGilBoost = new System.Windows.Forms.NumericUpDown();
			this.txtAPBoost = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.txtXPBoost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGilBoost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAPBoost)).BeginInit();
			this.SuspendLayout();
			// 
			// BrowseForGameAssets
			// 
			this.BrowseForGameAssets.Location = new System.Drawing.Point(494, 89);
			this.BrowseForGameAssets.Name = "BrowseForGameAssets";
			this.BrowseForGameAssets.Size = new System.Drawing.Size(95, 28);
			this.BrowseForGameAssets.TabIndex = 60;
			this.BrowseForGameAssets.Text = "Browse";
			this.BrowseForGameAssets.UseVisualStyleBackColor = true;
			this.BrowseForGameAssets.Click += new System.EventHandler(this.BrowseForGameAssets_Click);
			// 
			// extractGameAssets
			// 
			this.extractGameAssets.Location = new System.Drawing.Point(595, 88);
			this.extractGameAssets.Name = "extractGameAssets";
			this.extractGameAssets.Size = new System.Drawing.Size(95, 28);
			this.extractGameAssets.TabIndex = 59;
			this.extractGameAssets.Text = "Extract";
			this.extractGameAssets.UseVisualStyleBackColor = true;
			this.extractGameAssets.Click += new System.EventHandler(this.extractGameAssets_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(710, 92);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(78, 20);
			this.linkLabel1.TabIndex = 58;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Download";
			// 
			// gameAssetsFile
			// 
			this.gameAssetsFile.Location = new System.Drawing.Point(138, 89);
			this.gameAssetsFile.Name = "gameAssetsFile";
			this.gameAssetsFile.Size = new System.Drawing.Size(346, 27);
			this.gameAssetsFile.TabIndex = 57;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(12, 92);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 20);
			this.label15.TabIndex = 56;
			this.label15.Text = "Game Assets File";
			// 
			// BrowseForFolder
			// 
			this.BrowseForFolder.Location = new System.Drawing.Point(693, 6);
			this.BrowseForFolder.Name = "BrowseForFolder";
			this.BrowseForFolder.Size = new System.Drawing.Size(95, 28);
			this.BrowseForFolder.TabIndex = 55;
			this.BrowseForFolder.Text = "Browse";
			this.BrowseForFolder.UseVisualStyleBackColor = true;
			this.BrowseForFolder.Click += new System.EventHandler(this.BrowseForFolder_Click);
			// 
			// NewSeed
			// 
			this.NewSeed.Location = new System.Drawing.Point(729, 43);
			this.NewSeed.Name = "NewSeed";
			this.NewSeed.Size = new System.Drawing.Size(59, 29);
			this.NewSeed.TabIndex = 54;
			this.NewSeed.Text = "New";
			this.NewSeed.UseVisualStyleBackColor = true;
			this.NewSeed.Click += new System.EventHandler(this.NewSeed_Click);
			// 
			// RandoSeed
			// 
			this.RandoSeed.Location = new System.Drawing.Point(554, 44);
			this.RandoSeed.Name = "RandoSeed";
			this.RandoSeed.Size = new System.Drawing.Size(160, 27);
			this.RandoSeed.TabIndex = 53;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(506, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 52;
			this.label3.Text = "Seed";
			// 
			// RandoFlags
			// 
			this.RandoFlags.Location = new System.Drawing.Point(138, 47);
			this.RandoFlags.Name = "RandoFlags";
			this.RandoFlags.Size = new System.Drawing.Size(346, 27);
			this.RandoFlags.TabIndex = 51;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 20);
			this.label2.TabIndex = 50;
			this.label2.Text = "Rando Flags";
			// 
			// FF5PRFolder
			// 
			this.FF5PRFolder.Location = new System.Drawing.Point(138, 6);
			this.FF5PRFolder.Name = "FF5PRFolder";
			this.FF5PRFolder.Size = new System.Drawing.Size(502, 27);
			this.FF5PRFolder.TabIndex = 49;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 48;
			this.label1.Text = "FF5 PR Folder";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(478, 344);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 29);
			this.button1.TabIndex = 63;
			this.button1.Text = "Revert to vanilla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.revertToDefault_click);
			// 
			// NewChecksum
			// 
			this.NewChecksum.AutoSize = true;
			this.NewChecksum.Location = new System.Drawing.Point(12, 394);
			this.NewChecksum.Name = "NewChecksum";
			this.NewChecksum.Size = new System.Drawing.Size(267, 20);
			this.NewChecksum.TabIndex = 62;
			this.NewChecksum.Text = "New Checksum:  (Not Randomized Yet)";
			// 
			// Randomize
			// 
			this.Randomize.Location = new System.Drawing.Point(668, 344);
			this.Randomize.Name = "Randomize";
			this.Randomize.Size = new System.Drawing.Size(120, 29);
			this.Randomize.TabIndex = 61;
			this.Randomize.Text = "Randomize!";
			this.Randomize.UseVisualStyleBackColor = true;
			this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 65;
			this.label4.Text = "XP Boost";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 20);
			this.label5.TabIndex = 66;
			this.label5.Text = "Gil Boost";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 20);
			this.label6.TabIndex = 70;
			this.label6.Text = "AP Boost";
			// 
			// txtXPBoost
			// 
			this.txtXPBoost.Location = new System.Drawing.Point(138, 133);
			this.txtXPBoost.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
			this.txtXPBoost.Name = "txtXPBoost";
			this.txtXPBoost.Size = new System.Drawing.Size(150, 27);
			this.txtXPBoost.TabIndex = 68;
			this.txtXPBoost.ValueChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// txtGilBoost
			// 
			this.txtGilBoost.Location = new System.Drawing.Point(138, 175);
			this.txtGilBoost.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
			this.txtGilBoost.Name = "txtGilBoost";
			this.txtGilBoost.Size = new System.Drawing.Size(150, 27);
			this.txtGilBoost.TabIndex = 69;
			this.txtGilBoost.ValueChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// txtAPBoost
			// 
			this.txtAPBoost.Location = new System.Drawing.Point(138, 218);
			this.txtAPBoost.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
			this.txtAPBoost.Name = "txtAPBoost";
			this.txtAPBoost.Size = new System.Drawing.Size(150, 27);
			this.txtAPBoost.TabIndex = 71;
			this.txtAPBoost.ValueChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 423);
			this.Controls.Add(this.txtAPBoost);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtGilBoost);
			this.Controls.Add(this.txtXPBoost);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.NewChecksum);
			this.Controls.Add(this.Randomize);
			this.Controls.Add(this.BrowseForGameAssets);
			this.Controls.Add(this.extractGameAssets);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.gameAssetsFile);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.BrowseForFolder);
			this.Controls.Add(this.NewSeed);
			this.Controls.Add(this.RandoSeed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.RandoFlags);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FF5PRFolder);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtXPBoost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGilBoost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAPBoost)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button BrowseForGameAssets;
		private Button extractGameAssets;
		private LinkLabel linkLabel1;
		private TextBox gameAssetsFile;
		private Label label15;
		private Button BrowseForFolder;
		private Button NewSeed;
		private TextBox RandoSeed;
		private Label label3;
		private TextBox RandoFlags;
		private Label label2;
		private TextBox FF5PRFolder;
		private Label label1;
		private Button button1;
		private Label NewChecksum;
		private Button Randomize;
		private Label label4;
		private Label label5;
		private Label label6;
		private NumericUpDown txtXPBoost;
		private NumericUpDown txtGilBoost;
		private NumericUpDown txtAPBoost;
	}
}