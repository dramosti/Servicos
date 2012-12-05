using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HLPServices.DataContracts;

namespace HLPServices.Services
{
    [ServiceContract]
    public interface IServices
    {
        [OperationContract]
        bool SetLogError(Log log);
    }
}
