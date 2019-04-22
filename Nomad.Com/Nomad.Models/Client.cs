using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Nomad.Models
{
    public enum Command : int
    {
        one=1,two,three
    }
    public class Client : Entity
    {
        public delegate void MessageReporter(string message);
        public event MessageReporter Reporter;

        public string FullName { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsPaid { get; set; }
        public DateTime SubsDate { get; set; }

        public Client()
        {
            FullName = string.Empty;
            IsSubscribed = false;
            IsPaid = false;
            SubsDate = DateTime.Now;
        }

        public void SubscribeToJournal(string fullName,int year)
        {
            try
            {

                FullName = fullName;
                if (year == 1) SubsDate.AddYears(1);
                if (year == 2) SubsDate.AddYears(2);
                if (year == 3) SubsDate.AddYears(3);
                IsSubscribed = true;
                IsPaid = true;
                Reporter?.Invoke($"Подписка прошла успешно");
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}");
            }
        }
    }
}
