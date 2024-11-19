using Newtonsoft.Json;

namespace Projeto_Consultar_Cnpj.Models
{
    public class CnpjConsulta
    {
        [JsonProperty("cnpj")]
        public string? Cnpj { get; set; }

        [JsonProperty("razao_social")]
        public string? RazaoSocial { get; set; }

        [JsonProperty("nome_fantasia")]
        public string? NomeFantasia { get; set; }

        [JsonProperty("atividade_principal")]
        public AtividadePrincipal? AtividadePrincipal { get; set; }

        [JsonProperty("situacao")]
        public Situacao? Situacao { get; set; }
    }

    public class Situacao
    {
        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("data")]
        public string? Data { get; set; }
    }

    public class AtividadePrincipal
    {
        [JsonProperty("descricao")]
        public string? Descricao { get; set; }
    }

}
