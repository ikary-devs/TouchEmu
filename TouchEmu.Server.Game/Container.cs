using System.Data;
using Autofac;
using TouchEmu.Core.Common.Managers.Data;
using TouchEmu.Core.Common.Managers.Pathfinding;
using TouchEmu.Core.Common.Repository;
using TouchEmu.Server.Game.Managers;
using ServiceStack.OrmLite;

namespace TouchEmu.Server.Game
{
    public static class Container
    {
        private static IContainer _container = null;


        public static void Initialize()
        {
            if (_container != null)
                return;

            var builder = new ContainerBuilder();

            builder.Register<IDbConnection>(c =>
                new OrmLiteConnection(new OrmLiteConnectionFactory(
                    "Server=localhost;Database=arkanic_game;Uid=root;Pwd=;", MySql55Dialect.Provider)));

            //repository entities persister
            builder.RegisterType<RepositoryPersistManager>().AsSelf().OnActivating(e => e.Instance.StartPersister())
                .AutoActivate()
                .SingleInstance();
            
            //repository
            builder.RegisterType<CharacterRepository>().As<ICharacterRepository>().SingleInstance();
            builder.RegisterType<NpcSpawnRepository>().As<INpcSpawnRepository>().SingleInstance();

            /* MANAGER */
            
            //map
            builder.RegisterType<PathfinderManager>().As<IPathfinderManager>()
                .AutoActivate()
                .SingleInstance();
            
            builder.RegisterType<MapManager>().As<IMapManager>()
                .AutoActivate()
                .SingleInstance();
            
            //npc
            builder.RegisterType<NpcManager>().As<INpcManager>()
                .AutoActivate()
                .SingleInstance();

            
            //character
            builder.RegisterType<CharacterManager>().As<ICharacterManager>()
                .AutoActivate()
                .SingleInstance();
            
            _container = builder.Build();
        }

        public static IContainer Instance()
        {
            if (_container == null)
            {
                Initialize();
            }

            return _container;
        }
    }
}