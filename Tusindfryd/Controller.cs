using System;

namespace Tusindfryd;

public class Controller
{
    private ProductionRepo _productionRepo;
    private ProductionTrayRepo _productionTrayRepo;
    
    public Controller()
    {
        _productionRepo = new();
        _productionTrayRepo = new();
    }
    
    public void StartProduction()
    {
        throw new NotImplementedException();
    }
}