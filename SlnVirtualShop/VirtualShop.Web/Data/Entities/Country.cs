﻿namespace VirtualShop.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
