using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcertTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //no selected index property in design viewer. 
            //makes "Minnesota" and "genre" default selection on combo boxes
            stateComboBox.SelectedIndex = 0;
            genreComboBox.SelectedIndex = 0;
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {

            //create a dto to pass user values from GUI to MakeApiRequest in ApiRequestManager
            ApiRequestDto dto = new ApiRequestDto();
            dto.Artist = artistCheckBox.Checked ? artistTextBox.Text : null;
            dto.State = stateCheckBox.Checked ? stateComboBox.SelectedItem.ToString() : null;
            dto.Genre = genreCheckBox.Checked ? genreComboBox.SelectedItem.ToString() : null;
            dto.Venue = venueCheckBox.Checked ? venueRichTextBox.Text : null;

            Dictionary<string, string> userValues = dto.GetNonNullValues();

            
            ApiRequestManager apiRequestManager = new ApiRequestManager();
            List<ConcertData> concerts = await apiRequestManager.MakeApiRequest(userValues);
            
            ViewConcerts viewConcerts = new ViewConcerts();
            viewConcerts.Show();
            if (viewConcerts.CheckConcertDataIsNotEmpty(concerts) == true)
            {
                viewConcerts.PopulateViewConcerts(concerts);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close application
            this.Close();
        }

        private void artistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //enable text box for user selection
            artistTextBox.Enabled = artistCheckBox.Checked;

            //creates default text if checkbox is unchecked
            if (!artistCheckBox.Checked)
            {
                artistTextBox.Text = "Ex. \"Luke Combs\"";
                artistTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void stateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //enable combo box for user selection
            stateComboBox.Enabled = stateCheckBox.Checked;
        }

        private void venueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //enable combo box for user selection
            venueRichTextBox.Enabled = venueCheckBox.Checked;

            //creates default text if checkbox is unchecked
            if (!venueCheckBox.Checked)
            {
                venueRichTextBox.Text = "Ex. \"Armory\"";
                venueRichTextBox.ForeColor = SystemColors.GrayText;
            }
        }
        private void genreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //enable combo box for user selection
            genreComboBox.Enabled = genreCheckBox.Checked;
        }


        private void artistTextBox_Enter(object sender, EventArgs e)
        {
            //gets rid of grey default text when user clicks artist textbox to type
            if (artistTextBox.Text == "Ex. \"Luke Combs\"")
            {
                artistTextBox.Text = "";
                artistTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void artistTextBox_Leave(object sender, EventArgs e)
        {
            //if user leaves textbox blank, recreate default text
            if (string.IsNullOrWhiteSpace(artistTextBox.Text))
            {
                artistTextBox.Text = "Ex. \"Luke Combs\"";
                artistTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void venueRichTextBox_Enter(object sender, EventArgs e)
        {
            //gets rid of grey default text when user clicks artist textbox to type
            if (venueRichTextBox.Text == "Ex. \"Armory\"")
            {
                venueRichTextBox.Text = "";
                venueRichTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void venueRichTextBox_Leave(object sender, EventArgs e)
        {
            //if user leaves textbox blank, recreate default text
            if (string.IsNullOrWhiteSpace(venueRichTextBox.Text))
            {
                venueRichTextBox.Text = "Ex. \"Armory\"";
                venueRichTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //uncheck all boxes and set default state of combo boxes
            artistCheckBox.Checked = false;
            stateCheckBox.Checked = false;
            venueCheckBox.Checked = false;
            genreCheckBox.Checked = false;
            genreComboBox.SelectedIndex = 0;
            stateComboBox.SelectedIndex = 0;

        }


    }
}
