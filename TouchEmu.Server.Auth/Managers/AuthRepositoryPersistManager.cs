using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using TouchEmu.Core.Common.Entity;
using TouchEmu.Core.Common.Managers.Repository;
using TouchEmu.Core.Common.Repository;
using ServiceStack.OrmLite;

namespace TouchEmu.Server.Auth.Managers
{
    public class AuthRepositoryPersistManager : AbstractRepositoryPersistManager
    {
        private IAccountRepository _accountRepository;
        public AuthRepositoryPersistManager(IDbConnection connection, IAccountRepository accountRepository) : base(connection, 100000)
        {
            this._accountRepository = accountRepository;
        }

        protected override Task PersistCallback()
        {
            this._logger.Debug($"Save in progress...");

            this._accountRepository.PersistEntities();

            return base.PersistCallback();
        }
    }
}