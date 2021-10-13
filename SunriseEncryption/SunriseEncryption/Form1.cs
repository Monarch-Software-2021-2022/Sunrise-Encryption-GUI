using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunriseEncryption.EncryptionMethods;

namespace SunriseEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupExternalFiles();
        }

        public void LoadPluginList()
        {
            PluginListView.View = View.Details;
            PluginListView.GridLines = true;
            PluginListView.FullRowSelect = true;

            PluginListView.Items.Clear();

            PluginListView.Columns.Add("Plugin", 150);
            PluginListView.Columns.Add("Info", 150);

            foreach (var file in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Plugins")))
            {
                if (file.Contains(".dll"))
                {
                    string[] arr = new string[3];
                    ListViewItem item;

                    arr[0] = file.Split('\\').Last();
                    arr[1] = "None";

                    item = new ListViewItem(arr);
                    PluginListView.Items.Add(item);
                }
            }
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
            }
        }

        private void HomeButton_Click(object sender, EventArgs e) => LoadPage(Pages.Home);
        private void HashButton_Click(object sender, EventArgs e) => LoadPage(Pages.Hashing);
        private void EncryptButton_Click(object sender, EventArgs e) => LoadPage(Pages.Encryption);
        private void PluginButton_Click(object sender, EventArgs e) => LoadPage(Pages.Plugins);

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
