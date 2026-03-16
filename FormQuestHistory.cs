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
    public partial class FormQuestHistory : Form, IUpdatable
    {
        GuildDbEntities db = new GuildDbEntities();
        FormQuest q = new FormQuest();
        int hunterId = 0;
        int monsterId = 0;
        public void RefreshData() => LoadQuestHistory();
        public FormQuestHistory()
        {
            InitializeComponent();
        }

        private void FormQuestHistory_Load(object sender, EventArgs e)
        {
            q.LoadMonster(cmbxMonster);
            q.LoadHunter(cmbxHunter);
            LoadQuestHistory(false);
        }


        void LoadQuestHistory(bool useFilter = false)
        {
            string questType = cmbxQuest.Text;
            var soloData = db.Quests.AsEnumerable().Select(x => new
            {
                x.QuestCode,
                HunterName = x.Hunter.Name,
                MonsterName = x.Monster.Name,
                Date = x.HuntDate,
                x.Status,
                Gold = (int?)x.RewardEarned,
                Type = "Solo",
                MonsterID = x.MonsterID,
                HunterIDs = new List<int> { x.HunterID ?? 0 }
            });

            var partyData = db.PartyQuests.AsEnumerable().Select(x => new
            {
                x.QuestCode,
                HunterName = string.Join(", ", x.PartyMembers.Select(z => z.Hunter.Name)),
                MonsterName = x.Monster.Name,
                Date = x.HuntDate,
                x.Status,
                Gold = (int?)x.TotalReward, 
                Type = "Party",
                MonsterID = x.MonsterID,
                HunterIDs = x.PartyMembers.Select(m => m.HunterID ?? 0).ToList()
            });

            var combined = soloData.AsEnumerable().Concat(partyData.AsEnumerable());

            if (questType.ToUpper() == "SOLO") combined = soloData.AsEnumerable();
            else if (questType.ToUpper() == "PARTY") combined = partyData.AsEnumerable();

            if(useFilter)
              {
                if (monsterId != 0)
                    combined = combined.Where(x => x.MonsterID == monsterId);

                if (hunterId != 0)
                    combined = combined.Where(x => x.HunterIDs.Contains(hunterId));

                if (chckDateFrom.Checked)
                    combined = combined.Where(x => x.Date >= dateFrom.Value.Date);

                if (chckDateTo.Checked)
                    combined = combined.Where(x => x.Date <= dateTo.Value.Date.AddDays(1).AddTicks(-1));
            }

            dgvHistory.DataSource = combined
            .OrderByDescending(x => x.Date)
            .Select(x => new {
                x.QuestCode,
                x.Type,
                x.HunterName,
                x.MonsterName,
                x.Date,
                x.Status,
                x.Gold
            }).ToList();
        
        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ReadOnly = true;
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadQuestHistory(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hunterId = 0;
            monsterId = 0;
            cmbxHunter.SelectedIndex = 0;
            cmbxMonster.SelectedIndex = 0;

            chckDateFrom.Checked = false;
            chckDateTo.Checked = false;
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;

            LoadQuestHistory(false);
        }

        private void chckDateTo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckDateFrom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbxHunter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxHunter.SelectedValue is int id) hunterId = id;
        }

        private void cmbxMonster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMonster.SelectedValue is int id) monsterId = id;
        }

        private void cmbxQuest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
