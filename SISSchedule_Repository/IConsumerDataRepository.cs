using System;
using System.Collections.Generic;
using System.Text;

namespace SISSchedule_Repository
{
    //This Interface will use for Consumer Entity.
   public interface IConsumerDataRepository<TEntity,TDto>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int Consumer_id);
        int Add(TEntity consumerEntity);
        int Update(TEntity consumerEntity, TDto consumerDto);
        bool Delete(TEntity consumerEntity);
    }
}
