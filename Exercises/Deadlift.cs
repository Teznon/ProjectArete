using System; 

public class Deadlift : Exercise
{
    public Deadlift(int workingSet, int eorm, int prevBest, int distance)
        : base("Deadlift", "Pick up barbell from floor", workingSet, eorm, prevBest, distance){
        
    }
}