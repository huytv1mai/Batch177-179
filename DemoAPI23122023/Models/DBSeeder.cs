namespace DemoAPI23122023.Models
{
    public class DBSeeder
    {
        public static void AddCompaniesData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<ApiContext>();

            db.Companies.Add(
                new Company()
                {
                    ID = 1,
                    Name = "Company A",
                    Size = 25
                });
            db.Companies.Add(
                new Company()
                {
                    ID = 2,
                    Name = "Company B",
                    Size = 50
                });

            //more companies here...

            db.Products.Add(
                new Product()
                {
                    ID = 1,
                    CompanyID = 1,
                    Name = "Product A",
                    Price = 10
                });

            //more products here..

            db.SaveChanges();
        }

    }
}
