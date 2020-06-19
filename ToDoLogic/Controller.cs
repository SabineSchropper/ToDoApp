using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoData;

namespace ToDoLogic
{
    public class Controller
    {
        public void AddTask(DateTime dateTime, string text)
        {
            ToDo todo = null;
            if(dateTime != null && !string.IsNullOrEmpty(text))
            {
                todo = new ToDo(dateTime, text);
            }

            
        }
    }
}
