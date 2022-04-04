using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SharpOfClans;
using SharpOfClans.Endpoints;
using SharpOfClans.Models;
using SharpOfClans.Paging;
namespace Clash_Of_Clans_Information_Tool
{
    public partial class Form1 : MetroForm
    {
        private const string _TOKEN = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjA0MjE4NjNiLTkxMWItNDQzOC1hMDE4LTc0MmNjMjg2NzkxOSIsImlhdCI6MTY0OTA0NTYyMCwic3ViIjoiZGV2ZWxvcGVyL2ZiMGQ4YmY1LTdhMDktYjllZS01MTZjLTEyYWFkM2ExZjgzNiIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjk5LjI1Mi4xMjIuMTI4Il0sInR5cGUiOiJjbGllbnQifV19.h-QQWiNBV2f7QDI0n1dckIh5FFiAMInrGM4tbDjT3_OkoyrXIfCdV_Yo2jqARd_VNtDeX5fKwTzYh6owga3eLg";
        public Form1()
        {
            InitializeComponent();
        }
        private async void metroButton1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var clashApi = ClashApi.GetInstance(_TOKEN);
            try
            {
                var Player = await clashApi.Players.GetPlayerAsync(textBox1.Text);
                richTextBox1.AppendText($"Username: {Player.Name}");
                richTextBox1.AppendText($"\nTag: {Player.Tag}");
                richTextBox1.AppendText($"\nLeague: {Player.League.Name}");
                richTextBox1.AppendText($"\nTrophies: {Player.Trophies}");
                richTextBox1.AppendText($"\nBest Trophies{Player.BestTrophies}");
                richTextBox1.AppendText($"\nTownhall Level: {Player.TownHallLevel}");
                richTextBox1.AppendText($"\nWar Stars: {Player.WarStars}");
                richTextBox1.AppendText($"\nAttack Wins: {Player.AttackWins}");
                richTextBox1.AppendText($"\nComlpeted Achievements: {Player.Achievements.Count}");
                richTextBox1.AppendText($"\nTotal Donations: {Player.Donations}");
                if (Player.League.Name == "Bronze League I" || Player.League.Name == "Bronze League II" || Player.League.Name == "Bronze League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Silver League I" || Player.League.Name == "Silver League II" || Player.League.Name == "Silver League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Gold League I" || Player.League.Name == "Gold League II" || Player.League.Name == "Gold League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Crystal League I" || Player.League.Name == "Crystal League II" || Player.League.Name == "Crystal League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Master League I" || Player.League.Name == "Master League II" || Player.League.Name == "Master League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Champion League I" || Player.League.Name == "Champion League II" || Player.League.Name == "Champion League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Titan League I" || Player.League.Name == "Titan League II" || Player.League.Name == "Titan League III")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                else if (Player.League.Name == "Legend League")
                {
                    League.Load(Player.League.IconUrls.Medium);
                }
                if(Player.TownHallLevel == 1)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942212820232196146/100.png");
                }else if(Player.TownHallLevel == 2)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942212966525304862/100.png");
                }else if(Player.TownHallLevel == 3)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942212999538679880/100.png");
                }else if(Player.TownHallLevel == 4)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213018404651048/100.png");
                }else if(Player.TownHallLevel == 5)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213039351013416/100.png");
                }else if(Player.TownHallLevel == 6)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213059513024512/100.png");
                }else if(Player.TownHallLevel == 7)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213078978797598/100.png");
                }
                else if (Player.TownHallLevel == 8)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213110767443998/100.png");
                }
                else if (Player.TownHallLevel == 9)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213189960081418/100.png");
                }
                else if (Player.TownHallLevel == 10)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213202635268146/115.png");
                }
                else if (Player.TownHallLevel == 11)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213215847325756/110.png");
                }
                else if (Player.TownHallLevel == 12)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213231131385876/120.png");
                }
                else if (Player.TownHallLevel == 13)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213249175273532/120.png");
                }
                else if (Player.TownHallLevel == 14)
                {
                    TownHall.Load("https://cdn.discordapp.com/attachments/880597112767774761/942213258306261012/110.png");
                }
                if(Player.TownHallLevel < 1)
                {
                    TownHall.Load("");
                }
            }
            catch (ClashApiException ex)
            {
                richTextBox1.Clear();
                MessageBox.Show($"That user either doesn't exist or the ID provided is incorrect.\n\n{ex.Message}", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TownHall.Load("");
                League.Load("");
                return;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon.", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}