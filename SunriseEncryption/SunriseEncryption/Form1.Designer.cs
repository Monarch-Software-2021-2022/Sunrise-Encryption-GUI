
namespace SunriseEncryption
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PluginPagePanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HashingPagePanel = new System.Windows.Forms.Panel();
            this.HashedTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LowercaseHashBool = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HashTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ClearHashString = new System.Windows.Forms.Button();
            this.HashingButton = new System.Windows.Forms.Button();
            this.TextToBeHashed = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EncryptionPagePanel = new System.Windows.Forms.Panel();
            this.KeyNoteLabel = new System.Windows.Forms.Label();
            this.CipherShiftTextbox = new System.Windows.Forms.TextBox();
            this.CipherShiftLabel = new System.Windows.Forms.Label();
            this.EncryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EncryptionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ClearEncryptedButton = new System.Windows.Forms.Button();
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.TextToBeEncryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PluginButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.HashButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.HorizontalDivider = new System.Windows.Forms.Panel();
            this.VerticalDivider = new System.Windows.Forms.Panel();
            this.PluginListView = new System.Windows.Forms.ListView();
            this.LoadPluginButton = new System.Windows.Forms.Button();
            this.LoadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PluginPagePanel.SuspendLayout();
            this.HomePagePanel.SuspendLayout();
            this.HashingPagePanel.SuspendLayout();
            this.EncryptionPagePanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunrise Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(163)))), ((int)(((byte)(7)))));
            this.label2.Location = new System.Drawing.Point(189, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monarch TSA 2021 - 2022";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.PluginPagePanel);
            this.panel1.Controls.Add(this.HomePagePanel);
            this.panel1.Controls.Add(this.HashingPagePanel);
            this.panel1.Controls.Add(this.EncryptionPagePanel);
            this.panel1.Location = new System.Drawing.Point(1, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 660);
            this.panel1.TabIndex = 3;
            // 
            // PluginPagePanel
            // 
            this.PluginPagePanel.Controls.Add(this.LoadingLabel);
            this.PluginPagePanel.Controls.Add(this.LoadPluginButton);
            this.PluginPagePanel.Controls.Add(this.PluginListView);
            this.PluginPagePanel.Controls.Add(this.label12);
            this.PluginPagePanel.Location = new System.Drawing.Point(306, 0);
            this.PluginPagePanel.Name = "PluginPagePanel";
            this.PluginPagePanel.Size = new System.Drawing.Size(955, 657);
            this.PluginPagePanel.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 54);
            this.label12.TabIndex = 0;
            this.label12.Text = "Plugin List:";
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.Controls.Add(this.label7);
            this.HomePagePanel.Controls.Add(this.label3);
            this.HomePagePanel.Location = new System.Drawing.Point(306, 3);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(955, 657);
            this.HomePagePanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(931, 226);
            this.label7.TabIndex = 1;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sunrise Encryption";
            // 
            // HashingPagePanel
            // 
            this.HashingPagePanel.Controls.Add(this.HashedTextBox);
            this.HashingPagePanel.Controls.Add(this.label6);
            this.HashingPagePanel.Controls.Add(this.LowercaseHashBool);
            this.HashingPagePanel.Controls.Add(this.label5);
            this.HashingPagePanel.Controls.Add(this.panel2);
            this.HashingPagePanel.Controls.Add(this.HashTypeComboBox);
            this.HashingPagePanel.Controls.Add(this.ClearHashString);
            this.HashingPagePanel.Controls.Add(this.HashingButton);
            this.HashingPagePanel.Controls.Add(this.TextToBeHashed);
            this.HashingPagePanel.Controls.Add(this.label4);
            this.HashingPagePanel.Location = new System.Drawing.Point(306, 0);
            this.HashingPagePanel.Name = "HashingPagePanel";
            this.HashingPagePanel.Size = new System.Drawing.Size(952, 657);
            this.HashingPagePanel.TabIndex = 1;
            // 
            // HashedTextBox
            // 
            this.HashedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.HashedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HashedTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HashedTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashedTextBox.Location = new System.Drawing.Point(9, 415);
            this.HashedTextBox.Name = "HashedTextBox";
            this.HashedTextBox.Size = new System.Drawing.Size(922, 170);
            this.HashedTextBox.TabIndex = 9;
            this.HashedTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hashed Text:";
            // 
            // LowercaseHashBool
            // 
            this.LowercaseHashBool.AutoSize = true;
            this.LowercaseHashBool.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowercaseHashBool.Location = new System.Drawing.Point(394, 257);
            this.LowercaseHashBool.Name = "LowercaseHashBool";
            this.LowercaseHashBool.Size = new System.Drawing.Size(230, 40);
            this.LowercaseHashBool.TabIndex = 7;
            this.LowercaseHashBool.Text = "Lowercase Hash";
            this.LowercaseHashBool.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hash Type: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.panel2.Location = new System.Drawing.Point(11, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 10);
            this.panel2.TabIndex = 5;
            // 
            // HashTypeComboBox
            // 
            this.HashTypeComboBox.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashTypeComboBox.FormattingEnabled = true;
            this.HashTypeComboBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "RIPEMD160"});
            this.HashTypeComboBox.Location = new System.Drawing.Point(166, 260);
            this.HashTypeComboBox.Name = "HashTypeComboBox";
            this.HashTypeComboBox.Size = new System.Drawing.Size(199, 44);
            this.HashTypeComboBox.TabIndex = 4;
            // 
            // ClearHashString
            // 
            this.ClearHashString.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearHashString.Location = new System.Drawing.Point(703, 162);
            this.ClearHashString.Name = "ClearHashString";
            this.ClearHashString.Size = new System.Drawing.Size(230, 75);
            this.ClearHashString.TabIndex = 3;
            this.ClearHashString.Text = "Clear";
            this.ClearHashString.UseVisualStyleBackColor = true;
            this.ClearHashString.Click += new System.EventHandler(this.ClearHashString_Click);
            // 
            // HashingButton
            // 
            this.HashingButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashingButton.Location = new System.Drawing.Point(11, 162);
            this.HashingButton.Name = "HashingButton";
            this.HashingButton.Size = new System.Drawing.Size(230, 75);
            this.HashingButton.TabIndex = 2;
            this.HashingButton.Text = "Hash";
            this.HashingButton.UseVisualStyleBackColor = true;
            this.HashingButton.Click += new System.EventHandler(this.HashingButton_Click);
            // 
            // TextToBeHashed
            // 
            this.TextToBeHashed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.TextToBeHashed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextToBeHashed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextToBeHashed.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextToBeHashed.Location = new System.Drawing.Point(11, 59);
            this.TextToBeHashed.Name = "TextToBeHashed";
            this.TextToBeHashed.Size = new System.Drawing.Size(922, 96);
            this.TextToBeHashed.TabIndex = 1;
            this.TextToBeHashed.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Text to be Hashed: ";
            // 
            // EncryptionPagePanel
            // 
            this.EncryptionPagePanel.Controls.Add(this.KeyNoteLabel);
            this.EncryptionPagePanel.Controls.Add(this.CipherShiftTextbox);
            this.EncryptionPagePanel.Controls.Add(this.CipherShiftLabel);
            this.EncryptionPagePanel.Controls.Add(this.EncryptedTextBox);
            this.EncryptionPagePanel.Controls.Add(this.label8);
            this.EncryptionPagePanel.Controls.Add(this.label9);
            this.EncryptionPagePanel.Controls.Add(this.panel4);
            this.EncryptionPagePanel.Controls.Add(this.EncryptionTypeComboBox);
            this.EncryptionPagePanel.Controls.Add(this.ClearEncryptedButton);
            this.EncryptionPagePanel.Controls.Add(this.EncryptionButton);
            this.EncryptionPagePanel.Controls.Add(this.TextToBeEncryptedTextBox);
            this.EncryptionPagePanel.Controls.Add(this.label10);
            this.EncryptionPagePanel.Location = new System.Drawing.Point(306, 0);
            this.EncryptionPagePanel.Name = "EncryptionPagePanel";
            this.EncryptionPagePanel.Size = new System.Drawing.Size(952, 657);
            this.EncryptionPagePanel.TabIndex = 2;
            // 
            // KeyNoteLabel
            // 
            this.KeyNoteLabel.AutoSize = true;
            this.KeyNoteLabel.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyNoteLabel.Location = new System.Drawing.Point(493, 263);
            this.KeyNoteLabel.Name = "KeyNoteLabel";
            this.KeyNoteLabel.Size = new System.Drawing.Size(0, 36);
            this.KeyNoteLabel.TabIndex = 12;
            // 
            // CipherShiftTextbox
            // 
            this.CipherShiftTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherShiftTextbox.Location = new System.Drawing.Point(649, 265);
            this.CipherShiftTextbox.MaxLength = 2;
            this.CipherShiftTextbox.Name = "CipherShiftTextbox";
            this.CipherShiftTextbox.Size = new System.Drawing.Size(100, 37);
            this.CipherShiftTextbox.TabIndex = 11;
            // 
            // CipherShiftLabel
            // 
            this.CipherShiftLabel.AutoSize = true;
            this.CipherShiftLabel.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherShiftLabel.Location = new System.Drawing.Point(469, 263);
            this.CipherShiftLabel.Name = "CipherShiftLabel";
            this.CipherShiftLabel.Size = new System.Drawing.Size(159, 36);
            this.CipherShiftLabel.TabIndex = 10;
            this.CipherShiftLabel.Text = "Cipher Shift:";
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.EncryptedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncryptedTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EncryptedTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedTextBox.Location = new System.Drawing.Point(9, 415);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(922, 170);
            this.EncryptedTextBox.TabIndex = 9;
            this.EncryptedTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 41);
            this.label8.TabIndex = 8;
            this.label8.Text = "Encrypted Text:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 36);
            this.label9.TabIndex = 6;
            this.label9.Text = "Encryption Type:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.panel4.Location = new System.Drawing.Point(11, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(922, 10);
            this.panel4.TabIndex = 5;
            // 
            // EncryptionTypeComboBox
            // 
            this.EncryptionTypeComboBox.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionTypeComboBox.FormattingEnabled = true;
            this.EncryptionTypeComboBox.Items.AddRange(new object[] {
            "Caesar Cipher",
            "OSSE"});
            this.EncryptionTypeComboBox.Location = new System.Drawing.Point(248, 260);
            this.EncryptionTypeComboBox.Name = "EncryptionTypeComboBox";
            this.EncryptionTypeComboBox.Size = new System.Drawing.Size(199, 44);
            this.EncryptionTypeComboBox.TabIndex = 4;
            this.EncryptionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.EncryptionTypeComboBox_SelectedIndexChanged);
            // 
            // ClearEncryptedButton
            // 
            this.ClearEncryptedButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEncryptedButton.Location = new System.Drawing.Point(703, 162);
            this.ClearEncryptedButton.Name = "ClearEncryptedButton";
            this.ClearEncryptedButton.Size = new System.Drawing.Size(230, 75);
            this.ClearEncryptedButton.TabIndex = 3;
            this.ClearEncryptedButton.Text = "Clear";
            this.ClearEncryptedButton.UseVisualStyleBackColor = true;
            this.ClearEncryptedButton.Click += new System.EventHandler(this.ClearEncryptedButton_Click);
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionButton.Location = new System.Drawing.Point(11, 162);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(230, 75);
            this.EncryptionButton.TabIndex = 2;
            this.EncryptionButton.Text = "Encrypt";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // TextToBeEncryptedTextBox
            // 
            this.TextToBeEncryptedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.TextToBeEncryptedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextToBeEncryptedTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextToBeEncryptedTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextToBeEncryptedTextBox.Location = new System.Drawing.Point(11, 59);
            this.TextToBeEncryptedTextBox.Name = "TextToBeEncryptedTextBox";
            this.TextToBeEncryptedTextBox.Size = new System.Drawing.Size(922, 96);
            this.TextToBeEncryptedTextBox.TabIndex = 1;
            this.TextToBeEncryptedTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 41);
            this.label10.TabIndex = 0;
            this.label10.Text = "Text to be Encrypted:";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.SidePanel.Controls.Add(this.button2);
            this.SidePanel.Controls.Add(this.PluginButton);
            this.SidePanel.Controls.Add(this.EncryptButton);
            this.SidePanel.Controls.Add(this.HashButton);
            this.SidePanel.Controls.Add(this.HomeButton);
            this.SidePanel.Location = new System.Drawing.Point(1, 176);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(300, 657);
            this.SidePanel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PluginButton
            // 
            this.PluginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.PluginButton.FlatAppearance.BorderSize = 0;
            this.PluginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PluginButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginButton.Location = new System.Drawing.Point(11, 315);
            this.PluginButton.Name = "PluginButton";
            this.PluginButton.Size = new System.Drawing.Size(277, 70);
            this.PluginButton.TabIndex = 4;
            this.PluginButton.Text = "Plugins";
            this.PluginButton.UseVisualStyleBackColor = false;
            this.PluginButton.Click += new System.EventHandler(this.PluginButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.EncryptButton.FlatAppearance.BorderSize = 0;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(11, 215);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(277, 70);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encryption";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // HashButton
            // 
            this.HashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.HashButton.FlatAppearance.BorderSize = 0;
            this.HashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HashButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashButton.Location = new System.Drawing.Point(11, 115);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(277, 70);
            this.HashButton.TabIndex = 1;
            this.HashButton.Text = "Hashing";
            this.HashButton.UseVisualStyleBackColor = false;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(11, 15);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(277, 70);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HorizontalDivider
            // 
            this.HorizontalDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.HorizontalDivider.Location = new System.Drawing.Point(0, 165);
            this.HorizontalDivider.Name = "HorizontalDivider";
            this.HorizontalDivider.Size = new System.Drawing.Size(1296, 10);
            this.HorizontalDivider.TabIndex = 0;
            // 
            // VerticalDivider
            // 
            this.VerticalDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.VerticalDivider.Location = new System.Drawing.Point(295, 176);
            this.VerticalDivider.Name = "VerticalDivider";
            this.VerticalDivider.Size = new System.Drawing.Size(10, 660);
            this.VerticalDivider.TabIndex = 1;
            // 
            // PluginListView
            // 
            this.PluginListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginListView.HideSelection = false;
            this.PluginListView.Location = new System.Drawing.Point(11, 61);
            this.PluginListView.Name = "PluginListView";
            this.PluginListView.Size = new System.Drawing.Size(394, 577);
            this.PluginListView.TabIndex = 1;
            this.PluginListView.UseCompatibleStateImageBehavior = false;
            // 
            // LoadPluginButton
            // 
            this.LoadPluginButton.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPluginButton.Location = new System.Drawing.Point(239, 5);
            this.LoadPluginButton.Name = "LoadPluginButton";
            this.LoadPluginButton.Size = new System.Drawing.Size(166, 54);
            this.LoadPluginButton.TabIndex = 3;
            this.LoadPluginButton.Text = "Load Plugin";
            this.LoadPluginButton.UseVisualStyleBackColor = true;
            this.LoadPluginButton.Click += new System.EventHandler(this.LoadPluginButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(593, 5);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(168, 54);
            this.LoadingLabel.TabIndex = 4;
            this.LoadingLabel.Text = "Loading";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 826);
            this.Controls.Add(this.VerticalDivider);
            this.Controls.Add(this.HorizontalDivider);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sunrise Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PluginPagePanel.ResumeLayout(false);
            this.PluginPagePanel.PerformLayout();
            this.HomePagePanel.ResumeLayout(false);
            this.HomePagePanel.PerformLayout();
            this.HashingPagePanel.ResumeLayout(false);
            this.HashingPagePanel.PerformLayout();
            this.EncryptionPagePanel.ResumeLayout(false);
            this.EncryptionPagePanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel HorizontalDivider;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.Panel VerticalDivider;
        private System.Windows.Forms.Panel HashingPagePanel;
        private System.Windows.Forms.Panel HomePagePanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PluginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TextToBeHashed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HashTypeComboBox;
        private System.Windows.Forms.Button ClearHashString;
        private System.Windows.Forms.Button HashingButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox LowercaseHashBool;
        private System.Windows.Forms.RichTextBox HashedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel EncryptionPagePanel;
        private System.Windows.Forms.RichTextBox EncryptedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox EncryptionTypeComboBox;
        private System.Windows.Forms.Button ClearEncryptedButton;
        private System.Windows.Forms.Button EncryptionButton;
        private System.Windows.Forms.RichTextBox TextToBeEncryptedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CipherShiftTextbox;
        private System.Windows.Forms.Label CipherShiftLabel;
        private System.Windows.Forms.Label KeyNoteLabel;
        private System.Windows.Forms.Panel PluginPagePanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView PluginListView;
        private System.Windows.Forms.Button LoadPluginButton;
        private System.Windows.Forms.Label LoadingLabel;
    }
}

