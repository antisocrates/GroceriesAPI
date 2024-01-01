using System;
using System.Collections.Generic;
using GroceriesApi.Common;

namespace GroceriesApi;

public class ListsController
{
    public static GroceryList GetList(Guid id)
    {
        return new GroceryList()
        {
            Id = Guid.NewGuid(),
            Name = "MyList"
        };
    }

}
