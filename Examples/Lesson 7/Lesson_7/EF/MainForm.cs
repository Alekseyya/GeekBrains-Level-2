using System;

using System.Windows.Forms;
using EFApplicationCF.Model;
using EFApplicationCF.Method;
using System.Collections.Generic;

namespace EFApplicationCF
{
    public partial class MainForm : Form
    {
        ArtistsController art_controller;
        public MainForm()
        {
            InitializeComponent();
            art_controller = new ArtistsController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IList<Artist> ar_list = art_controller.GetArtists();
            bindingSource1.DataSource = ar_list;
            dataGridView1.DataSource = bindingSource1;

            foreach (Artist artist in ar_list)
            {
                try
                {
                    ICollection<Album> albums = artist.Album;
                }
                catch (Exception ex)
                {

                }
            }
        }
             

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ArtistForm aForm = new ArtistForm();
            DialogResult result = aForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Artist artist = new Artist()
            {     
                Name = aForm.textBoxName.Text,
                Description = aForm.textBoxDescription.Text
            };
            art_controller.InsertArtist(artist);
            MessageBox.Show("Запись добавлена");
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                Artist gridArtist = bindingSource1.Current as Artist;
                int id = gridArtist.Id;

                ArtistForm aForm = new ArtistForm();
                aForm.textBoxName.Text = gridArtist.Name;
                aForm.textBoxDescription.Text = gridArtist.Description;

                DialogResult result = aForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Artist artist = new Artist() { Id=id,
                                               Name =aForm.textBoxName.Text,
                                               Description = aForm.textBoxDescription.Text
                };

                art_controller.UpdateArtist(artist);
                dataGridView1.Refresh();
                MessageBox.Show("Запись изменена");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Artist gridArtist = bindingSource1.Current as Artist;
                int id = gridArtist.Id;

                Artist artist = new Artist() { Id = id };
                art_controller.DeleteArtist(artist);
                MessageBox.Show("Запись удалена");
            }

        }
    }
}
