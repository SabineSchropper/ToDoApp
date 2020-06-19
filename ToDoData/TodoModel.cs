using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoData
{
    public partial class ToDo
    {
        public ToDo()
        {

        }
        public ToDo(DateTime dateTime, string text)
        {
            this.text = text;
            date_time = dateTime;
            ///override to string
        }
    }
}
