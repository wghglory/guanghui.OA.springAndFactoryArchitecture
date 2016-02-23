 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.EFDAL;
using Guanghui.OA.IDAL;

namespace Guanghui.OA.DALFactory
{
    public partial class DbSession :IDbSession
    {
   
	
		private IActionInfoDal _ActionInfoDal;
		public IActionInfoDal ActionInfoDal
		{
			get
			{
				if (_ActionInfoDal == null)
				{
					_ActionInfoDal = DalFactory.GetActionInfoDal();
				}
				return _ActionInfoDal;
			}
		}
	
		private IBookDal _BookDal;
		public IBookDal BookDal
		{
			get
			{
				if (_BookDal == null)
				{
					_BookDal = DalFactory.GetBookDal();
				}
				return _BookDal;
			}
		}
	
		private IDepartmentDal _DepartmentDal;
		public IDepartmentDal DepartmentDal
		{
			get
			{
				if (_DepartmentDal == null)
				{
					_DepartmentDal = DalFactory.GetDepartmentDal();
				}
				return _DepartmentDal;
			}
		}
	
		private IOrderDal _OrderDal;
		public IOrderDal OrderDal
		{
			get
			{
				if (_OrderDal == null)
				{
					_OrderDal = DalFactory.GetOrderDal();
				}
				return _OrderDal;
			}
		}
	
		private IR_User_ActionInfoDal _R_User_ActionInfoDal;
		public IR_User_ActionInfoDal R_User_ActionInfoDal
		{
			get
			{
				if (_R_User_ActionInfoDal == null)
				{
					_R_User_ActionInfoDal = DalFactory.GetR_User_ActionInfoDal();
				}
				return _R_User_ActionInfoDal;
			}
		}
	
		private IRoleDal _RoleDal;
		public IRoleDal RoleDal
		{
			get
			{
				if (_RoleDal == null)
				{
					_RoleDal = DalFactory.GetRoleDal();
				}
				return _RoleDal;
			}
		}
	
		private ISearchLogDal _SearchLogDal;
		public ISearchLogDal SearchLogDal
		{
			get
			{
				if (_SearchLogDal == null)
				{
					_SearchLogDal = DalFactory.GetSearchLogDal();
				}
				return _SearchLogDal;
			}
		}
	
		private ISearchLogGroupByDal _SearchLogGroupByDal;
		public ISearchLogGroupByDal SearchLogGroupByDal
		{
			get
			{
				if (_SearchLogGroupByDal == null)
				{
					_SearchLogGroupByDal = DalFactory.GetSearchLogGroupByDal();
				}
				return _SearchLogGroupByDal;
			}
		}
	
		private IUserDal _UserDal;
		public IUserDal UserDal
		{
			get
			{
				if (_UserDal == null)
				{
					_UserDal = DalFactory.GetUserDal();
				}
				return _UserDal;
			}
		}
	
		private IUserExtDal _UserExtDal;
		public IUserExtDal UserExtDal
		{
			get
			{
				if (_UserExtDal == null)
				{
					_UserExtDal = DalFactory.GetUserExtDal();
				}
				return _UserExtDal;
			}
		}
	
		private IWF_InstanceDal _WF_InstanceDal;
		public IWF_InstanceDal WF_InstanceDal
		{
			get
			{
				if (_WF_InstanceDal == null)
				{
					_WF_InstanceDal = DalFactory.GetWF_InstanceDal();
				}
				return _WF_InstanceDal;
			}
		}
	
		private IWF_StepDal _WF_StepDal;
		public IWF_StepDal WF_StepDal
		{
			get
			{
				if (_WF_StepDal == null)
				{
					_WF_StepDal = DalFactory.GetWF_StepDal();
				}
				return _WF_StepDal;
			}
		}
	
		private IWF_TempDal _WF_TempDal;
		public IWF_TempDal WF_TempDal
		{
			get
			{
				if (_WF_TempDal == null)
				{
					_WF_TempDal = DalFactory.GetWF_TempDal();
				}
				return _WF_TempDal;
			}
		}
	}

}