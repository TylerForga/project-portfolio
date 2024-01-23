
namespace ConcertTracker
{
    partial class ViewConcerts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.concertsDataGridView = new System.Windows.Forms.DataGridView();
            this.eventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // concertsDataGridView
            // 
            this.concertsDataGridView.AllowUserToAddRows = false;
            this.concertsDataGridView.AllowUserToDeleteRows = false;
            this.concertsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.concertsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.concertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.concertsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventId,
            this.eventName,
            this.venueName,
            this.stateCode,
            this.eventDate,
            this.minPrice,
            this.maxPrice,
            this.url,
            this.saveButton});
            this.concertsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concertsDataGridView.Location = new System.Drawing.Point(0, 24);
            this.concertsDataGridView.Name = "concertsDataGridView";
            this.concertsDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.concertsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.concertsDataGridView.Size = new System.Drawing.Size(956, 459);
            this.concertsDataGridView.TabIndex = 0;
            this.concertsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.concertsDataGridView_CellContentClick);
            this.concertsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.concertsDataGridView_CellContentDoubleClick);
            // 
            // eventId
            // 
            this.eventId.HeaderText = "eventId";
            this.eventId.Name = "eventId";
            this.eventId.ReadOnly = true;
            this.eventId.Visible = false;
            this.eventId.Width = 68;
            // 
            // eventName
            // 
            this.eventName.FillWeight = 85.27919F;
            this.eventName.HeaderText = "Event Name";
            this.eventName.Name = "eventName";
            this.eventName.ReadOnly = true;
            this.eventName.Width = 84;
            // 
            // venueName
            // 
            this.venueName.FillWeight = 85.27919F;
            this.venueName.HeaderText = "Venue Name";
            this.venueName.Name = "venueName";
            this.venueName.ReadOnly = true;
            this.venueName.Width = 87;
            // 
            // stateCode
            // 
            this.stateCode.FillWeight = 85.27919F;
            this.stateCode.HeaderText = "State";
            this.stateCode.Name = "stateCode";
            this.stateCode.ReadOnly = true;
            this.stateCode.Width = 57;
            // 
            // eventDate
            // 
            this.eventDate.FillWeight = 85.27919F;
            this.eventDate.HeaderText = "Date";
            this.eventDate.Name = "eventDate";
            this.eventDate.ReadOnly = true;
            this.eventDate.Width = 55;
            // 
            // minPrice
            // 
            this.minPrice.FillWeight = 85.27919F;
            this.minPrice.HeaderText = "Minimum Price";
            this.minPrice.Name = "minPrice";
            this.minPrice.ReadOnly = true;
            this.minPrice.Width = 92;
            // 
            // maxPrice
            // 
            this.maxPrice.FillWeight = 85.27919F;
            this.maxPrice.HeaderText = "Maximum Price";
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.ReadOnly = true;
            this.maxPrice.Width = 95;
            // 
            // url
            // 
            this.url.FillWeight = 85.27919F;
            this.url.HeaderText = "Link";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 52;
            // 
            // saveButton
            // 
            this.saveButton.HeaderText = "Save";
            this.saveButton.Name = "saveButton";
            this.saveButton.ReadOnly = true;
            this.saveButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.saveButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.saveButton.Text = "Save Concert";
            this.saveButton.Width = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 1;
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
            // 
            // ViewConcerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(956, 483);
            this.Controls.Add(this.concertsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewConcerts";
            this.Text = "View Concerts";
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView concertsDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn minPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewButtonColumn saveButton;
    }
}