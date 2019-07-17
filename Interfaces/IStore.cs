namespace MallApp
{
    public interface IStore<TItem>
    {
        void AddToInventory(string name, TItem item);
    }

}