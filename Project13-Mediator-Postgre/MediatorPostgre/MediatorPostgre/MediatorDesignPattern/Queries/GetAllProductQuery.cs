using MediatorPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorPostgre.MediatorDesignPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
