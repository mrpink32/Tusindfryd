using System;
using System.Collections.Generic;

namespace Tusindfryd;

public class WorkerRepo: IRepo
{
    private List<Worker> _workers;
    
    public WorkerRepo()
    {
        _workers = new List<Worker>();
    }
    
    public void Add()
    {
        throw new NotImplementedException();
    }

    public Object Get()
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