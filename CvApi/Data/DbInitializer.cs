using CvApi.Models;

namespace CvApi.Data
{
    public class DbInitializer
    {
       public static void Seed(CvDbContext context)
        {
            if (context.Profiles.Any())
            {
                return;
            }

            context.Profiles.Add(new Profile
            {
                Name = "Tamara Ali",
                Title = "Software Engineer",
                Email = "tamarafiras@hotmail.com",
                LinkedIn = "https://www.linkedin.com/in/tamara-ali-easar/",
                GitHub = "https://github.com/TamaraaAE",
                Summary = "Junior systemutvecklare med intresse för integrationer, databaser och DevOps. Erfarenhet av att arbeta i team och leverera högkvalitativa lösningar. Stark problemlösare med en passion för att lära mig nya teknologier och förbättra mina färdigheter."

            });

            context.SaveChanges();
        }
                       

    }
}
