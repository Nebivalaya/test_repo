using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class OrganizationManager
    {
        static Dictionary<Guid, Organization> _organizationTypes;

        public static List<Organization> OrganizationList
        {
            get
            {
                return _organizationTypes.Select(se => se.Value).ToList();
            }
        }

        static OrganizationManager()
        {
            _organizationTypes = new Dictionary<Guid, Organization>();
            AddOrganization("test org");
        }

        public static Organization GetById(Guid id)
        {
            return _organizationTypes[id];
        }

        public static void AddOrganization(string name)
        {
            Guid id = Guid.NewGuid();
            _organizationTypes.Add(id, new Organization(id, name));
        }

        public static void UpdateOrganization(Guid id, string newName)
        {
            _organizationTypes[id].Name = newName;
        }

        public static bool DeleteOrganization(Guid id)
        {
            return _organizationTypes.Remove(id);
        }
    }
}
