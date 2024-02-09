using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder) 
        {
            builder.Entity<Product>().HasData(

                 new Product()
                 {
                     ProductId = 1,
                     Name = "Bebetto Yenidoğan Friends Are Forever Çoraplı Alt Erkek Bebek",
                     Url = "bebetto-yenidogan-friends-are-forever-corapli-alt-erkek-bebek-p-23kbbtealt001001",
                     Price = 100,
                     ImageUrl = "1.jpg",
                     Description = "Yumuşak kumaş dokusu ve rahat kalıba sahiptir.",
                     IsApproved = true
                 },
                  new Product()
                  {
                      ProductId = 2,
                      Name = "Neopy Bebek Ocean Deniz Anası Uzun Kol Tshirt",
                      Url = "bebetto-erkek-bebek-ocean-deniz-anasi-uzun-kol-tshirt-p-23yneoemyo013001",
                      Price = 120,
                      ImageUrl = "1.jpg",
                      Description = "UV koruma uygulanmış özel kumaşıyla güneşin zararlı ışınlarına karşı ekstra koruma sağlar.",
                      IsApproved = true
                  },
                  new Product()
                  {
                      ProductId = 3,
                      Name = "Papulin Patik Ayakkabı Unisex",
                      Url = "papulin-patik-ayakkabi-unisex-p-23ypapuptk001004",
                      Price = 120,
                      ImageUrl = "1.jpg",
                      Description = "Esnek yapısı sayesinde bebeklerin yürümesine yardımcı olur.",
                      IsApproved = true
                  },
                   new Product()
                   {
                       ProductId = 4,
                       Name = "ALBİO Albio Düz 3'lü Babet Çorap Erkek Bebek",
                       Url = "albio-albio-duz-3lu-babet-corap-erkek-bebek-p-23kaioecrp001001",
                       Price = 30,
                       ImageUrl = "1.jpg",
                       Description = "Yumuşak kumaş dokusu ve rahat kalıba sahiptir.",
                       IsApproved = true
                   },
                    new Product()
                    {
                        ProductId = 5,
                        Name = "Babyjem katlanır 3'lü Banyo Seti Turkuaz",
                        Url = "babyjem-katlanir-3lu-banyo-seti-turkuaz-p-bje-004",
                        Price = 930,
                        ImageUrl = "1.jpg",
                        Description = "Kullanımı bittikten sonra ters tarafından yumuşak gövdeye bastırarak kapatınız.",
                        IsApproved = true
                    },
                     new Product()
                     {
                         ProductId = 6,
                         Name = "Uni Baby Şampuan 200 ml",
                         Url = "uni-baby-sampuan-200-ml-p-uni-4519",
                         Price = 40,
                         ImageUrl = "1.jpg",
                         Description = "Boya, etil akol, paraben, sülfat, SLS ve SLES içermez.",
                         IsApproved = true
                     },
                      new Product()
                      {
                          ProductId = 7,
                          Name = "Taşpınar Kikkoro Speedy Tekerlekli Bebek Yürüteci",
                          Url = "taspinar-kikkoro-speedy-tekerlekli-bebek-yuruteci-p-tsp-tp084-1002",
                          Price = 440,
                          ImageUrl = "1.jpg",
                          Description = "3 kademe yükseklik ayarlıdır.",
                          IsApproved = true
                      },
                       new Product()
                       {
                           ProductId = 8,
                           Name = "baby plus Street Bebek Arabası",
                           Url = "baby-plus-street-bebek-arabasi-p-byp-strt001",
                           Price = 4499,
                           ImageUrl = "1.jpg",
                           Description = "1 saniye içerisinde tek elle kapanıp açılabilir.",
                           IsApproved = true
                       }


            );

            builder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Name = "Bebek Giyim",
                    Url = "bebekgiyim",
                    MainCategoryId = 3
                },
                   new Category()
                   {
                       CategoryId = 2,
                       Name = "Bebek Ayakkabıları",
                       Url = "bebekayakkabıları",
                       MainCategoryId = 1
                   },
                    new Category()
                   {
                       CategoryId = 3,
                       Name = "Bebek Çorapları",
                       Url = "bebekcorapları",
                       MainCategoryId = 1
                   },
                     new Category()
                     {
                         CategoryId = 4,
                         Name = "Bebek Küveti",
                         Url = "bebekkuveti",
                         MainCategoryId = 2
                     },
                    new Category()
                    {
                        CategoryId = 5,
                        Name = "Bebek Şampuan",
                        Url = "bebeksampuan",
                        MainCategoryId = 2

                    },

                     new Category()
                     {
                         CategoryId = 6,
                         Name = "Bebek Yürüteç",
                         Url = "bebekyuruteci",
                         MainCategoryId = 3
                     },
                    new Category()
                    {
                        CategoryId = 7,
                        Name = "Bebek Arabası",
                        Url = "bebekarabası",
                        MainCategoryId = 3

                    }



            );

            builder.Entity<MainCategory>().HasData(
               new MainCategory()
               {
                   MainCategoryId = 1,
                   Name = "Giyim & Tekstil",
                   Url = "giyim&tekstil",
              
               },
                 new MainCategory()
                 {
                     MainCategoryId = 2,
                     Name = "Banyo & Bakım",
                     Url = "banyo&bakım",

                 },
                   new MainCategory()
                   {
                       MainCategoryId = 3,
                       Name = "Araç & Gereç",
                       Url = "araç&gereç",

                   }

           );

            builder.Entity<ProductCategory>().HasData(
                new ProductCategory(){ProductId=1,CategoryId=1},          
                new ProductCategory(){ProductId=2,CategoryId=1},          
                new ProductCategory(){ProductId=3,CategoryId=2},          
                new ProductCategory(){ProductId=4,CategoryId=3},          
                new ProductCategory(){ProductId=5,CategoryId=4},          
                new ProductCategory(){ProductId=6,CategoryId=5},          
                new ProductCategory(){ProductId=7,CategoryId=6},          
                new ProductCategory(){ProductId=8,CategoryId=7}       
                      

           );
        }
    }
}