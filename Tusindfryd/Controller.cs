using System;

namespace Tusindfryd;

public class Controller
{
    private ProductionRepo _productionRepo;
    private ProductionTrayRepo _productionTrayRepo;
    private GreenhouseRepo _greenhouseRepo;
    private WorkerRepo _workerRepo;
    private SurveyRepo _surveyRepo;
    
    public Controller()
    {
        _productionRepo = new();
        _productionTrayRepo = new();
        _greenhouseRepo = new();
        _workerRepo = new();
        _surveyRepo = new();
    }
    
    public void StartProduction()
    {
        throw new NotImplementedException();
    }
}