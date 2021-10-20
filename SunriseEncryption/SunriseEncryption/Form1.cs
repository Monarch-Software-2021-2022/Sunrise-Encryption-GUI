using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunriseEncryption.EncryptionMethods;
using SunriseEncryption.Plugin;
using SunriseEncryption.Settings;

namespace SunriseEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupExternalFiles();

            LoadPluginPage();
            ApplicationSettings.LoadSettings();

            LoadSettings();
        }

        public void LoadPluginPage()
        {
            InputLabel.Hide();
            OutputLabel.Hide();
            SubmitPluginButton.Hide();
            ClearPluginButton.Hide();
            PluginInputTextBox.Hide();
            OutputPluginTextBox.Hide();
        }

        public void LoadPluginList()
        {
            PluginListView.View = View.Details;
            PluginListView.GridLines = true;
            PluginListView.FullRowSelect = true;

            PluginListView.Items.Clear();
            PluginListView.Columns.Clear();

            PluginListView.Columns.Add("Plugin", 150);
            PluginListView.Columns.Add("Info", 150);

            LoadPlugin.CheckPluginAvailability();
            InitalizePlugin.Initalize();
            foreach (string plugin in LoadPlugin.AvailablePlugins)
            {
                string[] arr = new string[3];
                ListViewItem item;

                arr[0] = plugin.Split('\\').Last();
                arr[1] = LoadPluginData.GetPluginData(plugin.Split('\\').Last().Replace(".dll", ""), PluginData.PluginInfo);

                item = new ListViewItem(arr);
                PluginListView.Items.Add(item);
            }

            LoadingLabel.Hide();

        }

        public void SetupExternalFiles()
        {
            string PluginFiles = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");
            if (!Directory.Exists(PluginFiles))
                Directory.CreateDirectory(PluginFiles);

            using (StreamWriter sw = new StreamWriter(Path.Combine(PluginFiles, "README.txt")))
            {
                sw.WriteLine("If you want to create custom encryption or hashing methods, this is for you\n" +
                    "Please visit the Github to learn how to create plugins!");
                sw.Close();
            }
        }

        public void LoadPage(Pages page)
        {
            #region Hide all current pages
            HomePagePanel.Hide();
            HashingPagePanel.Hide();
            EncryptionPagePanel.Hide();
            PluginPagePanel.Hide();
            SettingsPagePanel.Hide();
            #endregion

            switch (page)
            {
                case Pages.Home:
                    HomePagePanel.Show();
                    break;
                case Pages.Hashing:
                    HashingPagePanel.Show();
                    break;
                case Pages.Encryption:
                    EncryptionPagePanel.Show();
                    break;
                case Pages.Plugins:
                    PluginPagePanel.Show();
                    LoadPluginList();
                    break;
                case Pages.Settings:
                    SettingsPagePanel.Show();
                    break;
            }
        }

        private void HomeButton_Click(object sender, EventArgs e) => LoadPage(Pages.Home);
        private void HashButton_Click(object sender, EventArgs e) => LoadPage(Pages.Hashing);
        private void EncryptButton_Click(object sender, EventArgs e) => LoadPage(Pages.Encryption);
        private void PluginButton_Click(object sender, EventArgs e) => LoadPage(Pages.Plugins);
        private void SettingsButton_Click(object sender, EventArgs e) => LoadPage(Pages.Settings);

        private void HashingButton_Click(object sender, EventArgs e)
        {
            Hashing hashing = new Hashing(TextToBeHashed.Text);
            string hashedText = string.Empty;
            bool upperCase = LowercaseHashBool.Checked;
            switch (HashTypeComboBox.SelectedItem)
            {
                case "MD5":
                    hashedText = hashing.MD5Hash(upperCase);
                    break;
                case "SHA1":
                    hashedText = hashing.SHA1Hash(upperCase);
                    break;
                case "SHA256":
                    hashedText = hashing.SHA256Hash(upperCase);
                    break;
                case "SHA384":
                    hashedText = hashing.SHA384Hash(upperCase);
                    break;
                case "SHA512":
                    hashedText = hashing.SHA512Hash(upperCase);
                    break;
                case "RIPEMD160":
                    hashedText = hashing.RIPEMD160HASH(upperCase);
                    break;
            }

            HashedTextBox.Text = hashedText;
        }

        private void ClearHashString_Click(object sender, EventArgs e)
        {
            HashedTextBox.Clear();
            TextToBeHashed.Clear();
        }

        private void EncryptionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EncryptionTypeComboBox.SelectedItem == "Caesar Cipher")
            {
                CipherShiftLabel.Show();
                CipherShiftTextbox.Show();
                KeyNoteLabel.Hide();
            }
            else if (EncryptionTypeComboBox.SelectedItem == "OSSE")
            {
                KeyNoteLabel.Text = "There is no official decoder for OSSE";
                KeyNoteLabel.Show();

                CipherShiftTextbox.Hide();
                CipherShiftLabel.Hide();
            }
            else
            {
                CipherShiftTextbox.Hide();
                CipherShiftLabel.Hide();
                KeyNoteLabel.Hide();
            }
        }

        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            string encryptedText = string.Empty;
            switch (EncryptionTypeComboBox.SelectedIndex)
            {
                case 0:
                    // Caesar Cipher
                    int shift = 0;
                    if (int.TryParse(CipherShiftTextbox.Text, out shift))
                        encryptedText = CaesarCipher.Encrypt(TextToBeEncryptedTextBox.Text, shift);
                    else {
                        encryptedText = CaesarCipher.Encrypt(TextToBeEncryptedTextBox.Text, 8);
                        CipherShiftTextbox.Text = "8";
                    }
                    break;
                case 1:
                    // OSSE Encryption
                    encryptedText = OSSE.Encryptor(TextToBeEncryptedTextBox.Text);
                    break;
            }

            EncryptedTextBox.Text = encryptedText;
        }

        private void ClearEncryptedButton_Click(object sender, EventArgs e)
        {
            TextToBeEncryptedTextBox.Clear();
            EncryptedTextBox.Clear();
        }

        public string SelectedPlugin;

        private void LoadPluginButton_Click(object sender, EventArgs e)
        {
            if (PluginListView.SelectedItems.Count >= 1)
            {
                InputLabel.Show();
                OutputLabel.Show();
                SubmitPluginButton.Show();
                ClearPluginButton.Show();
                PluginInputTextBox.Show();
                OutputPluginTextBox.Show();

                SelectedPlugin = PluginListView.SelectedItems[0].Text;
            }

        }

        private void SubmitPluginButton_Click(object sender, EventArgs e)
        {
            string text = PluginInputTextBox.Text;
            object returnOutput = LoadPlugin.Load(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Plugins"), SelectedPlugin), text);

            OutputPluginTextBox.Text = returnOutput.ToString();
        }

        private void OpenPluginFolder_Click(object sender, EventArgs e) => Process.Start(Path.Combine(Directory.GetCurrentDirectory(), "Plugins"));

        public void LoadSettings(bool skipSettings = false)
        {
            #region Settings Page
            if (!skipSettings)
            {
                IncludePluginInfoCheckbox.Checked = ApplicationSettings.PluginInfo;
                IncludePluginAuthorCheckbox.Checked = ApplicationSettings.PluginAuthor;
                IncludePluginVersionCheckbox.Checked = ApplicationSettings.PluginVersion;

                checkBox1.Checked = ApplicationSettings.DarkTheme;
            }
            #endregion


            // Oh I am so sorry for this future me, but it must be done
            if (ApplicationSettings.DarkTheme)
            {
                Color DarkThemePagePanel = Color.FromArgb(71, 71, 71);

                #region Pages & Panels
                VerticalDivider.BackColor = Color.FromArgb(22, 138, 173);
                HorizontalDivider.BackColor = Color.FromArgb(22, 138, 173);

                SettingsPagePanel.BackColor = DarkThemePagePanel;
                PluginPagePanel.BackColor = DarkThemePagePanel;
                HomePagePanel.BackColor = DarkThemePagePanel;
                HashingPagePanel.BackColor = DarkThemePagePanel;
                EncryptionPagePanel.BackColor = DarkThemePagePanel;
                panel1.BackColor = DarkThemePagePanel;
                #endregion

                #region Side Buttons & Panel
                Color SideButtonColor = Color.FromArgb(46, 46, 46);
                SidePanel.BackColor = Color.FromArgb(94, 94, 94);
                HomeButton.BackColor = SideButtonColor;
                HashButton.BackColor = SideButtonColor;
                EncryptButton.BackColor = SideButtonColor;
                SettingsButton.BackColor = SideButtonColor;
                PluginButton.BackColor = SideButtonColor;

                Color SideButtonForeColor = Color.FromArgb(173, 181, 189);
                HomeButton.ForeColor = SideButtonForeColor;
                HashButton.ForeColor = SideButtonForeColor;
                EncryptButton.ForeColor = SideButtonForeColor;
                SettingsButton.ForeColor = SideButtonForeColor;
                PluginButton.ForeColor = SideButtonForeColor;

                #endregion

                #region Top Header
                BackColor = Color.FromArgb(23, 23, 23);
                label2.ForeColor = Color.FromArgb(0, 150, 199);
                label1.ForeColor = Color.FromArgb(0, 119, 182);
                #endregion

                #region Text Labels
                Color HeaderLabel = Color.FromArgb(233, 236, 239);
                Color Label = Color.FromArgb(222, 226, 230);
                label13.ForeColor = Label;
                label3.ForeColor = HeaderLabel;
                label4.ForeColor = Label;
                label5.ForeColor = Label;
                label6.ForeColor = Label;
                label7.ForeColor = Label;
                label8.ForeColor = Label;
                label9.ForeColor = Label;
                label10.ForeColor = Label;
                label11.ForeColor = HeaderLabel;
                label12.ForeColor = HeaderLabel;
                label13.ForeColor = HeaderLabel;

                InputLabel.ForeColor = HeaderLabel;
                OutputLabel.ForeColor = HeaderLabel;
                LoadingLabel.ForeColor = HeaderLabel;

                KeyNoteLabel.ForeColor = Label;
                CipherShiftLabel.ForeColor = Label;

                IncludePluginAuthorCheckbox.ForeColor = Label;
                IncludePluginInfoCheckbox.ForeColor = Label;
                IncludePluginVersionCheckbox.ForeColor = Label;
                checkBox1.ForeColor = Label;


                #endregion

                #region Plugin Page

                #endregion



            }
        }

        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            bool author;
            bool version;
            bool info;

            bool darkTheme;

            #region Plugin Settings
            author = IncludePluginAuthorCheckbox.Checked;
            version = IncludePluginVersionCheckbox.Checked;
            info = IncludePluginInfoCheckbox.Checked;
            #endregion

            #region Application Settings
            darkTheme = checkBox1.Checked;
            #endregion

            Config cfg = new Config
            {
                DarkThemeEnabled = darkTheme,
                PluginInfoEnabled = info,
                PluginAuthorEnabled = author,
                PluginVersionEnabled = version
            };

            ApplicationSettings.ApplySettings(cfg);
            LoadSettings(true);
        }
    }

    public enum Pages
    {
        Home = 0,
        Hashing = 1,
        Encryption = 2,
        EncryptionFiles = 3,
        Plugins = 4,
        Settings = 5
    }
}
