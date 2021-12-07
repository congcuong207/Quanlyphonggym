using Quanlyphonggym.Entities;
using System;
using System.Collections.Generic;

namespace Quanlyphonggym.DataAccess.ServiceInterface
{
	internal interface IquanlyphieutapDAO
	{
		void GhiThongTin(List<PhieuTap> phieuTaps);
		List<PhieuTap> LayDS();
	}
}
