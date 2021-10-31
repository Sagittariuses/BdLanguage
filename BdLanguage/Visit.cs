using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdLanguage
{
    public partial class Visit : Form
    {
        public Visit()
        {
            InitializeComponent();
        }
        public Panel Reg()
        {
            Panel panel1 = new Panel();
            panel1.Location = new Point(1, 1);
            panel1.Size = new Size(new Point(528, 247));
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Text = "Регистрация нового";
            label1.Location = new Point(8, 8);
            panel1.Controls.Add(label1);
            return panel1;
        }

        private void Visit_Load(object sender, EventArgs e)
        {
            FullNameLb.Text = Bank.FirstName + " " + Bank.LastName + " " + Bank.Patronymic;
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
