using Microsoft.AspNetCore.Mvc.RazorPages;
using RentACar.Data;

namespace RentACar.Models
{
    public class CarCollectionsPageModel:PageModel
    {
        public List<AssignedCollection> AssignedCollectionList { get; set; }
        public void PopulateAssignedCollection(RentACarContext context, Car car)
        {
            var allCollections = context.Collection;
            var carCollections = new HashSet<int>(
                )
        }
    }
}
