
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace HTTP_API
{

    public partial class Form1 : Form
    {
        private const string ApiUrl = "https://premier-league-standings1.p.rapidapi.com/?season=";
        private const string ApiKey = "0a53f7d031msh3c4e8e63ebce194p10f77bjsn035382ea188f";
        private const string ApiHost = "premier-league-standings1.p.rapidapi.com";
        public Form1()
        {
            InitializeComponent();
        }
        public class TeamStanding
        {
            public TeamInfo Team { get; set; }
            public TeamStats Stats { get; set; }
        }

        public class TeamInfo
        {
            public string Name { get; set; }
        }

        public class TeamStats
        {
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Ties { get; set; }
            public int Rank { get; set; }
            public int Points { get; set; }
        }


        private List<TeamStanding> ParseResponse(string responseBody)
        {
            List<TeamStanding> standings = new List<TeamStanding>();
            JArray jsonArray = JArray.Parse(responseBody);

            foreach (var item in jsonArray)
            {
                JObject jsonObject = JObject.Parse(item.ToString());
                TeamStanding standing = new TeamStanding();
                standing.Team = jsonObject["team"].ToObject<TeamInfo>();
                standing.Stats = jsonObject["stats"].ToObject<TeamStats>();
                standings.Add(standing);
            }

            return standings;
        }

        private async Task<List<TeamStanding>> GetStandings(string season)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", ApiKey);
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", ApiHost);

                HttpResponseMessage response = await client.GetAsync($"{ApiUrl}{season}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                return ParseResponse(responseBody);
            }
        }

        private void DisplayStandings(List<TeamStanding> standings)
        {
            richTextBox1.Clear();
            foreach (var team in standings)
            {
                richTextBox1.AppendText($"{team.Stats.Rank}\n");
                richTextBox2.AppendText($"{team.Team.Name}\n");
                richTextBox3.AppendText($"{team.Stats.Wins}\n");
                richTextBox4.AppendText($"{team.Stats.Losses}\n");
                richTextBox5.AppendText($"{team.Stats.Ties}\n");
                richTextBox6.AppendText($"{team.Stats.Points}\n");


            }
        }




        private async void button1_Click(object sender, EventArgs e)
        {
            string season = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(season))
            {
                try
                {
                    List<TeamStanding> standings = await GetStandings(season);
                    DisplayStandings(standings);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số năm!");
            }
        }

        
    }
}

