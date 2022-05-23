using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_13
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePlayer = new DataTable();
        DataTable dtNation = new DataTable();
        DataTable dtTeam = new DataTable();
        int Position = 0;

        private void txtBoxPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePlayer);
            IsiDataPemain(0);

            sqlQuery = "SELECT n.`nation` as 'nationality', n.nationality_id as 'nationality id' from nationality n";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNation);
            cBoxNationality.DataSource = dtNation;
            cBoxNationality.DisplayMember = "nationality";
            cBoxNationality.ValueMember = "nationality id";
            IsiDataPemain(0);

            sqlQuery = "SELECT t.team_name as 'team name', t.team_id as 'team id' from team t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBoxTeam.DataSource = dtTeam;
            cBoxTeam.DisplayMember = "team name";
            cBoxTeam.ValueMember = "team id";
            IsiDataPemain(0);

        }

        public void IsiDataPemain(int Posisi)
        {
            txtBoxPID.Text = dtTypePlayer.Rows[Posisi][0].ToString();
            txtBoxPName.Text = dtTypePlayer.Rows[Posisi][2].ToString();
            dateTimePicker1.Text = dtTypePlayer.Rows[Posisi][7].ToString();

            numUpDownTeam.Text = dtTypePlayer.Rows[Posisi][1].ToString();
            Position = Posisi;
        }

        public void comboDataPlayer(int Posisi)
        {
            cBoxNationality.Text = dtNation.Rows[Posisi][0].ToString();
            cBoxTeam.Text = dtTeam.Rows[Posisi][0].ToString();
        }

        private void btnLeftEnd_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
            comboDataPlayer(0);
        }

        private void btnRightEnd_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePlayer.Rows.Count - 1);
            comboDataPlayer(dtNation.Rows.Count - 1);
            comboDataPlayer(dtTeam.Rows.Count - 1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (Position > 0)
            {
                Position--;
                IsiDataPemain(Position);
                comboDataPlayer(Position);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if ((Position < dtTypePlayer.Rows.Count - 1) && (Position < dtTeam.Rows.Count - 1) && (Position < dtNation.Rows.Count - 1))
            {
                Position++;
                IsiDataPemain(Position);
                comboDataPlayer(Position);
            }
            else
            {
                MessageBox.Show("The Last Data");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlQuery = $"UPDATE player SET player_name = '" + txtBoxPName.Text + "', team_number = '" + numUpDownTeam.Value.ToString() + "', nationality_id = '" + cBoxNationality.SelectedValue.ToString() + "', team_id = '" + cBoxTeam.SelectedValue.ToString() + "' where player_id = '" + txtBoxPID.Text + "' ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        private void cBoxNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
