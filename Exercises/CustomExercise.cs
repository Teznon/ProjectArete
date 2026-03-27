using System;
using System.Security.Cryptography.X509Certificates;

public class CustomExercise : Exercise
{
    public CustomExercise(string name, string description, int workingSet, int eorm, int prevBest, float distance)
        : base(name, description, workingSet, eorm, prevBest, distance)
    {

    }

    private Dictionary<string, object> customFields = new Dictionary<string, object>();

    public void renameExercise(string newName)
    {
        if (string.IsNullOrEmpty(newName))
        {
            throw new ArgumentException("New name cannot be empty");
        } else
        {
            Name = newName; 
        }
    }

    public void updateDescription(string newDescription)
    {
        if(string.IsNullOrEmpty(newDescription))
        {
            throw new ArgumentException("New field name cannot be empty");
        } else
        {
            Description = newDescription;
        }
    }

    public void updateWorkingSet(int newWorkingSet)
    {
        if(newWorkingSet <= 0)
        {
            throw new ArgumentException("Working set must be greater than 0");
        }
        else
        {
            WorkingSet = newWorkingSet;
        }
        
    }

    public void addNewField(string fieldName, object value)
    {
        if (string.IsNullOrEmpty(fieldName))
        {
            throw new ArgumentException("Cannot be empty");
        } else
        {
            
        }
    }
}