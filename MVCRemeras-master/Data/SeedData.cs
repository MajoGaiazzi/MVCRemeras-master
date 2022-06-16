using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

using MVCMerchandising.Data;

using System;

using System.Linq;



namespace MVCMerchandising.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)

        {

            using (var context = new MVCMerchandisingContext(

                serviceProvider.GetRequiredService<

                    DbContextOptions<MVCMerchandisingContext>>()))

            {

                // Look for any movies.

                if (context.Merchandising.Any())

                {

                    return;   // DB has been seeded

                }


                context.Merchandising.AddRange(

                    new Merchandising

                    {

                        Producto = "Remera de Naruto",

                        Descripcion = "Remera cheta",

                        Talles = "XL",

                        Precio = 799,

                        Colores="Negra",

                        Imagen = "https://play-lh.googleusercontent.com/XB2KVHIkLzmtSuNarhmTKmH9M2orc5FFvopF507YQjoPfpmlHTcwii04sSJy4HM6408=w240-h480-rw"

                    },


                    new Merchandising

                    {

                        Producto = "Bufanda de Natsu",

                        Descripcion = "Bufanda Realista",

                        Talles = "Unico",

                        Precio = 500,

                        Colores = "Negro y Rojo",

                        Imagen = "https://play-lh.googleusercontent.com/XB2KVHIkLzmtSuNarhmTKmH9M2orc5FFvopF507YQjoPfpmlHTcwii04sSJy4HM6408=w240-h480-rw"

                    },


                    new Merchandising

                    {

                        Producto = "Remera Minions",

                        Descripcion = "sadsa",

                        Talles = "Unico",

                        Precio = 500,

                        Colores = "Negro y Rojo",

                        Imagen = "https://play-lh.googleusercontent.com/XB2KVHIkLzmtSuNarhmTKmH9M2orc5FFvopF507YQjoPfpmlHTcwii04sSJy4HM6408=w240-h480-rw"

                    },


                    new Merchandising

                    {

                        Producto = "Remera Minions",

                        Descripcion = "sadsa",

                        Talles = "Unico",

                        Precio = 500,

                        Colores = "Negro y Rojo",

                        Imagen = "https://play-lh.googleusercontent.com/XB2KVHIkLzmtSuNarhmTKmH9M2orc5FFvopF507YQjoPfpmlHTcwii04sSJy4HM6408=w240-h480-rw"

                    }

                );

                context.SaveChanges();

            }

        }

    }

}

