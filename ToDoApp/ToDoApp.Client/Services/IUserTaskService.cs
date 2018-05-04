using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Shared;

namespace ToDoApp.Client.Services
{
    public interface IUserTaskService
    {
        List<UserTask> GetUserTaskList();
    }
}
