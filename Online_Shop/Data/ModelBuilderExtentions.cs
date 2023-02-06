using Microsoft.EntityFrameworkCore;
using Online_Shop.Models;

namespace Online_Shop.Data
{
    public static class ModelBuilderExtentions
    {
        public static void seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(
                new User { Id=1, Username="admin", Password="admin", Email="admin@example.com", Role="Admin" },
                new User { Id=2, Username="user", Password="user", Email="user@example.com", Role ="User" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1, Name="Tomato", Category="Vegetables", Description ="Fresh delicious Tomato.", Price=0.40, ImageUrl="https://img.freepik.com/free-photo/fresh-red-tomatoes_2829-13449.jpg?w=826&t=st=1675614718~exp=1675615318~hmac=c2bdc29fdcea351ff75bacfbc917a168e497461ec1804ddd2d0fde8178eac8c1" },
                new Product { Id=2, Name="Potato", Category="Vegetables", Description ="Fresh Potato.", Price=0.70, ImageUrl="https://img.freepik.com/free-photo/rustic-unpeeled-potatoes-table_144627-3925.jpg?w=1060&t=st=1675614905~exp=1675615505~hmac=793f3a2c1cb7e5ac89ce5ac5f2607d604bf826b21912fb0bff8a723f535386a9" },
                new Product { Id=3, Name="Bread", Category="Bakery", Description ="Daily baked Bread.", Price=0.50, ImageUrl="https://img.freepik.com/free-photo/homemade-crunchy-bread-with-grains_144627-362.jpg?w=900&t=st=1675615019~exp=1675615619~hmac=b53b74310754008c820d261d82db8c728e95b135fc8afedd5a0f27f3d3e94446" },
                new Product { Id=4, Name="Cake", Category="Bakery", Description ="Daily baked Cake.", Price=4, ImageUrl="https://img.freepik.com/free-photo/dessert-fruitcake_144627-10487.jpg?w=1060&t=st=1675615714~exp=1675616314~hmac=874ceff2453cf3a9f6afe33ee1b2b342dd192fa400992b2da92e696be60e87b3" },
                new Product { Id=5, Name="Orange", Category="Fruits", Description ="Fresh orange", Price=1.50, ImageUrl="https://img.freepik.com/free-photo/cut-whole-orange-fruits-with-green-leaves_74855-5380.jpg?w=1060&t=st=1675615765~exp=1675616365~hmac=5041a96046676f57f07495bd30c0da3ed08fbc7cb862c508f3b7103b845f472a" },
                new Product { Id=6, Name="Apple", Category="Fruits", Description ="Fresh Apple", Price=1.20, ImageUrl="https://img.freepik.com/free-photo/apples-red-fresh-mellow-juicy-perfect-whole-white-desk_179666-271.jpg?w=1060&t=st=1675615812~exp=1675616412~hmac=9f78977f6265c61c89386c6ab4fb3b4acbe3d58e84c1d2414f2f7ba0db05a81f" },
                new Product { Id=7, Name="Strawberry", Category="Fruits", Description ="Fresh Strawberry", Price=1.10, ImageUrl="https://img.freepik.com/free-photo/red-fresh-strawberries-with-green-leaves_114579-10506.jpg?w=1060&t=st=1675615838~exp=1675616438~hmac=819b621145b32e08c8de8361c9d988c96d3a7f108c9e7da615e0974038850cdb" },
                new Product { Id=8, Name="White Shirt", Category="Clothes", Description ="White Shirt.", Price=15, ImageUrl="https://img.freepik.com/free-photo/white-t-shirts-with-copy-space-gray-background_53876-104920.jpg?w=1060&t=st=1675615107~exp=1675615707~hmac=6ec76c9f8f3efee7e124f69cfbf50a8686b77add425996311727cf9ee3c4dac3" },
                new Product { Id=9, Name="Pink Sneakers", Category="Clothes", Description ="Pink Sneaker.", Price=50, ImageUrl="https://img.freepik.com/free-photo/sport-running-shoes_1203-3414.jpg?w=1060&t=st=1675615218~exp=1675615818~hmac=1cae061fb4dce8f73da4f955ef38f2548634c40e2adfdf04dceb58006e5c9999" },
                new Product { Id=10, Name="Men Sneakers", Category="Clothes", Description ="Men Sneakers", Price=60, ImageUrl="https://img.freepik.com/free-photo/fashion-shoes-sneakers_1203-7528.jpg?w=1060&t=st=1675615295~exp=1675615895~hmac=df919a47aa54af4a9249f77540bd9c7b88c303651434dd039dd25fafdcdc0cc1" }
                );
        }
    }
}
