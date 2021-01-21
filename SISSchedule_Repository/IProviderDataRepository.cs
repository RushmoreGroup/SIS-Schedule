#region Namespace
using System;
using System.Collections.Generic;
#endregion
namespace SISSchedule_Repository
{
    /// <summary>
    /// Interface of provider data repository. This Interface will use for Provider Entity.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TDto"></typeparam>
    public interface IProviderDataRepository<TEntity,TDto>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(int id);

        TEntity GetProvider(string provider);
        int Add(TEntity entity);

       int Update(TEntity entity, TDto dto);

        bool Delete(TEntity entity);
    }
}
