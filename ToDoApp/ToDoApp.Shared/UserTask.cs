using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Shared
{
    public class UserTask : BaseEntity
    {
        public string Header { get; set; }
        public string Epic { get; set; }
        public Priority Priority { get; set; }
        public string TaskCardID { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
        public int BoardColumnId { get; set; }
    }
}
