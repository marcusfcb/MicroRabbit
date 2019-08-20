﻿using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain._5_Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            this.From = from;
            this.To = to;
            this.Amount = amount;
        }
        public int From { get; private  set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        

    }
}
