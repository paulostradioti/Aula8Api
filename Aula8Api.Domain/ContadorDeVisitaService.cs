namespace Aula8Api.Domain
{
    public class ContadorDeVisitaService : IContadorDeVisitaService
    {
        private static int _contador = 0;

        public void Incrementar()
            => _contador++;

        public int Count
        {
            get => _contador;
        }
    }

    public interface IContadorDeVisitaService
    {
        public int Count { get; }
        void Incrementar();
    }
}