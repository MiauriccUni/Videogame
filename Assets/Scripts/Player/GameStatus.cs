public class GameStatus : Status
{ 
    public int Enhancements { get; set; }
    public GameStatus()
    {

    }

    public bool HasMaxEnhancers()
    {
        return Enhancements == 8;
    }


}