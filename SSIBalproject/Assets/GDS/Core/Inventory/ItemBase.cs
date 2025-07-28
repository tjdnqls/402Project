namespace GDS.Core {

    public interface IItemBase {
        public string Id { get; }
        public string Name { get; }
        public string Icon { get; }
        public Stack Stack { get; }
    }

    public class ItemBase : IItemBase {
        public static ItemBase NoItemBase = new() { Id = "NoItemBase", Name = "NoItemBase", };
        public string Id;
        public string Name = "unknown";
        public string Icon = "Shared/Images/items/unknown";
        public Stack Stack = Stack.NoStack;

        string IItemBase.Id => Id;
        string IItemBase.Name => Name;
        string IItemBase.Icon => Icon;
        Stack IItemBase.Stack => Stack;

        public override string ToString() => Name;
    }

    public class ShapeItemBase : ItemBase {
        public int[,] Shape = Shapes.Rect1x1;
    }
}