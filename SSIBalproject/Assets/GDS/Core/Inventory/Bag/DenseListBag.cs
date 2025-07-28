using GDS.Core.Events;
using UnityEngine;

namespace GDS.Core {
    public class DenseListBag : ListBag { }

    public static class DenseListBagExt {

        public static Result RemoveItem(this DenseListBag bag, ListSlot slot) {
            for (var i = slot.Index; i < bag.Size - 1; i++) { bag.Slots[i] = bag.Slots[i] with { Item = bag.Slots[i + 1].Item }; }
            bag.Slots[bag.Size - 1] = bag.Slots[bag.Size - 1].Clear();
            bag.Data.Notify();
            return Result.Success;
        }

        public static Result PickItem(this DenseListBag bag, ListSlot slot, EventModifiers mods = EventModifiers.None) {
            RemoveItem(bag, slot);
            return new PickItemSuccess(slot.Item);
        }

        public static Result PlaceItem(this DenseListBag bag, ListSlot slot, Item item, EventModifiers mods = EventModifiers.None) {
            var index = bag.FindEmptyIndex();
            if (index < 0) return new BagFull(bag);
            bag.UpdateSlot(bag.Slots[index], item);
            return new PlaceItemSuccess(item, Item.NoItem);
        }

    }
}