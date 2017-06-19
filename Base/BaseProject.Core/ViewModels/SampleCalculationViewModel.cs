using System;
using BaseProject.Core.Services.Interfaces;
using MvvmCross.Platform;

namespace BaseProject.Core.ViewModels
{
    public class SampleCalculationViewModel : BaseViewModel
    {
		readonly ISampleCalculationService _calculationService;
        readonly INewsLoadingService _newsloadingService;

		double _subTotal;
		public double SubTotal
		{
			get
			{
				return _subTotal;
			}
			set
			{
				_subTotal = value;
				RaisePropertyChanged(() => SubTotal);
				Recalculate();
			}
		}

		int _generosity;
		public int Generosity
		{
			get
			{
				return _generosity;
			}
			set
			{
				_generosity = value;
				RaisePropertyChanged(() => Generosity);
				Recalculate();
			}
		}

		double _tip;
		public double Tip
		{
			get
			{
				return _tip;
			}
			set
			{
				_tip = value;
				RaisePropertyChanged(() => Tip);
			}
		}

		public SampleCalculationViewModel()
        {
            _calculationService = Mvx.Resolve<ISampleCalculationService>();
            _newsloadingService = Mvx.Resolve<INewsLoadingService>(); 
        }

		private void Recalculate()
		{
			Tip = _calculationService.TipAmount(SubTotal, Generosity);
		}
    }
}
