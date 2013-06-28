using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLPServices.DataContracts;

namespace TESTES
{
    class Program
    {
        static void Main(string[] args)
        {
            HLPServices.Services.Services ws = new HLPServices.Services.Services();
            //HLPServices.DataContracts.Log log = new HLPServices.DataContracts.Log();

            //log.xEmpresa = "teste";
            //log.xFormulario = "teste";
            //log.xDetalhes = "teste";
            //log.xAcao = "teste";
            //log.xMessage = "teste";
            //log.xInner = "teste";

            //ws.SetLogError(log);

            List<VersoesModel> lreturn = ws.GetVersoesMagnificus();
        }
    }
}
