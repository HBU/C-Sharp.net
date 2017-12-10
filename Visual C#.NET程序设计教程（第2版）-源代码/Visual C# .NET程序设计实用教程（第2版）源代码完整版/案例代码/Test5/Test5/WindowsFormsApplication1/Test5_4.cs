using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Test5_4 : Form
    {
        public Test5_4()
        {
            InitializeComponent();
        }

        private void btnCtBase_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            Animal a = new Animal(txtName.Text, age);
            AnimalEat(a);
        }

        private void btnCtChild_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            Dog d = new Dog(txtName.Text, age, txtType.Text);
            AnimalEat(d);
        }
        private void AnimalEat(Animal animal)
        {
            lblShow.Text = animal.Eat();
        }

      
    }
}
