using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoLogic;

namespace ToDoApp
{
    public partial class ToDo : Form
    {
        Controller controller = new Controller();
        public ToDo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value;
            string text = richTb.Text;

            controller.AddTask(dateTime, text);


        }
    }
}
