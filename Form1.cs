using FF5Abridged.Randomize;
using FF5Abridged.Inventory;
using System.IO.Compression;
using System.Security.Cryptography;

namespace FF5Abridged
{
	public partial class Form1 : Form
	{
		bool loading = true;
		Random r1;

		public Form1()
		{
			InitializeComponent();
		}

		private void BrowseForFolder_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
					FF5PRFolder.Text = fbd.SelectedPath;
			}
		}

		private void NewSeed_Click(object sender, EventArgs e)
		{
			RandoSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
		}

		private void BrowseForGameAssets_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = @"C:\";
			openFileDialog1.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				gameAssetsFile.Text = openFileDialog1.FileName;
			}
		}

		private void extractGameAssets_Click(object sender, EventArgs e)
		{
			try
			{
				if (!File.Exists(gameAssetsFile.Text))
				{
					MessageBox.Show("Cannot extract - game assets file listed does not exist...");
					NewChecksum.Text = "Extraction failed...";
					return;
				}
				NewChecksum.Text = "Extracting...";
				if (!Directory.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx")))
					ZipFile.ExtractToDirectory(Path.Combine("install", "BepInEx.zip"), Path.Combine(FF5PRFolder.Text), true);

				if (!File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.dll")))
					File.Copy(Path.Combine("install", "Memoria.FF5.dll"), Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.dll"));
				if (!File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.pdb")))
					File.Copy(Path.Combine("install", "Memoria.FF5.pdb"), Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.pdb"));
				if (!File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg")))
					File.Copy(Path.Combine("install", "Memoria.ffpr.cfg"), Path.Combine(FF5PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg"));
				if (!Directory.Exists(Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets")))
					ZipFile.ExtractToDirectory(gameAssetsFile.Text, Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets"));
				NewChecksum.Text = "Extraction complete!";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to extract - " + ex.Message);
				NewChecksum.Text = "Extraction failed...";
			}
		}

		public void DetermineFlags(object sender, EventArgs e)
		{
			if (loading) return;

			string flags = "";
			flags += convertIntToChar((int)txtXPBoost.Value);
			flags += convertIntToChar((int)txtGilBoost.Value);
			flags += convertIntToChar((int)txtAPBoost.Value);
			RandoFlags.Text = flags;

			//flags = "";
			//flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { CuteHats }));
			//VisualFlags.Text = flags;
		}

		private void determineChecks(object sender, EventArgs e)
		{
			if (loading && RandoFlags.Text.Length < 3)
				RandoFlags.Text = "A3A"; // Default flags here
			else if (RandoFlags.Text.Length < 3)
				return;

			loading = true;

			string flags = RandoFlags.Text;
			txtXPBoost.Value = convertChartoInt(Convert.ToChar(flags.Substring(0, 1)));
			txtGilBoost.Value = convertChartoInt(Convert.ToChar(flags.Substring(1, 1)));
			txtAPBoost.Value = convertChartoInt(Convert.ToChar(flags.Substring(2, 1)));

			loading = false;
		}

		private int checkboxesToNumber(CheckBox[] boxes)
		{
			int number = 0;
			for (int lnI = 0; lnI < Math.Min(boxes.Length, 6); lnI++)
				number += boxes[lnI].Checked ? (int)Math.Pow(2, lnI) : 0;

			return number;
		}

		private int numberToCheckboxes(int number, CheckBox[] boxes)
		{
			for (int lnI = 0; lnI < Math.Min(boxes.Length, 6); lnI++)
				boxes[lnI].Checked = number % ((int)Math.Pow(2, lnI + 1)) >= (int)Math.Pow(2, lnI);

			return number;
		}

		private string convertIntToChar(int number)
		{
			if (number >= 0 && number <= 9)
				return number.ToString();
			if (number >= 10 && number <= 35)
				return Convert.ToChar(55 + number).ToString();
			if (number >= 36 && number <= 61)
				return Convert.ToChar(61 + number).ToString();
			if (number == 62) return "!";
			if (number == 63) return "@";
			return "";
		}

		private int convertChartoInt(char character)
		{
			if (character >= Convert.ToChar("0") && character <= Convert.ToChar("9"))
				return character - 48;
			if (character >= Convert.ToChar("A") && character <= Convert.ToChar("Z"))
				return character - 55;
			if (character >= Convert.ToChar("a") && character <= Convert.ToChar("z"))
				return character - 61;
			if (character == Convert.ToChar("!")) return 62;
			if (character == Convert.ToChar("@")) return 63;
			return 0;
		}

		private void revertToDefault_click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to revert Final Fantasy V back to vanilla?", "Final Fantasy V: Abridged", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					NewChecksum.Text = "Reverting...";
					if (File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.dll")))
						File.Delete(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.dll"));
					if (File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.pdb")))
						File.Delete(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.pdb"));
					if (File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg")))
						File.Delete(Path.Combine(FF5PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg"));
					if (Directory.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx")))
						Directory.Delete(Path.Combine(FF5PRFolder.Text, "BepInEx"), true);
					if (Directory.Exists(Path.Combine(FF5PRFolder.Text, "mono")))
						Directory.Delete(Path.Combine(FF5PRFolder.Text, "mono"), true);
					if (Directory.Exists(Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets")))
						Directory.Delete(Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets"), true);
					NewChecksum.Text = "Revert complete!";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unable to revert - " + ex.Message);
					NewChecksum.Text = "Revert failed...";
				}
			}
		}

		private void Randomize_Click(object sender, EventArgs e)
		{
			if (!File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.dll")) || !File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "plugins", "Memoria.FF5.pdb"))
				|| !File.Exists(Path.Combine(FF5PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg")) || !Directory.Exists(Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets")))
			{
				MessageBox.Show("Randomizer assets have not been extracted.  Please extract, then try randomization again.");
				return;
			}

			r1 = new Random(Convert.ToInt32(RandoSeed.Text));
			update();
			establishAreas();
			Jobs jobObject = setupStart();
			randomizeTreasures(jobObject);
			randomizeShops();
			randomizeMonsters();

			try
			{
				using (var sha1Crypto = SHA1.Create())
				{
					using (var stream = File.OpenRead(Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "monster_party.csv")))
					{
						string checkSum = BitConverter.ToString(sha1Crypto.ComputeHash(stream)).ToLower().Replace("-", "").Substring(0, 16);
						Clipboard.SetText(checkSum);
						NewChecksum.Text = "COMPLETE - checksum " + checkSum + " (copied to clipboard)";
					}
				}
			}
			catch (Exception ex)
			{
				NewChecksum.Text = "COMPLETE - checksum ????????????????";
			}
		}

		private void update()
		{
			new Inventory.Updater(Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial"));
		}

		private void establishAreas()
		{
			new Inventory.Maps(r1, Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial"));
		}

		private Jobs setupStart()
		{
			Jobs jobObject = new Jobs(r1);
			Starter start = new Starter(r1, jobObject, Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"));
			return jobObject;
		}

		private void randomizeShops()
		{
			Shops randoShops = new Shops(r1, 1, 3, Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "product.csv"));
		}

		private void randomizeTreasures(Jobs jobObject)
		{
			new Randomize.Treasure(r1, 1, jobObject, Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"),
				Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Message"));
		}

		private void randomizeMonsters()
		{
			decimal xpBoost = txtXPBoost.Value;
			decimal gilBoost = txtGilBoost.Value;
			decimal apBoost = txtAPBoost.Value;
			new Monster(r1, 0, Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master"), 
				Path.Combine(FF5PRFolder.Text, "FINAL FANTASY V_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"), 
				xpBoost, gilBoost, apBoost, true); // monsterDifficulty.SelectedIndex, monsterAreaAppropriate.Checked
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RandoSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();

			try
			{
				using (TextReader reader = File.OpenText("lastFF5AB.txt"))
				{
					FF5PRFolder.Text = reader.ReadLine();
					RandoSeed.Text = reader.ReadLine();
					RandoFlags.Text = reader.ReadLine();
					gameAssetsFile.Text = reader.ReadLine();
					determineChecks(null, null);

					loading = false;
				}
			}
			catch
			{
				// Default flags here
				RandoFlags.Text = "A3A";
				// ignore error
				loading = false;
				determineChecks(null, null);
			}

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			using (StreamWriter writer = File.CreateText("lastFF5AB.txt"))
			{
				writer.WriteLine(FF5PRFolder.Text);
				writer.WriteLine(RandoSeed.Text);
				writer.WriteLine(RandoFlags.Text);
				writer.WriteLine(gameAssetsFile.Text);
				//writer.WriteLine(VisualFlags.Text);
			}
		}

		private void DefaultFlags_Click(object sender, EventArgs e)
		{
			RandoFlags.Text = "A3A";
			determineChecks(null, null);
		}
	}
}