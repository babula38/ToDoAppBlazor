using System.Collections.Generic;
using System.Linq;

namespace ToDoApp.Shared
{
    public class Appstate
    {
        public static List<UserTask> TaskList
        {


            get
            {
                return new List<UserTask>
                {
                    new UserTask{BoardColumnId=1,ID=1,TaskCardID="Blazor-1",Priority=Priority.High,Title="Read WebAssembly documentation",Epic="Blazor Learning",Status=Status.Done},
                    new UserTask{BoardColumnId=2,ID=2,TaskCardID="Blazor-2",Priority=Priority.High,Title="Install dependencies",Epic="Blazor Learning",Status=Status.Done},
                    new UserTask{BoardColumnId=3,ID=3,TaskCardID="Blazor-3",Priority=Priority.High,Title="Try Hello world",Epic="Blazor Learning",Status=Status.Done},
                    new UserTask{BoardColumnId=4,ID=4,TaskCardID="Blazor-4",Priority=Priority.High,Title="Create some little components",Epic="Blazor Learning",Status=Status.InProgress},
                    new UserTask{BoardColumnId=1,ID=5,TaskCardID="Blazor-5",Priority=Priority.Medium,Title="Create App with Blazor-router",Epic="Blazor Learning",Status=Status.Todo},
                    new UserTask{BoardColumnId=1,ID=6,TaskCardID="Blazor-6",Priority=Priority.Medium,Title="Practise styled-components (Blazor library)",Epic="Blazor Learning",Status=Status.Todo},
                    new UserTask{BoardColumnId=1,ID=7,TaskCardID="Blazor-7",Priority=Priority.LOW,Title="Read Blazor documentation",Epic="Blazor Learning",Status=Status.Todo},
                    new UserTask{BoardColumnId=2,ID=8,TaskCardID="Blazor-8",Priority=Priority.LOW,Title="Do a little project with BlazorJS",Epic="Blazor Learning",Status=Status.Todo},
                };
            }
        }

        public static IEnumerable<UserTask> TodoList
        {
            get
            {
                return TaskList.Where(task => task.Status == Status.Todo);
            }
        }
        public static IEnumerable<UserTask> Done
        {
            get
            {
                return TaskList.Where(task => task.Status == Status.Done);
            }
        }
        public static IEnumerable<UserTask> Inprogress
        {
            get
            {
                return TaskList.Where(task => task.Status == Status.InProgress);
            }
        }

        public static IEnumerable<BoardColumn> BoardColumnList
        {
            get
            {
                return new List<BoardColumn>
                {
                    new BoardColumn{ID=1,Title="To do",Priority=1},
                      new BoardColumn{ID=2,Title="In Progress",Priority=2},
                        new BoardColumn{ID=3,Title="Done",Priority=3},
                          new BoardColumn{ID=4,Title="Done",Priority=4},
                };
            }
        }

    }
}
