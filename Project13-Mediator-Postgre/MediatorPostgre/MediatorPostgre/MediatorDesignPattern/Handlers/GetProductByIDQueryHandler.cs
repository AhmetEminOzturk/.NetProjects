using MediatorPostgre.DAL;
using MediatorPostgre.MediatorDesignPattern.Queries;
using MediatorPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorPostgre.MediatorDesignPattern.Handlers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.Id);
            return new GetProductByIDQueryResult
            {
                CategoryID = value.CategoryID,
                ProductBrand = value.ProductBrand,
                ProductName = value.ProductName,
                ProductID = value.ProductID,
                ProductPrice = value.ProductPrice,
                ProductStock = value.ProductStock,
            };
        }
    }
}
