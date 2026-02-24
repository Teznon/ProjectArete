

public class Food
{
    private string _name;
    private int _calories;
    private int _carbs;
    private int _protein;
    private int _fat;

    protected Food(string Name, int Calories, int Carbs, int Protein, int Fat)
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new ArgumentException("Name cannot be empty");
        } else
        {
            _name = Name;
        }
        
        _calories = Calories;
        _carbs = Carbs;
        _protein = Protein;
        _fat = Fat;
    }
}