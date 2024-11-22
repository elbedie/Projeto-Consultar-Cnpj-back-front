using Projeto_Consultar_Cnpj.Models;
using System.Collections.Generic;

namespace Projeto_Consultar_Cnpj.Services
{
    public static class CnpjConsultaStorage
    {
        private static List<CnpjConsulta> consultasRealizadas = new List<CnpjConsulta>();

        public static void AdicionarConsulta(CnpjConsulta consulta)
        {
            consultasRealizadas.Add(consulta);
        }

        public static List<CnpjConsulta> ObterConsultas()
        {
            return consultasRealizadas;
        }
    }
}
