using MediatR;

namespace MediatorTreinaWeb.Application.Commands
{
    public class ExcluiPessoaCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
