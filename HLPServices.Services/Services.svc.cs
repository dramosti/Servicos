using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HLPServices.DataContracts;
using HLPServices.Repository;

namespace HLPServices.Services
{
    public class Services : IServices
    {

        private bool ProcessaLogError(Log log)
        {
            if (log == null)
            {
                throw new FaultException("É necessário que um objeto do tipo DataContracts.Log seja instanciado !");
            }

            log.dtOcorrencia = DateTime.Now;

            try
            {
                new LogRepository().IncluirRegistroLog(log);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SetLogError(Log log)
        {
            if (ProcessaLogError(log))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
