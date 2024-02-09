using ETCR.UI.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ETCR.UI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category{ Name = "Kamera", Description = "Kamera ürünleri"},
                new Category{ Name = "Bilgisayar", Description = "Bilgisayar ürünleri"},
                new Category{ Name = "Elektronik cihazlar", Description = "Elektronik cihazlar ürünleri"},
                new Category{ Name = "Telefon", Description = "Telefon ürünleri"},
                new Category{ Name = "Beyaz eşya", Description = "Beyaz eşya ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                
                new Product() { Name = "Vestel PUZZLE FD65001 EX VAKUM 584 Lt Gardırop Tipi Buzdolabı", Description = "4 Açılır kapaklı derin donduruclu buzdolabı", Price =40000 , Stock = 2, IsApproved =true, CategoryId = 3, IsHome=true ,Image = "buzdolabi.jpg" },
                new Product() { Name = "Vestel BM 5312 X WIFI Bulaşık Makinesi | Vestel", Description = "Çok kaliteli bi ürün", Price = 25000, Stock =1 , IsApproved =true, CategoryId = 3, IsHome=true ,Image = "camasir.jpg" },
                new Product() { Name = "Panasonik Kamera", Description = "Üst düzey profesyonel kamera", Price = 7.500, Stock =1, IsApproved =true, CategoryId = 4 , IsHome=true ,Image = "camera.jpg"},
                new Product() { Name = "ONVO 65 165 EKRAN 4K WEBOS LED TELEVİZYON", Description = "4K Çözünürlükte olan televizyon tüm film dizileri keyifle izlemenizi sağlıyor", Price =20000, Stock =2, IsApproved =true, CategoryId = 5, IsHome=true ,Image = "tv.jpg" },
                new Product() { Name = "Xiaomi Redmi 13C 8 GB 256 GB (Xiaomi Türkiye Garantili)", Description = "Üst düzey telefon", Price = 10000, Stock =1, IsApproved =true, CategoryId = 4 , IsHome=true ,Image = "xio.jpg"},
                new Product() { Name = "Apple iPhone 11 64 GB Beyaz Cep Telefonu Aksesuarsız Kutu (Apple Türkiye Garantili)", Description = "Yılların eskitmediği telefon", Price =20000, Stock =1, IsApproved =true, CategoryId = 1, IsHome=false, Image = "iph115.jpg" },
                new Product() { Name = "MSI CYBORG 15 A12VF-077XTR I5-12450H 16GB DDR5 RTX4060 GDDR6 8GB 1TB SSD 15.6 FHD 144Hz DOS", Description = "Oyunlarınızı en üst çözünürlükte oynayın", Price =40000 , Stock =3, IsApproved =true, CategoryId = 2, IsHome=false,Image = "msi.jpg" },
                new Product() { Name = "MSI Mag Forge 100m Temperli Cam Usb 3.2 Atx Mid-tower Gaming (oyuncu) Kasa", Description = "Oyunlarınız en üst düzey grafiklerde ve çözünürlükte oynayın", Price =40000, Stock =1, IsApproved =true, CategoryId = 2 , IsHome=false,Image = "masaüstü.jpg"},
                new Product() { Name = "Apple iPhone 15 Pro Max 256 GB Natürel Titanyum", Description = "Dünya çapında büyük marka olan telefon sizlerin tüm ihtiyaçlarınızı karşılamakta", Price =100000, Stock = 2, IsApproved = true, CategoryId = 1, IsHome=false,Image = "iphone15.jpg" }
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}