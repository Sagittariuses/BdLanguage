using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BdLanguage
{
    public partial class Main : Form
    {
        NewClient client;
        SqlConnection LanguageConnection = null;
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "languageDataSet.Client". При необходимости она может быть перемещена или удалена.
            LanguageConnection = new SqlConnection(@"Data Source=DESKTOP-T664QGA\SQLEXPRESS;Initial Catalog=Language;Integrated Security=True");
            this.clientTableAdapter.Fill(this.languageDataSet.Client);
            LanguageConnection.Open();
            SqlDataAdapter dataAdapterClient = new SqlDataAdapter("WITH C AS ( SELECT A.ID, A.LastName, A.FirstName, A.Patronymic, A.GenderCode, A.Phone, A.Email, A.Birthday, A.RegistrationDate,(Select MAX(B.StartTime) FROM ClientService B WHERE B.ClientID = A.ID) StartTime, (Select COUNT(1) FROM ClientService B WHERE B.ClientID = A.ID) countproc FROM Client A) select ID, LASTNAME, Firstname, Patronymic, GenderCode, Phone, Email, Birthday, RegistrationDate, CASE WHEN StartTime is null then 'Нет таковых' ELSE CAST(StartTime AS VARCHAR) END StartTime, countproc from C", LanguageConnection);

            DataSet db = new DataSet();
            dataAdapterClient.Fill(db);
            ClientDG.DataSource = db.Tables[0];
            ViewCB.SelectedIndex = 3;
            SexCB.SelectedIndex = 2;
            

        }

        private void FLPtb_TextChanged(object sender, EventArgs e)
        {
            string str = FLPtb.Text;
            
            if (str.Contains(' '))
                {
                string[] words = new string[3];
                words = str.Split(' ');
                if (words.Length == 2)
                {
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"FirstName LIKE '%{words[0]}%'";
                    if ((ClientDG.Rows[0].Cells[1].Value as String) != null)
                    {
                        (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"LastName LIKE '%{words[1]}%'";
                    }
                    

                }
                else if (words.Length == 3)
                {
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"FirstName LIKE '%{words[0]}%'";
                    if ((ClientDG.Rows[0].Cells[1].Value as String) != null)
                    {
                        (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"LastName LIKE '%{words[1]}%'";
                        if ((ClientDG.Rows[0].Cells[2].Value as String) != null)
                        {
                            (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"Patronymic LIKE '%{words[2]}%'";
                        }
                    }
                }
            }
            else
            {
                (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"FirstName LIKE '%{str}%'";
            }
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {
            (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"Phone LIKE '%{PhoneTb.Text}%'";
        }

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {
            (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"Email LIKE '%{EmailTb.Text}%'";
        }

        private void ViewCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ViewCB.SelectedIndex)
            {
                case 0:
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"ID <= 10";
                    ViewLb.Text = (ViewCB.SelectedItem as String);
                    
                    break;
                case 1:
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"ID <= 25";
                    ViewLb.Text = (ViewCB.SelectedItem as String);
                    break;
                case 2:
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"ID <= 50";
                    ViewLb.Text = (ViewCB.SelectedItem as String);
                    break;
                case 3:
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = "";
                    ViewLb.Text = (ViewCB.SelectedItem as String);
                    break;
            }
        }

        private void SexCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Code = 0;
            switch (SexCB.SelectedIndex)
            {
                case 0:
                    Code = 1;
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"GenderCode LIKE '%{Code}%'";

                    break;
                case 1:
                    Code = 2;
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = $"GenderCode LIKE  '%{Code}%'";
                    break;
                case 2:
                    (ClientDG.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void NewClientBtn_Click(object sender, EventArgs e)
        {
            int[] chek = new int[ClientDG.Rows.Count];
            for (int i = 0; i < ClientDG.Rows.Count-1; i++)
            {
                chek[i] = Convert.ToInt32(ClientDG.Rows[i].Cells[0].Value.ToString());
            }
            Bank.LastId = (chek.Max()+1).ToString();
            Bank.Clicked = false;
            client = new NewClient();
            client.ShowDialog();
            ClientDG.Refresh();
            SqlDataAdapter dataAdapterClient = new SqlDataAdapter("WITH C AS ( SELECT A.ID, A.LastName, A.FirstName, A.Patronymic, A.GenderCode, A.Phone, A.Email, A.Birthday, A.RegistrationDate,(Select MAX(B.StartTime) FROM ClientService B WHERE B.ClientID = A.ID) StartTime, (Select COUNT(1) FROM ClientService B WHERE B.ClientID = A.ID) countproc FROM Client A) select ID, LASTNAME, Firstname, Patronymic, GenderCode, Phone, Email, Birthday, RegistrationDate, CASE WHEN StartTime is null then 'Нет таковых' ELSE CAST(StartTime AS VARCHAR) END StartTime, countproc from C", LanguageConnection);
            DataSet db = new DataSet();
            dataAdapterClient.Fill(db);
            ClientDG.DataSource = db.Tables[0];
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Bank.Id != null)
            {
                Bank.Clicked = true;
                client = new NewClient();
                client.ShowDialog();
                SqlDataAdapter dataAdapterClient = new SqlDataAdapter("WITH C AS ( SELECT A.ID, A.LastName, A.FirstName, A.Patronymic, A.GenderCode, A.Phone, A.Email, A.Birthday, A.RegistrationDate,(Select MAX(B.StartTime) FROM ClientService B WHERE B.ClientID = A.ID) StartTime, (Select COUNT(1) FROM ClientService B WHERE B.ClientID = A.ID) countproc FROM Client A) select ID, LASTNAME, Firstname, Patronymic, GenderCode, Phone, Email, Birthday, RegistrationDate, CASE WHEN StartTime is null then 'Нет таковых' ELSE CAST(StartTime AS VARCHAR) END StartTime, countproc from C", LanguageConnection);
                DataSet db = new DataSet();
                dataAdapterClient.Fill(db);
                ClientDG.DataSource = db.Tables[0];
            }
        }

        private void ClientDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex+1 < ClientDG.RowCount)
            {
                Bank.Id = ClientDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                Bank.LastName = ClientDG.Rows[e.RowIndex].Cells[1].Value.ToString();
                Bank.FirstName = ClientDG.Rows[e.RowIndex].Cells[2].Value.ToString();
                Bank.Patronymic = ClientDG.Rows[e.RowIndex].Cells[3].Value.ToString();
                Bank.Sex = Convert.ToInt32(ClientDG.Rows[e.RowIndex].Cells[4].Value.ToString());
                Bank.Phone = ClientDG.Rows[e.RowIndex].Cells[5].Value.ToString();
                Bank.Email = ClientDG.Rows[e.RowIndex].Cells[6].Value.ToString();
                Bank.Bithday = Convert.ToDateTime(ClientDG.Rows[e.RowIndex].Cells[7].Value);
                Bank.Register = Convert.ToDateTime(ClientDG.Rows[e.RowIndex].Cells[8].Value);
                Bank.Total = Convert.ToInt16(ClientDG.Rows[e.RowIndex].Cells[10].Value);
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (ViewCB.SelectedIndex < 3)
                ViewCB.SelectedIndex += 1;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if(ViewCB.SelectedIndex > 0 )
                ViewCB.SelectedIndex -= 1;
        }

        private void VisitBtn_Click(object sender, EventArgs e)
        {
            if (Bank.Id != null)
            {
                Visit visit = new Visit();
                visit.ShowDialog();
            }
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Bank.Id != null)
            {
                try
                {
                    SqlCommand cmd =  LanguageConnection.CreateCommand();
                    cmd.CommandText = "DELETE FROM Client WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", Bank.Id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                }
                SqlDataAdapter dataAdapterClient = new SqlDataAdapter("WITH C AS ( SELECT A.ID, A.LastName, A.FirstName, A.Patronymic, A.GenderCode, A.Phone, A.Email, A.Birthday, A.RegistrationDate,(Select MAX(B.StartTime) FROM ClientService B WHERE B.ClientID = A.ID) StartTime, (Select COUNT(1) FROM ClientService B WHERE B.ClientID = A.ID) countproc FROM Client A) select ID, LASTNAME, Firstname, Patronymic, GenderCode, Phone, Email, Birthday, RegistrationDate, CASE WHEN StartTime is null then 'Нет таковых' ELSE CAST(StartTime AS VARCHAR) END StartTime, countproc from C", LanguageConnection);
                DataSet db = new DataSet();
                dataAdapterClient.Fill(db);
                ClientDG.DataSource = db.Tables[0];
            }
                
        }
    }
}
