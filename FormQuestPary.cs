using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdilearn
{
    public partial class FormQuestPary : Form
    {
        Helper help = new Helper();
        GuildDbEntities db = new GuildDbEntities();
        int monsterId = 0;
        int reward = 0;
        int? tax = 0;

        public event Action PartyQuestAdded;
        public FormQuestPary()
        {
            InitializeComponent();
        }

        private void FormQuestPary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void ResetForm()
        {
            foreach(int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            
            cmbxStatus.Text = "";
            cmbxMonster.Text = "";
        }
        //Load Data
        #region Load Data
        void LoadData()
        {
            LoadMonster();
            LoadHunter();
            LoadQuestCode();
            LoadReward();
        }
        void LoadReward()
        {
            if(cmbxMonster.SelectedValue != null)
            {
                monsterId = (int)cmbxMonster.SelectedValue;
                reward = help.LoadReward(monsterId, db, cmbxStatus.Text);
                tax = Convert.ToInt32(reward * 0.2);
                txtTotalReward.Text = reward.ToString();

            }

        }
        void LoadMonster()
        {
            var m = db.Monsters.ToList();

            cmbxMonster.ValueMember = "MonsterID";
            cmbxMonster.DisplayMember = "Name";
            cmbxMonster.DataSource = m;
        }

        void LoadHunter()
        {
            var h = db.Hunters.ToList();
            checkedListBox1.DataSource = h;
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "HunterID";
        }

        void LoadQuestCode()
        {
            var date = DateTime.Now.Year;
            int count = db.PartyQuests.Any() ? db.PartyQuests.Count() + 1 : 1;

            string code = $"QSTP-{date}-{count.ToString("D3")}";
            txtQCd.Text = code;
        }




        private void cmbxMonster_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReward();
        }

        private void cmbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReward();
        }
        #endregion


        void AddParty()
        {
            var selectedHunter = checkedListBox1.CheckedItems.Cast<Hunter>().Select(x => x.HunterID).ToList();
            
            if(selectedHunter.Count <= 1)
            {
                MessageBox.Show("Minimal 2 hunter!");
                return;
            }

            PartyQuest pq = new PartyQuest
            {
                QuestCode = txtQCd.Text,
                MonsterID = monsterId,
                Status = cmbxStatus.Text,
                TotalReward = reward,
                HuntDate = dateTimePicker1.Value
            };

            db.PartyQuests.Add(pq);

            TreasuryTransaction t = new TreasuryTransaction
            {
                PartyQuestID = pq.PartyQuestID,
                QuestID = null,
                TaxAmount = tax,
                CreatedDate = DateTime.Now
            };

            db.TreasuryTransactions.Add(t);
            int rewardEarned = reward / selectedHunter.Count;

            foreach(var hunterId in selectedHunter)
            {
                var h = db.Hunters.Find(hunterId);
                if(h != null)
                {
                    int currentSolo = h.Quests.Sum(x => x.RewardEarned) ?? 0;
                    int currentParty = h.PartyMembers.Sum(x => x.RewardEarned) ?? 0;

                    int newTotal = currentSolo + currentParty + rewardEarned;

                    h.Rank = help.CalculateRank(newTotal);
                }
                PartyMember pm = new PartyMember
                {
                    PartyQuestID = pq.PartyQuestID,
                    HunterID = hunterId,
                    RewardEarned = rewardEarned

                };

                db.PartyMembers.Add(pm);
            }

            db.SaveChanges();
            MessageBox.Show("Party berhasil dibuat");
            PartyQuestAdded?.Invoke();
            LoadData();
            ResetForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            AddParty();
        }
    }
}
