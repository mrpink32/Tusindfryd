using System;

namespace Tusindfryd;

public class ProductionTray
{
    public String Name { get; set; }

    public Double Area { get; set; }

    public ProductionTray(String name, Double area)
    {
        Name = name;
        Area = area;
    }
}