using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFWebService.Model;

namespace WCFWebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
    [ServiceContract]
    
    public interface IService
    {
        [OperationContract]
        List<Employee> GetListEmp();
        [OperationContract]
        List<Department> GetListDep();
        //Для employee
        
        [OperationContract]
        Employee GetItemEmp(int id);
        [OperationContract]
        void CreateEmp(Employee item);
        [OperationContract]
        void DeleteEmp(int id);
        [OperationContract]
        void UpdateEmp(Employee item);
    }
}
