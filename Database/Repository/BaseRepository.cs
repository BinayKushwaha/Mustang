using Mustang.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.Database.Repository
{
    public class BaseRepository
    {
        private ApplicationContext ApplicationContext { get; set; }

        public BaseRepository(ApplicationContext applicationContext)
        {
            this.ApplicationContext = applicationContext;
        }
        public ApplicationContext DataContext
        {
            get
            {
                return ApplicationContext;
            }
        }
    }
}
