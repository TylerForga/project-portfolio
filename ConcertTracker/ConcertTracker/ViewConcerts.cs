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
    public partial class ViewConcerts : Form
    {
        public ViewConcerts()
        {
            InitializeComponent();
            //dont allow the link column of the datagridview to be autosized and set width to 200px
            concertsDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            concertsDataGridView.Columns[7].Width = 200;

        }

        public void PopulateViewConcerts(List<ConcertData> concertData)
        {
            //clear all rows
            concertsDataGridView.Rows.Clear();
            //populate rows with data from list
            foreach (var concert in concertData)
            {
                concertsDataGridView.Rows.Add(
                    concert.Id,
                    concert.EventName,
                    concert.Venue,
                    concert.State,
                    concert.Date,
                    concert.MinPrice,
                    concert.MaxPrice,
                    concert.Url
                );
            }
            
            
        }
        public bool CheckConcertDataIsNotEmpty(List<ConcertData> concertData)
        {
            //check if list is empty, return true/false and show message box on false
            if (concertData.Count == 0)
            {
                MessageBox.Show("No concerts or events available for that search.");
                Close();
                return false;
            }
            return true;
        }

        private void concertsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO---- method to implement for save button for bookmarks
            //right now save button populates message box with selected row concert information
            if (e.ColumnIndex == concertsDataGridView.Columns["saveButton"].Index && e.RowIndex >= 0)
            {
                string eventName = concertsDataGridView.Rows[e.RowIndex].Cells["eventName"].Value.ToString();
                string venueName = concertsDataGridView.Rows[e.RowIndex].Cells["venueName"].Value.ToString();
                string stateCode = concertsDataGridView.Rows[e.RowIndex].Cells["stateCode"].Value.ToString();
                string eventDate = concertsDataGridView.Rows[e.RowIndex].Cells["eventDate"].Value.ToString();
                double minPrice = (double)concertsDataGridView.Rows[e.RowIndex].Cells["minPrice"].Value;
                double maxPrice = (double)concertsDataGridView.Rows[e.RowIndex].Cells["maxPrice"].Value;
                string eventId = concertsDataGridView.Rows[e.RowIndex].Cells["eventId"].Value.ToString();
                string url = concertsDataGridView.Rows[e.RowIndex].Cells["url"].Value.ToString();

                MessageBox.Show("Save button coming soon!" + eventName + venueName + stateCode + eventDate + minPrice + maxPrice + eventId);
            }

        }

        private void concertsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //double click selected link column cell to open the url to ticketmaster
            if (e.ColumnIndex == concertsDataGridView.Columns["url"].Index && e.RowIndex >= 0)
            {
                string url = concertsDataGridView.Rows[e.RowIndex].Cells["url"].Value.ToString();
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
