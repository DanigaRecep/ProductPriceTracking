﻿using System.Collections.Generic;
using System.Threading.Tasks;

using ProductPriceTracking.Core.Entities.Interfaces;

namespace ProductPriceTracking.Bll.Interfaces
{
    public interface IGenericService<TEntity>
      where TEntity : class, IEntityBase, new()
    {
        Task<ICollection<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int Id);

        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task AddAsync(TEntity entity);
    }
}
