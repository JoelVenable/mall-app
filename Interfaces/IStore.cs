namespace MallApp
{
    public interface IStore
    {
        void AddToInventory(string name, DollarItem item);
    }

}