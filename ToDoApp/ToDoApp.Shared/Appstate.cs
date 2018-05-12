using System.Collections.Generic;
using System.Linq;

namespace ToDoApp.Shared
{
    public class Appstate
    {
        static List<UserTask> _UserTaskList;
        static Appstate()
        {
            _UserTaskList = new List<UserTask> {
                    new UserTask { BoardColumnId = 1, ID = 1, TaskCardID = "Blazor-1", Priority = Priority.High, Title = "Read WebAssembly documentation", Epic = "Blazor Learning", Status = Status.Done },
                    new UserTask { BoardColumnId = 2, ID = 2, TaskCardID = "Blazor-2", Priority = Priority.High, Title = "Install dependencies", Epic = "Blazor Learning", Status = Status.Done },
                    new UserTask { BoardColumnId = 3, ID = 3, TaskCardID = "Blazor-3", Priority = Priority.High, Title = "Try Hello world", Epic = "Blazor Learning", Status = Status.Done },
                    new UserTask { BoardColumnId = 4, ID = 4, TaskCardID = "Blazor-4", Priority = Priority.High, Title = "Create some little components", Epic = "Blazor Learning", Status = Status.InProgress },
                    new UserTask { BoardColumnId = 1, ID = 5, TaskCardID = "Blazor-5", Priority = Priority.Medium, Title = "Create App with Blazor-router", Epic = "Blazor Learning", Status = Status.Todo },
                    new UserTask { BoardColumnId = 1, ID = 6, TaskCardID = "Blazor-6", Priority = Priority.Medium, Title = "Practise styled-components (Blazor library)", Epic = "Blazor Learning", Status = Status.Todo },
                    new UserTask { BoardColumnId = 1, ID = 7, TaskCardID = "Blazor-7", Priority = Priority.Low, Title = "Read Blazor documentation", Epic = "Blazor Learning", Status = Status.Todo },
                    new UserTask { BoardColumnId = 2, ID = 8, TaskCardID = "Blazor-8", Priority = Priority.Low, Title = "Do a little project with BlazorJS", Epic = "Blazor Learning", Status = Status.Todo },
                };
        }
        public static List<UserTask> TaskList
        {
            get
            {
                return _UserTaskList;
            }
        }
        public static IEnumerable<BoardColumn> BoardColumnList
        {
            get
            {
                return new List<BoardColumn>
                {
                    new BoardColumn{ID=1,Title="BackLog",Priority=1},
                    new BoardColumn{ID=2,Title="ToDO",Priority=2},
                    new BoardColumn{ID=3,Title="In Progress",Priority=3},
                    new BoardColumn{ID=4,Title="Done",Priority=4},
                };
            }
        }

        public static bool AddUserTask(UserTask userTask)
        {
            _UserTaskList.Add(userTask);
            return true;
        }
    }
}
