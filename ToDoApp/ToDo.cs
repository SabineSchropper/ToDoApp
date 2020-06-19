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
        Timer timer = null;
        public ToDo()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<ToDoData.ToDo> immediateToDos = new List<ToDoData.ToDo>();
            immediateToDos = controller.CheckImmediateToDos();
            if (immediateToDos.Count > 0)
            {
                timer.Stop();
                var form = new ImmediatelyToDo(immediateToDos, controller);
                form.ShowDialog();
                timer.Start();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value;
            string text = richTb.Text;

            try
            {
                controller.AddTask(dateTime, text);
                MessageBox.Show("Neues ToDo wurde gespeichert.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Konnte nicht auf die Datenbank gespeichert werden");
            }

        }
    }
}
