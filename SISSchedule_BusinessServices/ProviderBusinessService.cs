
#region .Net namespace
using System;
using System.Collections.Generic;
using System.Linq;
using SISSchedule_DTO;
using SISSchedule_Entities;
using SISSchedule_Repository;
#endregion
namespace SISSchedule_BusinessServices
{

    /// <summary>
    /// Business service of provider
    /// </summary>
    public class ProviderBusinessService : IProviderDataRepository<Providers, ProviderDTO>
    {
        readonly SISScheduleContext _sISScheduleContext;
        /// <summary>
        /// Constrcutor
        /// </summary>
        public ProviderBusinessService(SISScheduleContext sISScheduleContext)
        {
            _sISScheduleContext = sISScheduleContext;
        }

        /// <summary>
        /// Add a provider details into tables
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public int Add(Providers provider)
        {
            int intProvider = 0;
            _sISScheduleContext.providers.Add(provider);
            int _provider = _sISScheduleContext.SaveChanges();
            if(_provider ==1)
            {
                intProvider = provider.RecordID;
            }

            return intProvider;
        }

        /// <summary>
        /// Delete a Provider details 
        /// </summary>
        /// <param name="entity"></param>
        public bool Delete(Providers entity)
        {
            bool IsSuccess = true;
            _sISScheduleContext.providers.Remove(entity);
            int intProvider = _sISScheduleContext.SaveChanges();
            if (intProvider == 1)
            {
                IsSuccess = true;
            }
            else
            {
                IsSuccess = false;
            }
            return IsSuccess;
        }

        /// <summary>
        /// Get Providers details for given report id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Providers Get(int id)
        {
            _sISScheduleContext.ChangeTracker.LazyLoadingEnabled = false;

            var provider = _sISScheduleContext.providers
                .SingleOrDefault(b => b.RecordID == id);

            return provider;
        }


        /// <summary>
        /// Get Providers details for given provider
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Providers GetProvider(string provider)
            //this is use to validate that while same provide is in DB or not.
        {
            _sISScheduleContext.ChangeTracker.LazyLoadingEnabled = false;

            var providers = _sISScheduleContext.providers
                .SingleOrDefault(b => b.Provider.ToLower() == provider.ToLower());

            return providers;
        }

        /// <summary>
        /// Get all Provider details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Providers> GetAll()
        {

            return _sISScheduleContext.providers.ToList();


        }

        /// <summary>
        /// Update the provider details 
        /// </summary>
        /// <param name="entityToUpdate"></param>
        /// <param name="entity"></param>
        public int Update(Providers entityToUpdate, ProviderDTO entity)
        {
            int intprovider = 0;
            entityToUpdate.DirectorZip = entity.DirectorZip;
            entityToUpdate.Director = entity.Director;
            entityToUpdate.DirectorAddress = entity.DirectorAddress;
            entityToUpdate.DirectorCity = entity.DirectorCity;
            entityToUpdate.DirectorEmail = entity.DirectorEmail;
            entityToUpdate.DirectorFax = entity.DirectorFax;
            entityToUpdate.DirectorPhone = entity.DirectorPhone;
            entityToUpdate.RecordID = entity.RecordID;
            entityToUpdate.Provider = entity.Provider;
            entityToUpdate.Website= entity.Website;
            entityToUpdate.Notes = entity.Notes;

            _sISScheduleContext.providers.Update(entityToUpdate);
            int intProvider = _sISScheduleContext.SaveChanges();
            if (intProvider == 1)
            {
                intprovider = entityToUpdate.RecordID;
                    }

            return intprovider;


        }
    }
}
