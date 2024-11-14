namespace MovieWorld
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
            dgvMovies = new DataGridView();
            lblTitle = new Label();
            lblYear = new Label();
            lblRating = new Label();
            lblDescription = new Label();
            btnMoviePage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(12, 22);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersVisible = false;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(468, 545);
            dgvMovies.TabIndex = 0;
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(497, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(346, 163);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Movie Title";
            lblTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 16F);
            lblYear.Location = new Point(503, 194);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(75, 30);
            lblYear.TabIndex = 2;
            lblYear.Text = "(0000)";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 16F);
            lblRating.Location = new Point(584, 194);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(75, 30);
            lblRating.TabIndex = 3;
            lblRating.Text = "0.0/10";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(503, 235);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(340, 273);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "...";
            // 
            // btnMoviePage
            // 
            btnMoviePage.Location = new Point(497, 544);
            btnMoviePage.Name = "btnMoviePage";
            btnMoviePage.Size = new Size(346, 23);
            btnMoviePage.TabIndex = 5;
            btnMoviePage.Text = "Open Movie Page on Browser";
            btnMoviePage.UseVisualStyleBackColor = true;
            btnMoviePage.Click += btnMoviePage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 579);
            Controls.Add(btnMoviePage);
            Controls.Add(lblDescription);
            Controls.Add(lblRating);
            Controls.Add(lblYear);
            Controls.Add(lblTitle);
            Controls.Add(dgvMovies);
            Name = "Form1";
            Text = "Movie World";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovies;
        private Label lblTitle;
        private Label lblYear;
        private Label lblRating;
        private Label lblDescription;
        private Button btnMoviePage;
    }
}
