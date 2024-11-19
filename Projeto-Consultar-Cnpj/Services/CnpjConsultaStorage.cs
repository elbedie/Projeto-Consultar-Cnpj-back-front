using Projeto_Consultar_Cnpj.Models;
using System.Collections.Generic;

namespace Projeto_Consultar_Cnpj.Services
{
    public static class CnpjConsultaStorage
    {
        // Lista estática para armazenar as consultas
        private static List<CnpjConsulta> consultasRealizadas = new List<CnpjConsulta>();

        // Método para adicionar uma consulta à lista
        public static void AdicionarConsulta(CnpjConsulta consulta)
        {
            consultasRealizadas.Add(consulta);
        }

        // Método para recuperar todas as consultas realizadas
        public static List<CnpjConsulta> ObterConsultas()
        {
            return consultasRealizadas;
        }
    }
}
