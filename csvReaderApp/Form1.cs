using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvReaderApp
{
    public partial class Form1 : Form
    {
        List<UserItem> users = new List<UserItem>();
        public Form1()
        {
            InitializeComponent();

            this.users = UserItem.LoadFile(@"D:\\userItems.csv");
            userGridView.DataSource = this.users;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
