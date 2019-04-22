using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Nomad.Models;

namespace Nomad.Context
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        private List<Client> clients;

        protected override void Seed(DataContext context)
        {
            clients = new List<Client>
            {
                new Client
                {
                    FullName = "Олег Скидан",
                    IsSubscribed = true,
                    SubsDate = DateTime.Now
                }
            };
            context.Clients.AddRange(clients);
            base.Seed(context);
        }
    }
}
