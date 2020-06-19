using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoData
{
    public class Repository

    {
        ToDoAppEntities entities = new ToDoAppEntities();
        public void AddTaskToDatabase(ToDo todo)
        {
            entities.ToDo.Add(todo);
            entities.SaveChanges();
        }
        public List<ToDo> GetImmediateToDosFromDatabase()
        {
            var dateTimePlus1 = DateTime.Now.AddHours(1);
            var immediate = entities.ToDo.Where(x => !x.done && (x.date_time >= DateTime.Now
            && x.date_time <= dateTimePlus1)).ToList();
   
            return immediate;
        }
        public void Update(ToDo todo)
        {
            entities.SaveChanges();
        }
    }
}
