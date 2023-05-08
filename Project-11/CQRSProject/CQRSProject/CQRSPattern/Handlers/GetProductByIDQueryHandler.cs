using CQRSProject.CQRSPattern.Queries;
using CQRSProject.CQRSPattern.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.ID);
            return new GetProductByIDQueryResult
            {
                Brand = values.Brand,
                Name = values.Name,
                ProductID = values.ProductID,
            };
        }
    }
}
