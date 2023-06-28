namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;

    public partial class categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> padre { get; set; }
        public Nullable<bool> activo { get; set; }
    }
}