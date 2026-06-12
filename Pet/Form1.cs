using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;

namespace PetApp
{
    public partial class Form1 : Form
    {

        private Pet _pet;
        private static readonly HttpClient client = new HttpClient();
        const string api_key = "?api-key=foo";
        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://virtualpetparty.up.railway.app");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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

        private async void btnCreateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    picPet.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.ToArray();
                }

                string base64Image = Convert.ToBase64String(bytes);

                var data = new { name = _pet.Name, image = base64Image };

                var response = await client.PostAsJsonAsync("/api/room/create" + api_key, data);

                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                string roomCode = result.Trim('"');

                txtRoomCode.Text = roomCode;
                lblVisitor.Text = $"Room created! Share this code: {roomCode}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create room: {ex.Message}");
            }
        }

        private async void btnJoinRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string roomCode = txtRoomCode.Text.Trim();

                if (roomCode.Length != 6)
                {
                    MessageBox.Show("Please enter a valid 6-character room code.");
                    return;
                }

                var response = await client.PostAsJsonAsync("/api/room/join/" + roomCode + api_key, new { });

                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                var room = JsonSerializer.Deserialize<Room>(result);

                Byte[] bitmapData = Convert.FromBase64String(room.visitor.image);
                MemoryStream streamBitmap = new MemoryStream(bitmapData);
                Bitmap b = new Bitmap((Bitmap)Image.FromStream(streamBitmap));

                picVisitor.Image = b;

                lblVisitor.Text = room.visitor.name;

                MessageBox.Show($"{room.visitor.name} came to visit your pet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not join room: {ex.Message}");
            }
        }

        
    }
    public class PetVisitor
    {
        public string name { get; set; }
        public string image { get; set; }
    }

    public class Room
    {
        public PetVisitor visitor { get; set; }
    }
}
