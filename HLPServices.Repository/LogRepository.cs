using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLPServices.DataContracts;

namespace HLPServices.Repository
{
    public class LogRepository
    {
        public void IncluirRegistroLog(Log log)
        {
            using (SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["dbLog"].ConnectionString))
            {
                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = @"INSERT INTO dbo.TAB_LogError 
                                      (xEmpresa
                                      ,xFormulario
                                      ,xAcao
                                      ,xMessage
                                      ,xInner
                                      ,xDetalhes
                                      ,dtOcorrencia)
                                      VALUES (@xEmpresa
                                             ,@xFormulario
                                             ,@xAcao
                                             ,@xMessage
                                             ,@xInner
                                             ,@xDetalhes
                                             ,@dtOcorrencia)";

                cmd.Parameters.AddWithValue("@xEmpresa", log.xEmpresa);
                cmd.Parameters.AddWithValue("@xFormulario", log.xFormulario);
                cmd.Parameters.AddWithValue("@xAcao", log.xAcao == null ? "" : log.xAcao);
                cmd.Parameters.AddWithValue("@xMessage", log.xMessage == null ? "" : log.xMessage);
                cmd.Parameters.AddWithValue("@xInner", log.xInner == null ? "" : log.xInner);
                cmd.Parameters.AddWithValue("@xDetalhes", log.xDetalhes == null ? "" : log.xDetalhes);
                cmd.Parameters.AddWithValue("@dtOcorrencia", log.dtOcorrencia);


                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }

        }
    }
}
