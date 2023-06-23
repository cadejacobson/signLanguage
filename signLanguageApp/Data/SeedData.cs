using signLanguageApp.Models;
using signLanguageApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace signLanguageApp.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider, Assembly assembly)
    {
        using (var context = new signLanguageAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<signLanguageAppContext>>()))
        {

            // Look for any Signs.
            if (context.Sign.Any())
            {
                return;   // DB has been seeded
            }
            string resourceName = "signLanguageApp.Data.signs.csv";
            string line;
            using (Stream stream = assembly?.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    Debug.WriteLine(line);
                    string[] values = line.Split(",");

                    context.Sign.Add(
                        new Sign
                        {
                            Name = values[0],
                            Image = values[1],
                            Collection = values[2]
                        }
                    );
                }
            }
            context.SaveChanges();
        }
    }
}
