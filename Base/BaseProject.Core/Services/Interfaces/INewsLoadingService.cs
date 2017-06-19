using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseProject.Core.Services.Interfaces
{
	public interface INewsLoadingService
	{

		Task<List<string>> LoadNewsFromServer();	
	}
}

