﻿namespace IWANTAPP.Domain.Products
{
    public class Category : Entity
    {
       public new string Name { get; set; }
        public bool Active { get; set; } = true;

    }
}
