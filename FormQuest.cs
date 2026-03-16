using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdilearn
{
    public partial class FormQuest : Form
    {
        Helper help = new Helper();
        GuildDbEntities db = new GuildDbEntities();
        public event Action QuestAdded;
        int monsterId = 0;
        int hunterId = 0;
        int reward = 0;
        const double guildTax = 0.2;
        public FormQuest()
        {
            InitializeComponent();
        }

        private void FormQuest_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadKode();
        }

        void LoadKode()
        {
            int year = DateTime.Now.Year;
            int questId = db.Quests.Any() ? db.Quests.Max(x => x.QuestID) + 1 : 1;

            string questCode = $"QST-{year}-{questId.ToString("D3")}";

            txtQuestCode.Text = questCode;
        }
        public void LoadHunter(ComboBox cmb)
        {
            var h = db.Hunters.Select(x => new ComboHelper{Id = x.HunterID, Name = x.Name }).ToList();
            var emptyItem = new ComboHelper { Id = 0, Name = "" };

            h.Insert(0, emptyItem);
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";

            cmb.DataSource = h;
        }

        public void LoadMonster(ComboBox cmb)
        {
            var m = db.Monsters.Select(x => new ComboHelper { Id = x.MonsterID, Name = x.Name}).ToList();
            var emptyItem = new ComboHelper { Id = 0, Name = "" };

            m.Insert(0, emptyItem);
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";
            cmb.DataSource = m;
        }

        private void FormQuest_Shown(object sender, EventArgs e)
        {
            LoadHunter(cmbxHunter);
            LoadMonster(cmbxMonster);
        }
        
        private void cmbxMonster_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReward();
        }

        void LoadReward()
        {
            if(cmbxMonster.SelectedValue != null)
            {
                monsterId = (int)cmbxMonster.SelectedValue;

                reward = help.LoadReward(monsterId, db, cmbxStatus.Text);

                txtReward.Text = reward.ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddQuest();   
        }

        void AddQuest()
        {
            if (hunterId == 0 || monsterId == 0)
            {
                MessageBox.Show("Pilih Hunter dan Monster terlebih dahulu!");
                return;
            }
            if (txtRes.Text == "") return;

            int taxAmount = Convert.ToInt32(reward * guildTax);
            reward -= taxAmount;

            Quest q = new Quest
            {
                HunterID = hunterId,
                MonsterID = monsterId,
                HuntDate = dateTimePicker1.Value,
                Result = txtRes.Text,
                QuestCode = txtQuestCode.Text,
                Status = cmbxStatus.Text,
                RewardEarned = reward
            };

            db.Quests.Add(q);
            db.SaveChanges();


            var t = new TreasuryTransaction
            {
                PartyQuestID = null,
                QuestID = q.QuestID,
                TaxAmount = taxAmount,
                CreatedDate = DateTime.Now,
            };
            db.TreasuryTransactions.Add(t);

            var hunter = db.Hunters.Find(hunterId);

            if (hunter != null)
            {
                int totalSolo = hunter.Quests.Sum(x => x.RewardEarned) ?? 0;
                int totalParty = hunter.PartyMembers.Sum(x => x.RewardEarned) ?? 0;

                int _totalReward = totalSolo + totalParty;
                hunter.Rank = help.CalculateRank(_totalReward);
                hunter.Rank = help.CalculateRank(_totalReward);
            }
            db.SaveChanges();

            MessageBox.Show("Quest berhasil dibuat");
            QuestAdded?.Invoke();
            CheckMonsterPopulation();
            LoadDgv();
            help.ClearForm(groupBox2);
        }
        private void cmbxHunter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxHunter.SelectedValue != null)
            {
                hunterId = (int)cmbxHunter.SelectedValue;
            }
        }

        void LoadDgv()
        {
            var q = db.Quests.Select(x => new
            {
                x.QuestID,
                Hunter = x.Hunter.Name,
                Monster = x.Monster.Name,
                x.HuntDate,
                x.RewardEarned,
                x.Result
            }).ToList();

            dataGridView1.DataSource = q;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["QuestID"].Visible = false;

        }
        void CheckMonsterPopulation()
        {
            var huntCount = db.Quests.Count(x => x.MonsterID == monsterId);

            if (huntCount > 10)
            {
                var monster = db.Monsters.Find(monsterId);

                MessageBox.Show(
                    $"⚠ Monster population declining!\n{monster.Name} telah diburu {huntCount} kali.",
                    "Guild Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }   


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbxStatuus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            help.ClearForm(groupBox2);
        }
    }
}
