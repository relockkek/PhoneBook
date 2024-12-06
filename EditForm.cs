using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class EditForm : Form
    {
        private readonly DB db;
        private Human? human;

        public EditForm(DB db)
        {
            InitializeComponent();
            this.db = db;
            human = new Human();


        }

        public EditForm(Human human)
        {
            InitializeComponent();
            this.human = human;
            Adress.Text = human.Address;
            firstname.Text = human.FirstName;
            secondname.Text = human.SecondName;
            thrityname.Text = human.ThrityName;

            Phones.DataSource = human.Phones;
            Phones.DisplayMember = "Number";
            if (File.Exists(human.ImagePath))
            {
                picture.Load(human.ImagePath);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addtelephone_Click(object sender, EventArgs e)
        {

        }

        private void MOBILA_CheckedChanged(object sender, EventArgs e)
        {
            PhoneType phoneType;
            if (MOBILADOMA.Checked)
                  phoneType = PhoneType.Домашний;
            else if (MOBILA.Checked)
                   phoneType = PhoneType.Мобильный;       
                MOBILADOMA.Checked = false;
                MOBILA.Checked = false;
                string number = telephonenumber.Text;
                telephonenumber.Text = string.Empty;
                Phone phone = new Phone { Number = number, Type = phoneType };
                human.Phones.Add(phone);
             

                Phones.DataSource = null;
                Phones.DataSource = human.Phones;
                Phones.DisplayMember = "Number";

            
        }
        private void showPhones()
        {

        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Phones.SelectedIndex == -1)
                return;
            var phone = Phones.SelectedItem as Phone;
            human.Phones.Remove(phone);

        }
        private void telephonenumber_TextChanged(object sender, EventArgs e)
        {

        }
        priva
    }
}
