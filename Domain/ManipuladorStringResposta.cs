using System.Text.RegularExpressions;
using System.Text;

namespace ManipuladorString.Domain
{
    public class ManipuladorStringResposta
    {
        public bool Palindromo { get; set; }
        public Dictionary<string, int> Ocorrencias_caracteres { get; set; }

        public ManipuladorStringResposta(string texto)
        {

            Palindromo = VerificarPalindromo(LimparString(texto));
            Ocorrencias_caracteres = ContaQuantidadeDeCaracteres(LimparString(texto));

        }

        public bool VerificarPalindromo(string texto)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = texto.Length - 1; i >= 0; i--)
            {
                sb.Append(texto[i]);
            }

            if (sb.ToString() == texto)
                return true;

            return false;
        }

        public Dictionary<string, int> ContaQuantidadeDeCaracteres(string texto)
        {

            var ocorrencias = new Dictionary<string, int>();
            for (int i = 0; i <= texto.Length - 1; i++)
            {

                if (ocorrencias.ContainsKey(texto[i].ToString()))
                {
                    ocorrencias[texto[i].ToString()] += 1;
                }
                else
                {
                    ocorrencias.Add(texto[i].ToString(), 1);
                }
            }

            return ocorrencias;
        }

        internal string LimparString(string texto)
        {
            texto = new string(texto.Normalize(NormalizationForm.FormD)
                .Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray());

            return Regex.Replace(texto, "[^0-9a-zA-Z]+", "").ToLower();

        }
    }
}
