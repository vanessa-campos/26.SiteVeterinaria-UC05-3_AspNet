using System.Collections.Generic;

namespace Atividade03.Models
{
    public static class BaseDados
    {
        static List<Agendar> dados = new List<Agendar>();

        public static void Inlcuir(Agendar novo)
        {
            dados.Add(novo);
        }

        public static List<Agendar> Listar()
        {
            return dados;
        }
    }
}