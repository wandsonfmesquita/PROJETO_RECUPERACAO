namespace Projeto_Recuperacao.Classes
{
    public static class Utils
    {
        public static void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}

