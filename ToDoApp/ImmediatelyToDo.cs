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
  
    public partial class ImmediatelyToDo : Form
    {
        
        public List<ToDoData.ToDo> ImmediatelyToDos { get; set; }
        private Controller controller;
        public ImmediatelyToDo(List<ToDoData.ToDo> immediatelyToDos, Controller controller)
        {
            InitializeComponent();
            ImmediatelyToDos = immediatelyToDos;
            listBox.DataSource = immediatelyToDos.Select(x => x.text).ToList();
            this.controller = controller;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isChecked = checkBoxDone.Checked;
            string selectedString = listBox.SelectedItem.ToString();
            DateTime dateTime = dateTimePicker1.Value;
            controller.UpdateData(ImmediatelyToDos,isChecked,selectedString,dateTime);
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            string selectedString = listBox.SelectedItem.ToString();
            DateTime dateTime = controller.SearchDateTime(ImmediatelyToDos, selectedString);
            if (dateTime > DateTime.MinValue)
            {
                dateTimePicker1.Value = dateTime;
            }

        }
    }
}
