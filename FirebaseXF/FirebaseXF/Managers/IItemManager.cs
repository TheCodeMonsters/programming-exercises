using System;
using DynamicData;
using DynamicData.Kernel;
using FirebaseXF.Models;

namespace FirebaseXF.Managers
{
    public interface IItemManager
    {
        public IObservable<IChangeSet<Item, string>> ItemChanges { get; }

        public Optional<Item> Get(string id);

        public void AddOrUpdate(Item item);

        public void Remove(Item item);
    }
}