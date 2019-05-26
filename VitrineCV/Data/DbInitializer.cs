using VitrineCV.Models;
using System;
using System.Linq;

namespace VitrineCV.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CVContext context)
        {
            context.Database.EnsureCreated();

            if (context.Formations.Any())
            {
                return;
            }

            var formations = new Formation[]
            {
                new Formation { Organisme = "Elan Formation", Intitule = "Formation «Développeur Web/Web Mobile»", Annee = "2019", Ville = "Strasbourg" },
                new Formation { Organisme = "EPITA", Intitule = "Première année de cursus ingénieur (Niveau)", Annee = "2016-2017", Ville = "Le Kremlin-Bicêtre" },
                new Formation { Organisme = "Lycée Kléber", Intitule = "CPGE Scientifique", Annee = "2013-2015", Ville = "Strasbourg", Specialisation = "Physique-Chimie" },
                new Formation { Organisme = "Lycée Freppel", Intitule = "Baccalauréat Scientifique", Annee = "2010-2011", Ville = "Obernai", Specialisation = "Mathématiques" }
            };
            foreach (Formation f in formations)
            {
                context.Formations.Add(f);
            }
            context.SaveChanges();
        }
    }
}