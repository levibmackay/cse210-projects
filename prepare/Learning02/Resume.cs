using System;

public class Resume
{
    public string _name = "";
    public Job[] _jobs = new Job[10];  
    public int _jobCount = 0;          

    public void AddJob(Job j)
    {
        _jobs[_jobCount] = j;
        _jobCount++;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        for (int i = 0; i < _jobCount; i++)
        {
            _jobs[i].Display();
        }
    }
}
