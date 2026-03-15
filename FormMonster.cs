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
    public partial class FormMonster : Form
    {
        Helper h = new Helper();
        GuildDbEntities db = new GuildDbEntities();
        int _monsterId = 0;

        int MonsterId
        {
            get { return _monsterId; }
            set
            {
                _monsterId = value;
                button2.Text = _monsterId != 0 ? "Edit" : "Tambah";
            }
        }
        public FormMonster()
        {
            InitializeComponent();
        }

        private void FormMonster_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        void LoadDgv()
        {
            var dt = db.Monsters.ToList();

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["MonsterID"].Visible = false;
            dataGridView1.Columns["Quests"].Visible = false;

            h.AddEditDeleteBtnDgv(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var col = dataGridView1.Columns[e.ColumnIndex];
            MonsterId = (int)row.Cells["MonsterID"].Value;

            if (row.Cells["Edit"].Selected)
            {
                txtNm.Text = row.Cells["Name"].Value.ToString();
                cmbxHabitat.Text = row.Cells["Habitat"].Value.ToString();
                txtDangerLv.Text = row.Cells["DangerLevel"].Value.ToString();
                txtReward.Text = row.Cells["RewardGold"].Value.ToString();
                diffMultiplier.Value = Convert.ToDecimal(row.Cells["DifficultyMultiplier"].Value);
            }

            if (col.Name == "Delete" && row.Cells["Delete"].Selected)
            {
                var m = db.Monsters.Find(MonsterId);
                if (m != null)
                {
                    var d = MessageBox.Show($"Apakah yakin menghapus monster {m.Name}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (d == DialogResult.Yes)
                    {
                        db.Monsters.Remove(m);
                        MessageBox.Show($"Monster {m.Name} berhasil dihapus dari daftar");
                        db.SaveChanges();
                        LoadDgv();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h.ClearForm(groupBox2);
            MonsterId = 0;
        }

        private void txtDangerLv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtReward_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEdit();
        }

        void AddEdit()
        {
            if (string.IsNullOrEmpty(txtNm.Text) || string.IsNullOrEmpty(cmbxHabitat.Text) || string.IsNullOrEmpty(txtDangerLv.Text) || string.IsNullOrEmpty(txtReward.Text))
            {
                MessageBox.Show("Semua field harus di isi");
                return;
            }

            if(MonsterId != 0)
            {
                var m = db.Monsters.Find(MonsterId);

                if(m != null)
                {
                    m.DangerLevel = int.Parse(txtDangerLv.Text);
                    m.Name = txtNm.Text;
                    m.RewardGold = int.Parse(txtReward.Text);
                    m.Habitat = cmbxHabitat.Text;
                    m.DifficultyMultiplier = (float)diffMultiplier.Value;
                    db.SaveChanges();
                    MessageBox.Show("Data monster " + m.Name + " Berhasil diedit");
                }
            }
            else
            {
                Monster m = new Monster()
                {
                    Name = txtNm.Text,
                    DangerLevel = int.Parse(txtDangerLv.Text),
                    Habitat = cmbxHabitat.Text,
                    DifficultyMultiplier = (float)diffMultiplier.Value,
                    RewardGold = int.Parse(txtReward.Text)
                };


                db.Monsters.Add(m);
                db.SaveChanges();
                MessageBox.Show("Data monster berhasil ditambah");
            }

            LoadDgv();
        }
    }
}
 