using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdilearn
{
    public class Helper
    {
        public void AddEditDeleteBtnDgv(DataGridView dgv)
        {
            if (dgv.Columns["Edit"] == null)
            {
                var btnEdit = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    UseColumnTextForButtonValue = true,
                    Text = "Edit"
                };

                dgv.Columns.Add(btnEdit);
            }

            if (dgv.Columns["Delete"] == null)
            {
                var btndel = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    UseColumnTextForButtonValue = true,
                    Text = "Delete"
                };

                dgv.Columns.Add(btndel);
            }
        }
        
        public int LoadReward(int monsterId, GuildDbEntities db, string status)
        {
            int reward = 0;
            var monster = db.Monsters.Find(monsterId);

            if(monster != null)
            {
                reward = (int)(monster.RewardGold * monster.DifficultyMultiplier);

                if(status.ToLower() == "failed")
                {
                    reward = 0;
                }
            }

            return reward;
        }

        public string CalculateRank(int? _totalReward = 0)
        {
            return _totalReward > 150000 ? "SSS" : _totalReward > 50000 ? "SS" : _totalReward > 20000 ? "S"
                    : _totalReward >= 10000 && _totalReward <= 20000 ? "A"
                    : _totalReward >= 5000 && _totalReward < 10000 ? "B"
                    : "C";
        }
        public void ClearForm(GroupBox gb)
        {
            gb.Controls.Cast<Control>().Where(x => x is TextBox || x is ComboBox).ToList().ForEach(y => y.Text = "");
        }
    }

    public class ComboHelper
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
