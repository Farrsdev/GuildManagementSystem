using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdilearn
{
    public partial class Form1 : Form
    {

        //tambahkan action untuk trigger load data di guild overview

        GuildDbEntities db = new GuildDbEntities();
        public Form1()
        {
            InitializeComponent();
        }
       
        void OpenForm<T>() where T:Form, new()
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm is T)
                {
                    frm.Activate();
                    return;
                }
            }

            T form = new T();
            form.MdiParent = this;
            form.Show();
        }
        
        private void hunterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormHunter>();
        }

        private void monsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormMonster>();
        }

        private void questToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questForm = this.MdiChildren.OfType<FormQuest>().FirstOrDefault();

            if(questForm != null)
            {
                questForm.Activate();
            }
            else
            {
                questForm = new FormQuest();
                questForm.MdiParent = this;
                questForm.QuestAdded += QuestForm_QuestAdded;
                questForm.Show();
            }
        }

        private void QuestForm_QuestAdded()
        {
            foreach(var form in this.MdiChildren.OfType<IUpdatable>())
            {
                form.RefreshData();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStatus();
        }

        void LoadStatus()
        {
            int totalHunters = db.Hunters.Any() ? db.Hunters.Count() : 0;
            int totalMonster = db.Monsters.Any() ? db.Monsters.Count() : 0;

            lblStatus.Text = $"Total Hunter: {totalHunters}\n  Total Monster: {totalMonster}";
        }

        private void guildOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormDashboard>();
        }

        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormLeaderboard>();
        }

        private void questHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormQuestHistory>();
        }

        private void treasuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FormTreasury>();
        }

        private void partyQuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var partyQuestForm = this.MdiChildren.OfType<FormQuestPary>().FirstOrDefault();

            if(partyQuestForm != null)
            {
                partyQuestForm.Activate();
            }
            else
            {
                partyQuestForm = new FormQuestPary();
                partyQuestForm.MdiParent = this;
                partyQuestForm.PartyQuestAdded += QuestForm_QuestAdded;
                partyQuestForm.Show();
            }
        }
    }
}
