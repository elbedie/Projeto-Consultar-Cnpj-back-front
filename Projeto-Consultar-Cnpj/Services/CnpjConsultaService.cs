using Newtonsoft.Json;
using Projeto_Consultar_Cnpj.Models;

namespace Projeto_Consultar_Cnpj.Services
{
    public class CnpjConsultaService
    {
        public static async Task<CnpjConsulta?> ConsultarCnpj(string cnpj)
        {
            var requisicao = $"http://ws.hubdodesenvolvedor.com.br/v2/cnpj/?cnpj={cnpj}&token=66842680LqefvPDgFu120682432";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(requisicao);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    var resposta = JsonConvert.DeserializeObject<CnpjResposta>(result);

                    if (resposta != null && resposta.Result != null)
                    {
                        return resposta.Result;  
                    }
                }

                return null;
            }
        }
    }
}
