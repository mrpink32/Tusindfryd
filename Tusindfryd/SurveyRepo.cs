using System;
using System.Collections.Generic;

namespace Tusindfryd;

public class SurveyRepo: IRepo
{
    private List<Survey> _surveys;
    
    public SurveyRepo()
    {
        _surveys = new List<Survey>();
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