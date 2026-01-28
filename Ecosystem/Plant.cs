public class Plant : IOrganism
{
    public int Leaves {get; set;}

    public Plant(int leaves)
    {
        this.Leaves = leaves;
    }

    public string GetState()
    {
        return $"I have {this.Leaves} leaves.";
    }

    public void Grow()
    {
        this.Leaves += 1;
    }

    public int Eaten(int nLeaves)
    {        
        if(this.Leaves - nLeaves < 0)
        {
            this.Leaves = 0;
            return this.Leaves;
        }
        else
        {
            this.Leaves -= nLeaves;
            return nLeaves;
        }
    }

    public void Tick()
        {
            Grow();
        }
        
    public void InteractWith(IOrganism other)
  {
    if(other is Animal animal)
    {
      Grow();
      Grow();
    }
  }

}