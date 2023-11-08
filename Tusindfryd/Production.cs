using System;

namespace Tusindfryd;

public class Production
{
    public DateTime StartDate { get; set; }

    public Int32 StartAmount { get; set; }
    
    public Int32 ExpectedEndAmount { get; set; }

    public Boolean IsFinished { get; set; }

    public Production()
    {
        throw new NotImplementedException();
    }
}