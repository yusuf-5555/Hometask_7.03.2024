public class Gauge
{
   public int value { get; set; }

    public Gauge()
    {
        
    }
    public Gauge(int value)
    {
        this.value = value;
    }
    public void Enhance()
    {
        if(value<=5)
        {
            value++;
        }
    }
    public void Decrease()
    {
        if(value>0)
        {
            value--;
        }
    }
    public bool Full()
    {
        if(value==5)return true;
        else return false;
    }

}