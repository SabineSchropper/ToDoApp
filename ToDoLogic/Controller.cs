using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using ToDoData;

namespace ToDoLogic
{
    public class Controller
    {
        Repository repository = new ToDoData.Repository();
        public void AddTask(DateTime dateTime, string text)
        {
            ToDo todo = null;
            if(dateTime != null && !string.IsNullOrEmpty(text))
            {
                todo = new ToDo(dateTime, text);
                todo.date_time = dateTime;
                todo.text = text;
                todo.done = false;

                repository.AddTaskToDatabase(todo);
                     
            }

        }
        public List<ToDo> CheckImmediateToDos()
        {
            List<ToDo> immediateToDos = new List<ToDo>();
            immediateToDos = repository.GetImmediateToDosFromDatabase();

            return immediateToDos;

            throw new NotImplementedException();
            
        }
        public DateTime SearchDateTime(List<ToDo> immediatelyToDos, string selectedString)
        {
            DateTime dateTime = new DateTime();
            foreach(var item in immediatelyToDos)
            {
                if (item.text.Equals(selectedString))
                {
                    dateTime = item.date_time;
                    break;
                }
            }
            return dateTime;
        }
        public void UpdateData(List<ToDo> immediatelyToDos,bool isChecked,string selectedString,DateTime dateTime) 
        {
            ToDo todo = null;
            foreach (var item in immediatelyToDos)
            {
                if (item.text.Equals(selectedString))
                {
                    todo = item;
                    break;
                }
            }
            if(todo != null)
            {
                todo.date_time = dateTime;
                todo.done = isChecked;
                repository.Update(todo);
            }
        }
    }
}
