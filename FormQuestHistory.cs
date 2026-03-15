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
    public partial class FormQuestHistory : Form
    {
        GuildDbEntities db = new GuildDbEntities();
        FormQuest q = new FormQuest();
        int hunterId = 0;
        int monsterId = 0;
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
            var q = db.Quests.AsQueryable();

            if (useFilter)
            {
                if(hunterId != 0)
                {
                    q = q.Where(x => x.HunterID == hunterId);
                }

                if(monsterId != 0)
                {
                    q = q.Where(x => x.MonsterID == monsterId);
                }

                if (chckDateFrom.Checked)
                {
                    DateTime start = dateFrom.Value.Date;
                    q = q.Where(x => x.HuntDate >= start);
                }

                if (chckDateTo.Checked)
                {
                    DateTime end = dateTo.Value.Date.AddDays(1).AddTicks(-1);
                    q = q.Where(x => x.HuntDate <= end);
                }
            }

            var res = q.Select(x => new
            {
                x.QuestCode,
                Hunter = x.Hunter.Name,
                Monster = x.Monster.Name,
                Date = x.HuntDate,
                x.Status,
                Gold = x.RewardEarned
            }).ToList();

            dgvHistory.DataSource = res;
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
    }
}
