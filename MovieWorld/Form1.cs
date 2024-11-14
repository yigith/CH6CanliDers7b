using Npgsql;
using System.Diagnostics;

namespace MovieWorld
{
    public partial class Form1 : Form
    {
        string cs = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=hafta7db";
        NpgsqlConnection con;
        List<Movie> movies = new List<Movie>();
        Movie selectedMovie;

        public Form1()
        {
            con = new NpgsqlConnection(cs);
            con.Open();
            InitializeComponent();
            DisplayMovies();
        }

        private void DisplayMovies()
        {
            var cmd = new NpgsqlCommand("SELECT id, title, year, duration, rating, description FROM movies", con);
            var dr = cmd.ExecuteReader();

            movies = new List<Movie>();
            while (dr.Read())
            {
                movies.Add(new Movie()
                {
                    Id = (string)dr["id"],
                    Title = (string)dr["title"],
                    Year = (int)dr["year"],
                    Duration = (string)dr["duration"],
                    Rating = (decimal)dr["rating"],
                    Description = (string)dr["description"]
                });
            }
            dr.Close();

            // movies listesini datagridview'da göster
            dgvMovies.DataSource = movies;

            // ilk sütunu gizle
            dgvMovies.Columns[0].Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            // seçili satýr yoksa çýk
            if (dgvMovies.SelectedRows.Count == 0)
                return;

            DataGridViewRow seciliSatir = dgvMovies.SelectedRows[0];
            Movie seciliFilm = (Movie)seciliSatir.DataBoundItem;
            selectedMovie = seciliFilm;
            lblTitle.Text = seciliFilm.Title;
            lblYear.Text = "(" + seciliFilm.Year.ToString() + ")";
            lblRating.Text = seciliFilm.Rating + "/10";
            lblDescription.Text = seciliFilm.Description;
        }

        private void btnMoviePage_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/58024/open-a-url-from-windows-forms
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.imdb.com/title/" + selectedMovie.Id,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
