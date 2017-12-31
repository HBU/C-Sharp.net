using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp4_1
{
    public partial class Exp4_1 : Form
    {
        public Exp4_1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            if (phone == "") phone = null;
            string email = txtEmail.Text;
            if (email == "") email = null;
            AddressBook ab = new AddressBook(name, phone, email);
            lblShow.Text = ab.GetMessage();


        }
    }
    class AddressBook
    {
        private string name;
        private string phone;
        private string email;
        public AddressBook(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        public AddressBook(string name) 
        {
            this.name=name;
        }
        public string Name
        {
            get { return name; }
        }
        public string Phone
        {
            get
            {
                if (phone == null) return "末输入";
                else return phone;
            }
            set
            {
                phone =value;
            }
        }
        public string Email
        {
            get
            {
                if (email == null) return "末输入";
                else return email;
            }
            set
            {
                phone = value;
            }
        }
        public string GetMessage()
        {
            return string.Format("姓名：{0}\n电话：{1}\nEmail:{2}", Name, Phone, Email);
        }
    }

}
