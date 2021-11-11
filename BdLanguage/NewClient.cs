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
    public partial class NewClient : Form
    {
        SqlConnection LanguageConnection = null;
        public NewClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.languageDataSet);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            LanguageConnection = new SqlConnection(@"Data Source=DESKTOP-T664QGA\SQLEXPRESS;Initial Catalog=Language;Integrated Security=True");
            LanguageConnection.Open();
            if (Bank.Clicked)
            {
                NameLB.Text = "Редактировать";
                iDLabel1.Text = Bank.Id;
                lastNameTextBox.Text = Bank.LastName;
                firstNameTextBox.Text = Bank.FirstName;
                patronymicTextBox.Text = Bank.Patronymic;
                if (Bank.Sex == 1)
                    genderCodeComboBox.SelectedIndex = 0;
                else
                    genderCodeComboBox.SelectedIndex = 1;
                phoneTextBox.Text = Bank.Phone;
                emailTextBox.Text = Bank.Email;
                birthdayDateTimePicker.Value = Bank.Bithday;
            } else
            {
                iDLabel1.Text = Bank.LastId;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (LanguageConnection)
            {
                try
                {
                    SqlCommand cmd = LanguageConnection.CreateCommand();
                    if (Bank.Clicked)
                    {
                        cmd.CommandText = "UPDATE Client SET LastName=@FirstName, FirstName=@LastName , Patronymic=@Patronymic, Birthday=@Birthday, Email=@Email, Phone=@Phone, GenderCode=@GenderCode WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                        cmd.Parameters.AddWithValue("@Birthday", birthdayDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@GenderCode", genderCodeComboBox.Text);
                        cmd.Parameters.AddWithValue("@ID", Bank.Id);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Client (ID, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode) values ('" + Convert.ToInt32(iDLabel1.Text) + "','" + lastNameTextBox.Text + "','" + firstNameTextBox.Text + "','" + patronymicTextBox.Text + "','" + birthdayDateTimePicker.Value + "','" + DateTime.Today + "','" + emailTextBox.Text + "','" + phoneTextBox.Text + "','" + genderCodeComboBox.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
