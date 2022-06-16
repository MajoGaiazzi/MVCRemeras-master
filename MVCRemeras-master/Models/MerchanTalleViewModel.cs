using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;



namespace MVCMerchandising.Models
{
    public class MerchanTalleViewModel
    {
        public List<Merchandising> Productos { get; set; }

        public SelectList Talles { get; set; }

        public string MerchanTalles { get; set; }

        public string SearchString { get; set; }
    }
}
