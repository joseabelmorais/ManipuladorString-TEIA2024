namespace ManipuladorString.Domain.DTO
{
    public class ReadManipuladorStringRespostaDto
    {
        public bool Palindromo { get; set; }
        public Dictionary<string, int> Ocorrencias_caracteres { get; set; }
    }
}
