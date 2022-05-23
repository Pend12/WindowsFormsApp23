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

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public DataTable Data = new DataTable();
        public int posisi = 0;

        private void DataPraktikum()
        {
            textBoxPlayerID.Text = Data.Rows[posisi]["player_id"].ToString();
            textBoxPlayerName.Text = Data.Rows[posisi]["player_name"].ToString();
            comboBoxNationality.DisplayMember = Data.Rows[posisi]["nation"].ToString();
            comboBoxTeam.DisplayMember = Data.Rows[posisi]["team_name"].ToString();
            numericUpDownTeamNumber.Value = Convert.ToInt16(Data.Rows[posisi]["team_number"]);
            dateTimePickerLahir.Value = Convert.ToDateTime(Data.Rows[posisi]["birthdate"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstPosition = 0;
            {
                posisi = 0;
                DataPraktikum();

                if (firstPosition == 0)
                {
                    MessageBox.Show("Data Pertama!");
                    firstPosition = 0;
                }
            }
        }

        private void labelBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            posisi--;
            if (posisi < 0)
            {
                posisi = posisi + 1;
                DataPraktikum();
                MessageBox.Show("Data Pertama!");
            }
            else
            {
                DataPraktikum();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            posisi++;
            if (posisi > 858)
            {
                posisi = posisi - 1;
                DataPraktikum();
                MessageBox.Show("Data Terakhir!");
            }
            else
            {
                DataPraktikum();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            int lastPosition = 0;
            
            {
                posisi = Data.Rows.Count - 1;
                DataPraktikum();
                lastPosition = lastPosition + 1;

                if (lastPosition >= 1)
                {
                    MessageBox.Show("Data Terakhir!");
                    lastPosition = 0;
                }
            }
           
        }

        private void textBoxPlayerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownTeamNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select player.player_id, player.player_name, player.birthdate, nationality.nation, team.team_name, player.team_number, team.team_id from player player, team team, nationality nationality where player.nationality_id = nationality.nationality_id and player.team_id = team.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter= new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Data);

            comboBoxTeam.DataSource = Data;
            comboBoxTeam.ValueMember = "team_name";
            comboBoxTeam.DisplayMember = "team_name";

            comboBoxNationality.DataSource = Data;
            comboBoxNationality.ValueMember = "nation";
            comboBoxNationality.DisplayMember = "nation";
            DataPraktikum();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
