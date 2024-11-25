using Newtonsoft.Json;

namespace Projeto_Consultar_Cnpj.Models
{

    public class CnpjResposta
    {

        [JsonProperty("result")]
        public CnpjConsulta? Result { get; set; }  // O "result" contém os dados que você precisa
    }

    public class CnpjConsulta
    {
        [JsonProperty("numero_de_inscricao")]
        public string? Cnpj { get; set; }

        [JsonProperty("nome")]
        public string? RazaoSocial { get; set; }

        [JsonProperty("fantasia")]
        public string? NomeFantasia { get; set; }

        [JsonProperty("atividade_principal")]
        public AtividadePrincipal? AtividadePrincipal { get; set; }

        [JsonProperty("situacao")]
        public string? Situacao { get; set; }

        [JsonProperty("dt_situacao_cadastral")]
        public string? Data { get; set; }
    }

    public class AtividadePrincipal
    {
        [JsonProperty("text")]
        public string? Descricao { get; set; }
    }

}
