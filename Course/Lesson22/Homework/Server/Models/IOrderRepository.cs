namespace Homework
{
    public interface IOrderRepository
    { 
        List<Order> GetAllOrders();
        void AddOrder(Order order);
        void DeleteOrder(string id);
    }
}