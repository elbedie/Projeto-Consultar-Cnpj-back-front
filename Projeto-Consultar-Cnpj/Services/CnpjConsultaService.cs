using Newtonsoft.Json;
using Projeto_Consultar_Cnpj.Models;

namespace Projeto_Consultar_Cnpj.Services
{
    public class CnpjConsultaService
    {
        public static async Task<CnpjConsulta?> ConsultarCnpj(string cnpj)
        {
            var requisicao = $"https://api.invertexto.com/v1/cnpj/{cnpj}?token=16139|QL7Hc6Mnyy4tnetcu5O9dmT3Vf7Fw976";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(requisicao);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var consulta = JsonConvert.DeserializeObject<CnpjConsulta>(result);
                    return consulta;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
