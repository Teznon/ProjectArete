
/*Summary>
    * This class represents an exercise with properties.
    </Summary>
*/

class Exercise
{
    protected string _name;
    protected string _description;
    protected int _workingSet;
    protected int _EORM;
    protected int _prevBest;
    protected float _distance;
    
    public string Name {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get{ return _description; }
        set{ _description = value; }
    }
    public int workingSet
    {
        get { return _workingSet; }
        set { _workingSet = value; }
    }
    public int EORM
    {
        get { return _EORM; }
        set { _EORM = value; }
    }
    public int prevBest
    {
        get { return _prevBest; }
        set { _prevBest = value; }
    }
    public float distance
    {
        get { return _distance; }
        set { _distance = value;}
    }

}