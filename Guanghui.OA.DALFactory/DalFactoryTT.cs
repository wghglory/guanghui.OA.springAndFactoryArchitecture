 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Guanghui.OA.IDAL;

namespace Guanghui.OA.DALFactory
{
    /// <summary>
    /// 简单工厂或者抽象工厂。
    /// </summary>
    public partial class DalFactory
    {  
		
		public static IActionInfoDal GetActionInfoDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".ActionInfoDal", true);
			//return obj as IActionInfoDal;

			string fullClassName = NameSpace + ".ActionInfoDal";
            return CreateInstance(fullClassName) as IActionInfoDal;
        }
		
		public static IBookDal GetBookDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".BookDal", true);
			//return obj as IBookDal;

			string fullClassName = NameSpace + ".BookDal";
            return CreateInstance(fullClassName) as IBookDal;
        }
		
		public static IDepartmentDal GetDepartmentDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".DepartmentDal", true);
			//return obj as IDepartmentDal;

			string fullClassName = NameSpace + ".DepartmentDal";
            return CreateInstance(fullClassName) as IDepartmentDal;
        }
		
		public static IOrderDal GetOrderDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".OrderDal", true);
			//return obj as IOrderDal;

			string fullClassName = NameSpace + ".OrderDal";
            return CreateInstance(fullClassName) as IOrderDal;
        }
		
		public static IR_User_ActionInfoDal GetR_User_ActionInfoDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".R_User_ActionInfoDal", true);
			//return obj as IR_User_ActionInfoDal;

			string fullClassName = NameSpace + ".R_User_ActionInfoDal";
            return CreateInstance(fullClassName) as IR_User_ActionInfoDal;
        }
		
		public static IRoleDal GetRoleDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".RoleDal", true);
			//return obj as IRoleDal;

			string fullClassName = NameSpace + ".RoleDal";
            return CreateInstance(fullClassName) as IRoleDal;
        }
		
		public static ISearchLogDal GetSearchLogDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".SearchLogDal", true);
			//return obj as ISearchLogDal;

			string fullClassName = NameSpace + ".SearchLogDal";
            return CreateInstance(fullClassName) as ISearchLogDal;
        }
		
		public static ISearchLogGroupByDal GetSearchLogGroupByDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".SearchLogGroupByDal", true);
			//return obj as ISearchLogGroupByDal;

			string fullClassName = NameSpace + ".SearchLogGroupByDal";
            return CreateInstance(fullClassName) as ISearchLogGroupByDal;
        }
		
		public static IUserDal GetUserDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserDal", true);
			//return obj as IUserDal;

			string fullClassName = NameSpace + ".UserDal";
            return CreateInstance(fullClassName) as IUserDal;
        }
		
		public static IUserExtDal GetUserExtDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserExtDal", true);
			//return obj as IUserExtDal;

			string fullClassName = NameSpace + ".UserExtDal";
            return CreateInstance(fullClassName) as IUserExtDal;
        }
		
		public static IWF_InstanceDal GetWF_InstanceDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".WF_InstanceDal", true);
			//return obj as IWF_InstanceDal;

			string fullClassName = NameSpace + ".WF_InstanceDal";
            return CreateInstance(fullClassName) as IWF_InstanceDal;
        }
		
		public static IWF_StepDal GetWF_StepDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".WF_StepDal", true);
			//return obj as IWF_StepDal;

			string fullClassName = NameSpace + ".WF_StepDal";
            return CreateInstance(fullClassName) as IWF_StepDal;
        }
		
		public static IWF_TempDal GetWF_TempDal()
        {
            
            //object obj = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".WF_TempDal", true);
			//return obj as IWF_TempDal;

			string fullClassName = NameSpace + ".WF_TempDal";
            return CreateInstance(fullClassName) as IWF_TempDal;
        }
	}

}