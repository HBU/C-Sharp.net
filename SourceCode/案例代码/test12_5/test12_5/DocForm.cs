using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test11_6
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }
        public RichTextBox Source
        {
            get
            {
                return txtSource;
            }
            set
            {
                txtSource = value;
            }
        }
        }
}
