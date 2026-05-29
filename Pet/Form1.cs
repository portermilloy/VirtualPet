using System.IO;
using System.Drawing;

namespace PetApp
{
    public partial class Form1 : Form
    {

        private Pet _pet;
        public Form1()
        {
            InitializeComponent();
            _pet = Pet.Load();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblStatus.Text = _pet.Name + " | Mood: " + _pet.CurrentMood + " | Stage: " + _pet.CurrentStage + " | Age: " + _pet.AgeMinutes;
            UpdateArt();
        }

        private void UpdateArt()
        {

            string stage = _pet.CurrentStage.ToString().ToLower();
            string mood = _pet.CurrentMood.ToString().ToLower();
            string path = "Images\\" + stage + "_" + mood + ".png";
            if (File.Exists(path))
            {
                picPet.Image = Image.FromFile(path);
            }
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            _pet.Tick();
            _pet.Save();
            UpdateUI();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            _pet.PetAnimal();
            _pet.Save();
            UpdateUI();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            _pet.Feed();
            _pet.Save();
            UpdateUI();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _pet.Tick();
            _pet.Save();
            UpdateUI();
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                _pet.Name = txtName.Text;
                _pet.Save();
                UpdateUI();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
