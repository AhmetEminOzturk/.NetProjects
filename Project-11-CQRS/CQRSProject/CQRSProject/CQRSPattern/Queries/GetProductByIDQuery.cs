namespace CQRSProject.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
