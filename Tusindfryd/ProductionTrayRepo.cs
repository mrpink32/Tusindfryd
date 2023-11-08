using System.Collections.Generic;

namespace Tusindfryd;

public class ProductionTrayRepo: IRepo
{
    private List<ProductionTray> _productionTrays = new();
    
    public void AddProductionTray(ProductionTray productionTray)
    {
        _productionTrays.Add(productionTray);
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