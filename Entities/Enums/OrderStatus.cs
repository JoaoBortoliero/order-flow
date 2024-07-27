namespace OrderFlow.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        Processing = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}
