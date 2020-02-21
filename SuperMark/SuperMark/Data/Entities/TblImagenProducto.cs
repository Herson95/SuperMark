
namespace SuperMark.Data.Entities
{
    using System;
    using System.Collections.Generic;
    public partial class TblImagenProducto 
    {
        public int IdImagenProducto { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int? Estado { get; set; }

       

        public virtual TblProducto CodigoProductoNavigation { get; set; }
    }
}
