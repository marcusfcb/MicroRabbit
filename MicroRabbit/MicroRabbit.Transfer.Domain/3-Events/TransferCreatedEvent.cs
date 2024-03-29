﻿using MicroRabbit.Domain.Core.Events;


namespace MicroRabbit.Transfer.Domain._3_Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            this.From = from;
            this.To = to;
            this.Amount = amount;
        }
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }
    }
}
