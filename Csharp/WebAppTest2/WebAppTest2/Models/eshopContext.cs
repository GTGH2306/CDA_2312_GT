using Microsoft.EntityFrameworkCore;

namespace WebAppTest2.Models
{
    public class eshopContext : DbContext
    {
        public eshopContext() : base("name = eshopDB")
        {
            
        }
    }
}
