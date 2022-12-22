using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8Api.Domain
{
    public class ContadorDeVisitaArquivoService : IContadorDeVisitaService
    {
        private FileInfo _file = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "contador.txt"));

        public int Count
        {
            get => LerDoArquivo();
        }

        public void Incrementar()
        {
            var count = Count;
            ScreverNoArquivo(count + 1);
        }

        private void ScreverNoArquivo(int contador)
        {
            File.WriteAllText(_file.FullName, contador.ToString());
        }


        private int LerDoArquivo()
        {
            
            if (!_file.Exists)
            {
                File.WriteAllText(_file.FullName, "0");
                return 0;
            }

            var conteudo = int.Parse(File.ReadAllText(_file.FullName));
            return conteudo;
        }
    }
}
