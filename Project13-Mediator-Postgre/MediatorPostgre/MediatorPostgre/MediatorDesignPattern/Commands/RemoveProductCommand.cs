using MediatR;

namespace MediatorPostgre.MediatorDesignPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
