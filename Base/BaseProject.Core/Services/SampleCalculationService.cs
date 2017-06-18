using System;
using BaseProject.Core.Services.Interfaces;
namespace BaseProject.Core.Services
{
    public class SampleCalculationService : ISampleCalculationService
    {
		public double TipAmount(double subTotal, int generosity)
		{
			return subTotal * ((double)generosity) / 100.0;
		}
    }
}
