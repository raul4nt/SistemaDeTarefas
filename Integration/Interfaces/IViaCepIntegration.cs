using SistemaDeTarefas.Integration.Response;

namespace SistemaDeTarefas.Integration.Interfaces
{
    public interface IViaCepIntegration
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);

    }
}
