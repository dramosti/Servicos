using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HLPServices.DataContracts;
using HLPServices.Repository;
using System.Web.Configuration;
using System.IO;

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


        public List<VersoesModel> GetVersoesMagnificus()
        {
            List<VersoesModel> lReturn = new List<VersoesModel>();
            try
            {
                string sPathFiles = "C:\\Magnificus\\Versoes\\";// WebConfigurationManager.AppSettings["PathFiles"];
                DirectoryInfo dinfo = new DirectoryInfo(sPathFiles);
                VersoesModel versao = null;
                if (Directory.Exists(sPathFiles))
                {
                    foreach (FileInfo file in dinfo.GetFiles("*.zip"))
                    {
                        versao = new VersoesModel();
                        versao.dtArquivo = file.CreationTime.ToString("dd/MM/yyyy");
                        versao.xCaminho = file.FullName;
                        versao.xVersao = file.Name;
                        lReturn.Add(versao);
                    }                    
                }
                return lReturn;
            }
            catch (Exception ex)
            {                
                throw;
            }
            
        }
    }
}
