
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; set; }

        public TransferCreatedEvent(int from, int to, decimal ammount)
        {
            From = from;
            To = to;
            Amount = ammount;
        }
    }
}
