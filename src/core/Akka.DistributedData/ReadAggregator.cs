﻿using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.DistributedData
{
    public class ReadAggregator : ReadWriteAggregator
    {
        protected override TimeSpan Timeout
        {
            get { throw new NotImplementedException(); }
        }

        protected override int DoneWhenRemainingSize
        {
            get { throw new NotImplementedException(); }
        }

        protected override bool Receive(object message)
        {
            throw new NotImplementedException();
        }

        public ReadAggregator()
            : base(ImmutableHashSet<Address>.Empty)
        { }
    }
}
