using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UserRegistRepApi.Core.Repositories;

namespace UserRegistRepApi.Ef.Repositoris
{
    public class BaseRepository<Table> : IBaseRepository<Table> where Table : class
    {
        public RegistUser_DBContext _dbContext;
        public BaseRepository(RegistUser_DBContext context)
        {
            _dbContext=context;
        }
        public bool AddNewItem(Table item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(Table item)
        {
            throw new NotImplementedException();
        }

        public Table GetByID(int id) => _dbContext.Set<Table>().Find(id);

        public async Task<Table> GetByIDAsync(int id)=>await _dbContext.Set<Table>().FindAsync(id);

        public IEnumerable<Table> GetItems()=>this._dbContext.Set<Table>().ToList();

        public async Task<IEnumerable<Table>> GetItemsAsync()=>await this._dbContext.Set<Table>().ToListAsync();

        public bool UpdateItem(Table item)
        {
            throw new NotImplementedException();
        }
    
        public Table Find(Expression<Func<Table, bool>> match) => this._dbContext.Set<Table>().SingleOrDefault(match);
    }


}
