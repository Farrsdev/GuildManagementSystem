using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mdilearn
{
    public partial class FormDashboard : Form
    {
        GuildDbEntities db = new GuildDbEntities();
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadStats();
        }

        public void LoadStats()
        {
            lblTotalHunter.Text = db.Hunters.Count().ToString();
            lblTotalMonster.Text = db.Monsters.Count().ToString();
            lblTotalQuest.Text = db.Quests.Count().ToString();
            lblGoldEarn.Text = db.Quests.Sum(x => x.RewardEarned).ToString();

            var topHunter = db.Quests.AsEnumerable().GroupBy(x => x.Hunter.Name).Select(y => new
            {
                Name = y.Key,
                Total = y.Sum(z => z.RewardEarned)
            }).OrderByDescending(x => x.Total).ToList();

            var mostHuntedMonster = db.Quests.AsEnumerable().GroupBy(x => x.Monster.Name).Select(y => new
            {
                Name = y.Key,
                Hunts = y.Count()
            }).OrderByDescending(x => x.Hunts).ToList();

            LoadGrid(dgvTopHunter, topHunter);
            LoadGrid(dgvMostMonster, mostHuntedMonster);
        }

        void LoadGrid(DataGridView dgv,object data)
        {
            dgv.DataSource = data;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
        }
    }
}
