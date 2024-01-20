

namespace Ecom.Services.Product.Application.Repository
{
    public interface IBaseRepository<T> 
    {

        Task<List<T>> GetAll();

    }
}       