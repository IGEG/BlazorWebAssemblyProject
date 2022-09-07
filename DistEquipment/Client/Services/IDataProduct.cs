﻿using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataProduct
    {
        event Action OnChange; 
        List<Product> Products { get; set; }
        Task LoadProduct(string Url=null);

        Task<Product> GetProductById(int Id);
    }
}
