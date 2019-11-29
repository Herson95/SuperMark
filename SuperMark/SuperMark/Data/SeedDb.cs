namespace SuperMark.Data
{
    using SuperMark.Data.Entities;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;

        public SeedDb(DataContext context)
        {
            this.context = context;
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            // Add products
            if (!this.context.Products.Any())
            {
                this.AddProduct("AirPods");
                this.AddProduct("Blackmagic eGPU Pro");
                this.AddProduct("iPad Pro");
                this.AddProduct("iMac");
                this.AddProduct("iPhone X");
                this.AddProduct("iWatch Series 4");
                this.AddProduct("Mac Book Air");
                this.AddProduct("Mac Book Pro");
                this.AddProduct("Mac Mini");
                this.AddProduct("Mac Pro");
                this.AddProduct("Magic Mouse");
                this.AddProduct("Magic Trackpad 2");
                this.AddProduct("USB C Multiport");
                this.AddProduct("Wireless Charging Pad");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
            });
        }
    }
}
