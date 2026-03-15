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
    public partial class FormLeaderboard : Form
    {
       public FormLeaderboard()
       {
            InitializeComponent();
       }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss");
        }

        private void FormLeaderboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadLeaderboard();
        }

        public void LoadLeaderboard()
        {
            using(var db = new GuildDbEntities())
            {
                var l = db.Hunters.AsEnumerable().Select(x => new
                {
                    x.Name,
                    x.Rank,
                    Hunts = x.Quests.Count(),
                    Gold = x.Quests.Sum(y => y.RewardEarned)
                }).OrderByDescending(x => x.Gold)
                .Select((d, index) => new
                {
                    No = (index+1),
                    d.Name,
                    d.Rank,
                    d.Hunts,
                    d.Gold
                }).ToList();

                dataGridView1.DataSource = l;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int max = Math.Min(3, dataGridView1.Rows.Count);
            for(int i = 0; i < max; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
//                dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;

            }
        }
    }
}
