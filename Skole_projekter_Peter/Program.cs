namespace Skole_projekter_Peter
{

    class Test
    {


        static void Main()
        {
            
            Eye eye1 = new Eye();
            Eye eye2 = new Eye();
            
            
            
            List<Tooth> teeth = new List<Tooth>(32);
            
            
            
            
            

            Body body = new Body(eye1, eye2, teeth);
;


        }
    }

}

class Body
{
    Eye eye1;
    Eye eye2;
    List<Tooth> teeth;

    public Body(Eye eye1, Eye eye2, List<Tooth> teeth) 
    {
        this.eye2 = eye2;
        this.eye1 = eye1;
        this.teeth = teeth;
    }

    public bool IsBlind ()
    {
        if (eye1.IsBlind() && eye2.IsBlind())
        {
            return true;
        }
        return false;
    }

    public int GetCountTeeth()
    {
        
        return 0;
    }


    public int GetCountRottenTeeth()
    {
        // TODO make loop counter
        return 0;
    }


}



class Eye
{
    private bool blind = false;

    public Eye() { }

    public bool IsBlind()
    {
        return blind;
    }

}


class Tooth
{
    private int rotten = 0;
    public Tooth() { }

    public int IsRotten()
    {
        return rotten;
    }

}
