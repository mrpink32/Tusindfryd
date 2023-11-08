using System;
using System.Collections.Generic;

namespace Tusindfryd;

public class ProductionRepo: IRepo
{
    private List<Production> _productions;
    
    public ProductionRepo()
    {
        _productions = new List<Production>();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Get()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}