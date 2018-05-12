using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Services;
using ToDoApp.Shared;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Microsoft.AspNetCore.Blazor;

namespace ToDoApp.Client.Services
{
    public class UserTaskService : IUserTaskService
    {
        private HttpClient httpClient;
        public UserTaskService(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<List<UserTask>> GetUserTaskListAsync()
        {
            UserTask[] userTaskList = await httpClient.GetJsonAsync<UserTask[]>("/api/usertask");
            return userTaskList.ToList();
        }
    }
}
