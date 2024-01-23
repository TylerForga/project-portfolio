
namespace ConcertTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.venueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.artistCheckBox = new System.Windows.Forms.CheckBox();
            this.stateCheckBox = new System.Windows.Forms.CheckBox();
            this.venueCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.genreCheckBox = new System.Windows.Forms.CheckBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(355, 454);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event / Artist:";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Enabled = false;
            this.artistTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.artistTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.artistTextBox.Location = new System.Drawing.Point(393, 76);
            this.artistTextBox.Multiline = false;
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(417, 39);
            this.artistTextBox.TabIndex = 3;
            this.artistTextBox.Text = "Ex. \"Luke Combs\"";
            this.artistTextBox.Enter += new System.EventHandler(this.artistTextBox_Enter);
            this.artistTextBox.Leave += new System.EventHandler(this.artistTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "State:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownHeight = 200;
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.DropDownWidth = 230;
            this.stateComboBox.Enabled = false;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.IntegralHeight = false;
            this.stateComboBox.ItemHeight = 31;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(508, 331);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(159, 39);
            this.stateComboBox.TabIndex = 6;
            // 
            // venueRichTextBox
            // 
            this.venueRichTextBox.Enabled = false;
            this.venueRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.venueRichTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.venueRichTextBox.Location = new System.Drawing.Point(393, 178);
            this.venueRichTextBox.Multiline = false;
            this.venueRichTextBox.Name = "venueRichTextBox";
            this.venueRichTextBox.Size = new System.Drawing.Size(417, 39);
            this.venueRichTextBox.TabIndex = 8;
            this.venueRichTextBox.Text = "Ex. \"Armory\"";
            this.venueRichTextBox.Enter += new System.EventHandler(this.venueRichTextBox_Enter);
            this.venueRichTextBox.Leave += new System.EventHandler(this.venueRichTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name of Venue:";
            // 
            // artistCheckBox
            // 
            this.artistCheckBox.AutoSize = true;
            this.artistCheckBox.Location = new System.Drawing.Point(366, 45);
            this.artistCheckBox.Name = "artistCheckBox";
            this.artistCheckBox.Size = new System.Drawing.Size(15, 14);
            this.artistCheckBox.TabIndex = 9;
            this.artistCheckBox.UseVisualStyleBackColor = true;
            this.artistCheckBox.CheckedChanged += new System.EventHandler(this.artistCheckBox_CheckedChanged);
            // 
            // stateCheckBox
            // 
            this.stateCheckBox.AutoSize = true;
            this.stateCheckBox.Location = new System.Drawing.Point(367, 344);
            this.stateCheckBox.Name = "stateCheckBox";
            this.stateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.stateCheckBox.TabIndex = 10;
            this.stateCheckBox.UseVisualStyleBackColor = true;
            this.stateCheckBox.CheckedChanged += new System.EventHandler(this.stateCheckBox_CheckedChanged);
            // 
            // venueCheckBox
            // 
            this.venueCheckBox.AutoSize = true;
            this.venueCheckBox.Location = new System.Drawing.Point(366, 144);
            this.venueCheckBox.Name = "venueCheckBox";
            this.venueCheckBox.Size = new System.Drawing.Size(15, 14);
            this.venueCheckBox.TabIndex = 11;
            this.venueCheckBox.UseVisualStyleBackColor = true;
            this.venueCheckBox.CheckedChanged += new System.EventHandler(this.venueCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(450, 407);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 59);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(605, 407);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 59);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // genreCheckBox
            // 
            this.genreCheckBox.AutoSize = true;
            this.genreCheckBox.Location = new System.Drawing.Point(366, 264);
            this.genreCheckBox.Name = "genreCheckBox";
            this.genreCheckBox.Size = new System.Drawing.Size(15, 14);
            this.genreCheckBox.TabIndex = 18;
            this.genreCheckBox.UseVisualStyleBackColor = true;
            this.genreCheckBox.CheckedChanged += new System.EventHandler(this.genreCheckBox_CheckedChanged);
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownHeight = 200;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.Enabled = false;
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.IntegralHeight = false;
            this.genreComboBox.ItemHeight = 31;
            this.genreComboBox.Items.AddRange(new object[] {
            "Alternative",
            "Classical",
            "Country",
            "Dance/Electronic",
            "Hip-Hop/Rap",
            "Holiday",
            "Latin",
            "Metal",
            "New Age",
            "Pop",
            "Reggae",
            "Religious",
            "Rock",
            "World"});
            this.genreComboBox.Location = new System.Drawing.Point(508, 252);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(302, 39);
            this.genreComboBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genre:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 478);
            this.Controls.Add(this.genreCheckBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.venueCheckBox);
            this.Controls.Add(this.stateCheckBox);
            this.Controls.Add(this.artistCheckBox);
            this.Controls.Add(this.venueRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Concert Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox artistTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.RichTextBox venueRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox artistCheckBox;
        private System.Windows.Forms.CheckBox stateCheckBox;
        private System.Windows.Forms.CheckBox venueCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox genreCheckBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label label4;
    }
}

