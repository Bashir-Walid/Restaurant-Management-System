using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_Templates.Models
{
    //Table Partners : Id / Image / Alt / Link

    public class Partners:BaseEntity
    {
        public string Image {  get; set; }
        public string Alt { get; set; }
        public string Link { get; set; }


    }
}
