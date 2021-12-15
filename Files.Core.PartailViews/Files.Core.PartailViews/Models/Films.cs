using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files.Core.PartailViews.Models
{
    public class Films
    {
        public int ID;
        public string Title;
        public string Duration;
        public string Discritption;
        public List<Films> CarList = new List<Films>();
        public AddressViewModel Filmslist { get; set; }
        public Films GetCarById(int Id)
        {
            return CarList.FirstOrDefault(z => z.ID == Id);

        }
    }
    public class AddressViewModel
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Discritption { get; set; }
    }

}
