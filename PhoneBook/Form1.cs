namespace PhoneBook
{
    public partial class Form1 : Form
    {
        DB db;
        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //поиск
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            List<Human> result = db.Search(search);
            listView1.Items.Clear();
            foreach (Human item in result)
            {
                foreach (Phone phone in item.Phones)
                {
                    ListViewItem row = new ListViewItem();
                    row.Text = item.SecondName;
                    row.Tag = item;
                    row.SubItems.Add(item.FirstName);
                    row.SubItems.Add(item.ThrityName);
                    row.SubItems.Add(phone.Number);
                    row.SubItems.Add(item.Address);
                    listView1.Items.Add(row);
                }
            }
        }
    }
}
