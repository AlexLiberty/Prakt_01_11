namespace Prakt_01_11
{
    public partial class Form1 : Form
    {
        private List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string phone = textBox3.Text;
            Person newPerson = new Person(firstName, lastName, phone);
            people.Add(newPerson);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            UpdateTableLayoutPanel();
        }
        private void UpdateTableLayoutPanel()
        {
            tableLayoutPanel1.Controls.Clear();

            int row = 0;
            foreach (Person person in people)
            {
                ListBox newListBox = new ListBox();
                newListBox.Dock = DockStyle.Fill;
                newListBox.Items.Add($"First Name: {person.FirstName}");
                newListBox.Items.Add($"Last Name: {person.LastName}");
                newListBox.Items.Add($"Phone: {person.Phone}");
                newListBox.Items.Add("\n\n");

                tableLayoutPanel1.Controls.Add(newListBox, 0, row);
                row++;
            }
        }
    }
}