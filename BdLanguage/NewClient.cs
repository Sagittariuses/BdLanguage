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
            
            if (Bank.Clicked)
            {
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
            using (SqlConnection LanguageConnection = new SqlConnection(@"Data Source=DESKTOP-T664QGA\SQLEXPRESS;Initial Catalog=Language;Integrated Security=True"))
            {
                try
                {
                    LanguageConnection.Open();
                    SqlCommand cmd = LanguageConnection.CreateCommand();
                    if (Bank.Clicked)
                    {
                        cmd.CommandText = "UPDATE INTO Clients values ('" + iDLabel1.Text + "','" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + patronymicTextBox.Text + "','" + birthdayDateTimePicker.Value.ToString() + "','" + Bank.Register.ToString() + "','" + emailTextBox.Text + "','" + phoneTextBox.Text + "','" + genderCodeComboBox.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO [Clients] values ('" + iDLabel1.Text + "','" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + patronymicTextBox.Text + "','" + birthdayDateTimePicker.Value + "','" + DateTime.Today + "','" + emailTextBox.Text + "','" + phoneTextBox.Text + "','" + genderCodeComboBox.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Все сломалось");
                }
                finally
                {
                    LanguageConnection.Close();
                }
            }
            

        }
    }
}
