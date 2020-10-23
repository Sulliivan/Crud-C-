using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class FormationMemoryRepository : IFormationRepository
    {
        private List<Formation> _formations = new List<Formation>();
        public FormationMemoryRepository()
        {
            _formations.Add(new Formation { Id = 1, Nom = "Creer votre site web avec ASP.NET Core", NomSeo = "asp-net-core", Description = "Grace à Blah blah Blah" });
            _formations.Add(new Formation { Id = 2, Nom = "Creer votre site web avec PHP", NomSeo = "php", Description = "Grace à cette formation Blah blah Blah" });
            _formations.Add(new Formation { Id = 3, Nom = "Devenez un pro du jardinage", NomSeo = "pro-jardinage", Description = "Apprenez a faire du jardinage" });
            _formations.Add(new Formation { Id = 4, Nom = "Photo Pro", NomSeo = "photo-pro", Description = "un pro de la photo, Blah blah Blah" });
        }

        public List<Formation> GetFormations(int nombre)
        {
            return _formations.OrderBy(qu => Guid.NewGuid()).Take(nombre).ToList();
        }

        public List<Formation> GetAllFormations()
        {
            return _formations;
        }

        public Formation GetFormationById(int iIdFormation)
        {
            /*foreach (var f in _formations)
            {
                if (f.Id == iIdFormation)
                    return f;
            }*/

            // return _formations.Where(f => f.Id == iIdFormation).FirstOrDefault();
            return _formations.FirstOrDefault(f => f.Id == iIdFormation);
        }
    }
}
