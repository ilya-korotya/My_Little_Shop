﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SportsStore.Models.Entities;

namespace SportsStore.Models.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> Products { get; }

        //Когда мы начали делать админку нам нужно добавить метод, который позволит не только получать данные с БД,
        //но и вносить в нее изменения. Для этого в интерфейсе добавляем новый метод
        void SaveProduct(Product product); //заглянуть в реализацию данного интерфейса

        //Теперь нам нужно реализовать возможность удаления
        Product DeleteProduct(int productID);
    }
    #region Подсказка
    /*
    Здесь используется интерфейс IQueryable<T>, который позволяет получить последовательность
объектов Product и не требует указаний на то, как и где хранятся данные или как следует их
извлекать. Класс, который использует интерфейс IProductRepository, может получить объекты
Product, не зная того, где они содержатся или каким образом будут ему поставлены. Это и есть суть
шаблона хранилища.

        Пока мы не реализуем интерфейс, но что бы мы могли рабоать с программой дальше, нам нужно создать (mock-объект) что то типа реализации интерфейса, только не реализация.
        Это так же называется заглушка
        ее мы создам в превязке интерфейса и реализации с момощью Moq в Ninject контейнере
        файл NinjectControllerFactory
     */
    #endregion
}
