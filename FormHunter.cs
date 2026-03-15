using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdilearn
{
    public partial class FormHunter : Form
    {
        Helper h = new Helper();
        GuildDbEntities db = new GuildDbEntities();
        int? _totalReward = 0;
        string _rank = "";
        private int _hunterId = 0;
        int? totalReward
        {
            get
            {
                return _totalReward;
            }
            set
            {
                _totalReward = value;
                rank = _totalReward > 150000 ? "SSS" : _totalReward > 50000 ? "SS" : _totalReward > 20000 ? "S" 
                    : _totalReward >= 10000 && _totalReward <= 20000 ? "A" 
                    : _totalReward >= 5000 && _totalReward < 10000 ? "B" 
                    : "C";
                txtRank.Text = rank;
            }
        }
        public string rank {
            get
            {
                return _rank;
            }
            set
            {
                _rank = value;
                txtRank.Text = _rank;
            }
        }
        public int HunterId {
            get
            {
                return _hunterId;
            }
            set
            {
                _hunterId = value;
                button2.Text = _hunterId != 0 ? "Edit" : "Tambah";
                if (_hunterId == 0) rank = "C";
            }
        }
        public FormHunter()
        {
            InitializeComponent();
        }

        private void FormHunter_Load(object sender, EventArgs e)
        {
            LoadDgv();
            txtRank.Enabled = false;
            HunterId = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h.ClearForm(groupBox2);
            HunterId = 0;
        }

        public void LoadDgv()
        {
            using(var db = new GuildDbEntities())
            {
                var dt = db.Hunters.ToList();

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;

                dataGridView1.Columns["HunterID"].Visible = false;
                dataGridView1.Columns["Quests"].Visible = false;
                h.AddEditDeleteBtnDgv(dataGridView1);
            }
        }

        void AddEdit()
        {
            if(string.IsNullOrEmpty(txtNm.Text) || string.IsNullOrEmpty(txtRank.Text) || string.IsNullOrEmpty(cmbxWeapon.Text))
            {
                MessageBox.Show("Semua field harus di isi");
                return;
            }

            if(HunterId != 0)
            {
                var h = db.Hunters.Find(HunterId);

                if(h != null)
                {
                    h.Name = txtNm.Text;
                    h.Weapon = cmbxWeapon.Text;
                    h.Rank = txtRank.Text;
                }

                db.SaveChanges();
                MessageBox.Show($"Data hunter {h.Name} berhasil di edit");
            }
            else
            {
                var h = new Hunter
                {
                    Name = txtNm.Text,
                    Rank = txtRank.Text,
                    Weapon = cmbxWeapon.Text,
                    JoinDate = DateTime.Now
                };

                db.Hunters.Add(h);
                db.SaveChanges();
                MessageBox.Show("Hunter berhasil ditambahkan ke guild");
            }
            LoadDgv();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var col = dataGridView1.Columns[e.ColumnIndex];
           
            HunterId = (int)row.Cells["HunterID"].Value;
          
            var total = db.Quests.Where(x => x.HunterID == HunterId).Sum(x => x.RewardEarned);
            totalReward = total;
            if (row.Cells["Edit"].Selected)
            {
                txtNm.Text = row.Cells["Name"].Value.ToString();
                cmbxWeapon.Text = row.Cells["Weapon"].Value.ToString();
                txtRank.Text = rank;
            }
            
            if(col.Name == "Delete" && row.Cells["Delete"].Selected)
            {
                var h = db.Hunters.Find(HunterId);
                if(h != null)
                {
                    var d = MessageBox.Show($"Apakah yakin mengeluarkan hunter {h.Name}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(d == DialogResult.Yes)
                    {
                        db.Hunters.Remove(h);
                        MessageBox.Show($"Hunter {h.Name} berhasil dikeluarkan");
                        db.SaveChanges();
                        LoadDgv();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEdit();
        }

        private void txtNm_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
