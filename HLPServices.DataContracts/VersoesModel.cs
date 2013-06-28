using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HLPServices.DataContracts
{
    [DataContract(Namespace = "http://hlp.com.br/WebServices/log")]
    public class VersoesModel
    {
        public string dtArquivo { get; set; }
        public string xCaminho { get; set; }
        public string xVersao { get; set; }
    }
}
