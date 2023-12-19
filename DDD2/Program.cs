using DDD2.Factory;
using DDD2.Repositories;


//Репозитории
var buyerRepository = new BuyerRepository();
var orderRepository = new OrderRepository();


//Фабрики
var buyerFactory = new BuyerFactory(buyerRepository);
var orderFactory = new OrderFactory(orderRepository);


//Создание агрегата покупателя
if (await buyerFactory.CreateAggregates())
{
    Console.WriteLine("Агрегат покупателя успешно создан!");
}
else
{
    Console.WriteLine("Ошибка создания покупателя!");
}

//Создание агрегата заказа
if (await orderFactory.CreateAggregates())
{
    Console.WriteLine("Агрегат заказа успешно создан!");
}
else
{
    Console.WriteLine("Ошибка создания заказа!");
}

