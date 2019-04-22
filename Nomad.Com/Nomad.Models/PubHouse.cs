using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomad.Models
{
    public class PubHouse : Entity
    {
        public delegate void JournalSend();
        public event JournalSend JournalSendReport;

        public List<Client> Clients { get; set; }



    }
}
