using Microsoft.EntityFrameworkCore;

namespace Assignment2
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DBContext>>()))
            {
                // Look for any persons.
                if (!context.persons.Any())
                {
                    context.persons.AddRange(
                        new persons{Name="Tom Smith",PhoneNumber="123-456-7890",Email="TSmith@gmail.com",Password=Hash.hash256("Password1","1")},
                        new persons{Name="Billy Bob",PhoneNumber="123-456-7890",Email="BB123@gmail.com",Password=Hash.hash256("Password2","2")}
                    );
                    context.SaveChanges();
                }
                // Look for any address.
                if (!context.address.Any())
                {
                    context.address.AddRange(
                        new address{Street="5403 Ross Ave",City="Dallas",State="Texas",PostalCode=75206,Country="United States"},
                        new address{Street="3811 S Cooper St",City="Arlington",State="Texas",PostalCode=76015,Country="United States"},
                        new address{Street="900 W Weatherford St",City="Fort Worth",State="Texas",PostalCode=76102,Country="United States"},
                        new address{Street="1 AT&T Way",City="Arlington",State="Texas",PostalCode=76011,Country="United States"},
                        new address{Street="1717 N Harwood St",City="Dallas",State="Texas",PostalCode=75201,Country="United States"}
                    );
                    context.SaveChanges();
                }
                // Look for any restaurants.
                if (!context.restaurants.Any())
                {
                    context.restaurants.AddRange(
                        new restaurants{Name="McDonald's",AddressID=1},
                        new restaurants{Name="Chick-fil-A",AddressID=2},
                        new restaurants{Name="Taco Bell",AddressID=3}
                    );
                    context.SaveChanges();
                }
                // Look for any drivers.
                if (!context.drivers.Any())
                {
                    context.drivers.AddRange(
                        new drivers{PersonsID=1,AddressID=4}
                    );
                    context.SaveChanges();
                }
                // Look for any shoppers.
                if (!context.shoppers.Any())
                {
                    context.shoppers.AddRange(
                        new shoppers{PersonsID=2,AddressID=5}
                    );
                    context.SaveChanges();
                }
                // Look for any menuItems.
                if (!context.menuItems.Any())
                {
                    context.menuItems.AddRange(
                        new menuItems{RestaurantsID=1,Name="Big Mac",Description="Ever wondered what's on a Big Mac®? The McDonald's Big Mac® is a 100% beef burger with a taste like no other. The mouthwatering perfection starts with two 100% pure all beef patties and Big Mac® sauce sandwiched between a sesame seed bun. It’s topped off with pickles, crisp shredded lettuce, finely chopped onion, and a slice of American cheese. It contains no artificial flavors, preservatives, or added colors from artificial sources. Our pickle contains an artificial preservative, so skip it if you like.",Price=4.99},
                        new menuItems{RestaurantsID=1,Name="French Fries",Description="McDonald's World Famous Fries® are made with premium potatoes such as the Russet Burbank and the Shepody. With 0g of trans fat per labeled serving, these epic fries are crispy and golden on the outside and fluffy on the inside.",Price=2.69},
                        new menuItems{RestaurantsID=2,Name="Chick-fil-A Chicken Sandwich",Description="A boneless breast of chicken seasoned to perfection, freshly breaded, pressure cooked in 100% refined peanut oil and served on a toasted, buttered bun with dill pickle chips. Also available on a multigrain bun.",Price=4.79},
                        new menuItems{RestaurantsID=2,Name="Chick-fil-A Waffle Potato Fries",Description="Waffle-cut potatoes cooked in canola oil until crispy outside and tender inside. Sprinkled with Sea Salt.",Price=2.35},
                        new menuItems{RestaurantsID=3,Name="Crunchwrap Supreme",Description="They fit everything you could possibly want or need into a one-handed meal staple. With seasoned beef, nacho cheese sauce, lettuce, tomatoes, and a crunchy tostada shell for extra loud chewability, this is the product that wrote, and broke, all the rules.",Price=4.69},
                        new menuItems{RestaurantsID=3,Name="Beefy Melt Burrito",Description="Seasoned Rice, Seasoned Beef, Nacho Cheese Sauce, Fiesta Strips, Three Cheese Blend, Reduced Fat Sour Cream wrapped in a warm tortilla.",Price=2.00}
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}