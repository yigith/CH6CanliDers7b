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
            txtAra = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(497, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(346, 150);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Movie Title";
            lblTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 16F);
            lblYear.Location = new Point(503, 219);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(75, 30);
            lblYear.TabIndex = 2;
            lblYear.Text = "(0000)";
            // 
            // lblRating
            // 
            lblRating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 16F);
            lblRating.Location = new Point(584, 219);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(75, 30);
            lblRating.TabIndex = 3;
            lblRating.Text = "0.0/10";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDescription.Location = new Point(503, 272);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(340, 255);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "...";
            // 
            // btnMoviePage
            // 
            btnMoviePage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMoviePage.Location = new Point(497, 544);
            btnMoviePage.Name = "btnMoviePage";
            btnMoviePage.Size = new Size(346, 23);
            btnMoviePage.TabIndex = 5;
            btnMoviePage.Text = "Open Movie Page on Browser";
            btnMoviePage.UseVisualStyleBackColor = true;
            btnMoviePage.Click += btnMoviePage_Click;
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAra.Location = new Point(560, 22);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(270, 23);
            txtAra.TabIndex = 6;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(529, 25);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 7;
            label1.Text = "Ara";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 579);
            Controls.Add(label1);
            Controls.Add(txtAra);
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
        private TextBox txtAra;
        private Label label1;
    }
}
