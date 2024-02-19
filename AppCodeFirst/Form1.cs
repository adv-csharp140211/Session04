using AppCodeFirst.Service;

namespace AppCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsertSampleUser_Click(object sender, EventArgs e)
        {
            var userService = new UserService();
            userService.Add(new Model.User
            {
                NationalCode = "1",
                Name = "Ali",
                UserName = "admin",
                Email = "yechi@yeja.com",
                IsActive = true,
                Password = "password",
                DateOfBirth = DateTime.Now,
            });
            refresh();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            var userService = new UserService();
            dataGridViewUsers.DataSource = userService.GetAll();
        }
    }
}
