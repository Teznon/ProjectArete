

public class Food
{
    private string _name;
    private int _calories;
    private float _carbs;
    private float _protein;
    private float _fat;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Calories
    {
        get { return _calories; }
        set { _calories = value; }
    }
    public float Carbs
    {
        get { return _carbs; }
        set { _carbs = value; }
    }
    public float Protein
    {
        get { return _protein; }
        set { _protein = value; }
    }
    public float Fat
    {
        get { return _fat; }
        set { _fat = value; }
    }
}