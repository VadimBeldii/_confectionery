using System.Collections.Generic;

namespace Confectionery.BLL.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ProductDTO> Products { get; set; }
    }
}
