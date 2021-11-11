using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdLanguage
{
    public partial class Visit : Form
    {
        public SqlConnection LanguageConnection = null;
        public Visit()
        {
            InitializeComponent();
        }


        private void Visit_Load(object sender, EventArgs e)
        {

            FullNameLb.Text = Bank.LastName + " " + Bank.FirstName + " " + Bank.Patronymic;
            LanguageConnection = new SqlConnection(@"Data Source=DESKTOP-T664QGA\SQLEXPRESS;Initial Catalog=Language;Integrated Security=True");
            LanguageConnection.Open();
            string[] ids = new string[1024];
            SqlCommand cmd = LanguageConnection.CreateCommand();
            cmd.CommandText = $"Select STRING_AGG(ID, ',') WITHIN GROUP(ORDER BY ID) FROM ClientService WHERE ClientID = {Bank.Id}";
            string cmd3 = cmd.ExecuteScalar().ToString();
            string Time;
            string Title;
            int lenght = 25;

            if (cmd3.Contains(','))
            {
                ids = cmd3.Split(',');
            } else if (ids.Length == 1024)
            {
                ids[0] = cmd3;
            }
            for (int id = 0; id < ids.Length; id++)
            {
                if (ids[id] == null)
                {
                    break;
                }
                Panel ClientPanel = new Panel();
                ClientPanel.Width = 240;
                ClientPanel.Height = 100;
                ClientPanel.Margin = new Padding(5);
                flowLayoutPanel.Controls.Add(ClientPanel);
                ClientPanel.BackColor = Color.White;
                ClientPanel.BorderStyle = BorderStyle.FixedSingle;
                if (Bank.Total == 0)
                {
                    Label lb = new Label();
                    lb.Text = "Нет таковых посещений";
                    lb.Location = new Point(80,40);
                    ClientPanel.Controls.Add(lb);
                    break;
                }
                else
                {
                    cmd.CommandText = $"Select StartTime FROM ClientService WHERE ID = {ids[id]}";
                    Time = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = $"Select B.Title FROM ClientService A JOIN  Service B ON B.ID = A.ServiceID WHERE A.ID = {ids[id]}";
                    Title = cmd.ExecuteScalar().ToString();
                    if (Title.Length > lenght)
                    {
                        Title = Title.Insert(25, "\n");
                    }
                    List<Label> lbs = new List<Label>()
                    {
                        new Label() { Text = $"Услуга: {Title}", Location = new Point(10, 10), AutoSize = true },
                         new Label() { Text = $"Время: {Time}", Location = new Point(140, 80), AutoSize = true },
                    };
                    ClientPanel.Controls.AddRange(lbs.ToArray());
                }
                this.Show();

            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            LanguageConnection.Close();
            this.Close();
        }
    }
}
