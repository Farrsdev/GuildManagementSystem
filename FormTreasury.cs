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
    public partial class FormTreasury : Form, IUpdatable
    {
        public void RefreshData() => LoadData();
        public FormTreasury()
        {
            InitializeComponent();
        }

        private void FormTreasury_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            using(var db = new GuildDbEntities())
            {
                var dt = db.TreasuryTransactions.Select(x => new
                {
                    TransactionID = x.TransactionID,
                    QuestCode = x.QuestID != null ? x.Quest.QuestCode : "-",
                    PartyQuestCode = x.PartyQuestID != null ? x.PartyQuest.QuestCode : "-",
                    x.TaxAmount,
                    x.CreatedDate
                }).ToList();

                dgvTransactionHistory.DataSource = dt;
                dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransactionHistory.ReadOnly = true;

                var tax = db.TreasuryTransactions.Any() ? db.TreasuryTransactions.Sum(x => x.TaxAmount) : 0;
                lblGuildBalance.Text = tax.ToString();
                lbLTax.Text = tax.ToString();
            }
        }
    }
}
