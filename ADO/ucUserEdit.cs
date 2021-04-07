using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.DAL;

namespace ADO
{
    public partial class ucUserEdit : UserControl
    {
        private User user;

        public DAL.User User { get => user; set { user = value; bind(); } }

        private void bind()
        {
            if (user != null)
            {
                NameBox.DataBindings.Clear();
                NameBox.DataBindings.Add("Text", user, "Name");
                UserNameBox.DataBindings.Clear();
                UserNameBox.DataBindings.Add("Text", user, "UserName");
                DateBox.DataBindings.Clear();
                DateBox.DataBindings.Add("Value", user, "Date");
            }
        }

        public ucUserEdit()
        {
            InitializeComponent();
        }


    }
}
