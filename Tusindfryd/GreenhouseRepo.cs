using System.Collections.Generic;

namespace Tusindfryd;

public class GreenhouseRepo: IRepo
{
    private List<Greenhouse> _greenhouses;
    
    public GreenhouseRepo()
    {
        _greenhouses = new List<Greenhouse>();
    }
    
    public void Add()
    {
        throw new System.NotImplementedException();
    }

    public void Get()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }

    public void Delete()
    {
        throw new System.NotImplementedException();
    }
}