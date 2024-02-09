using ETCR.UI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ETCR.UI.Entity
{
    public class Category
    {
        public int Id { get; set; }

        
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength: 20, ErrorMessage = "en fazla 20 karakter girebilirsiniz.")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}