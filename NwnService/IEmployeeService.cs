﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NwnService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [FaultContract(typeof(FaultException))]
        void AddEmployee(Employee employee);

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        Employee GetEmployee(int id);

    }
}
