using System;
using System.Collections.Generic;
using MyWebApi.Models;


public interface ITaskRepository
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task);
    void DeleteTask(TrackerTask task);
}


