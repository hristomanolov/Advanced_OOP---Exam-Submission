﻿namespace RecyclingStation.Framework.StrategyHolder
{
    using System;
    using System.Collections.Generic;
    using GarbageDisposalStrategies;

    public class StrategyHolder : IStrategyHolder
    {
        private readonly IDictionary<Type, IGarbageDisposalStrategy> strategies;

        public StrategyHolder()
        {
            this.strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        }

        public IReadOnlyDictionary<Type, IGarbageDisposalStrategy> GetDisposalStrategies
            => (IReadOnlyDictionary<Type, IGarbageDisposalStrategy>)this.strategies;

        public bool AddStrategy(Type disposableAttribute, IGarbageDisposalStrategy strategy)
        {
            this.strategies.Add(disposableAttribute, strategy);
            return true;
        }

        public bool RemoveStrategy(Type disposableAttribute)
        {
            this.strategies.Remove(disposableAttribute);
            return true;
        }
    }
}
