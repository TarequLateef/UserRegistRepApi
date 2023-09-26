using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistRepApi.Core.Repositories
{
    public interface IBaseRepository<T_DB>where T_DB : class
    {
        IEnumerable<T_DB> GetItems();
        Task<IEnumerable<T_DB>> GetItemsAsync();
        T_DB GetByID(int id);

        Task<T_DB > GetByIDAsync(int id);
        bool AddNewItem(T_DB item);
        Task<bool> AddNewItemAsync(T_DB item);

        bool DeleteItem(T_DB item);
        Task<bool> DeleteItemAsync(T_DB item);
        bool UpdateItem(T_DB item);
        Task<bool > UpdateItemAsync(T_DB item);

        T_DB Find(Expression<Func<T_DB, bool>> match);

    }


}
