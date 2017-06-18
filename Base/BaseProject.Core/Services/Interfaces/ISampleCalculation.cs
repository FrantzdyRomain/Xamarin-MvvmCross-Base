using System;
namespace BaseProject.Core.Services.Interfaces
{
    public interface ISampleCalculationService
    {
        //pulled from sample mvvmcross tutorial app. Add your own services
        double TipAmount(double subTotal, int generosity);
    }
}
