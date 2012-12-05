using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HLPServices.DataContracts
{
    [DataContract(Namespace = "http://hlp.com.br/WebServices/log")]
    public class Log
    {

        [DataMember(Order = 0)]
        public string xEmpresa { get; set; }

        [DataMember(Order = 1)]
        public string xFormulario { get; set; }

        [DataMember(Order = 2)]
        public string xAcao { get; set; }

        [DataMember(Order = 3)]
        public string xMessage { get; set; }

        [DataMember(Order = 4)]
        public string xInner { get; set; }

        [DataMember(Order = 5)]
        public string xDetalhes { get; set; }

        public DateTime dtOcorrencia { get; set; }

    }
}
