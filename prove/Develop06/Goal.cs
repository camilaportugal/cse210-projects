public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points; 

    public Goal(string name, string description, string points)
    {
        _shortName = name; 
        _description = description;
        _points = points; 
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = "";
        if(IsComplete())
        {
            status = "[X]";
        }

        else 
        {
            status = "[ ]"; 
        }

        return $"{status} {_shortName} ({_description})";

    }

    public abstract string GetStringRepresentation();
}