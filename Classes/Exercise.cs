using System;
using System.Diagnostics;
using AuthenticationServices;
using AVFoundation;

/*Summary>
    * This class represents an exercise with properties.
    </Summary>
*/

public abstract class Exercise
{
    public string Name { get; protected set; } = String.Empty;
    public string Description { get; protected set; } = String.Empty;

    public int WorkingSet { get; protected set; }
    public int EORM { get; protected set; }
    public int PrevBest { get; protected set; }
    public float Distance { get; protected set; }
    

    //Constructor 
    protected Exercise(string name, string description, int workingSet, int eorm, int prevBest, float distance)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty");
        } else
        {
            Name = name;
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            Description = "";
        } else
        {
            Description = description;
        }
        
        WorkingSet = workingSet;
        EORM = eorm;
        PrevBest = prevBest;
        Distance = distance;

    }

    public void updatePrevBest(int newBest)
    {
        if(newBest > PrevBest)
        {
            PrevBest = newBest;
        }
    }

    public int calculateEORM(int workingSet, int reps)
    {
        return (int)(workingSet * (1 + reps / 30.0));
    }

    
}