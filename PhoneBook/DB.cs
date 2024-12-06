using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class DB
    {
        List<Human> humans;

        public DB()
        {
            humans = new();
        }

        public List<Human> Search(string search)
        {
            return humans.Where(s=> s.FirstName.Contains(search) || 
            s.SecondName.Contains(search) || 
            s.ThrityName.Contains(search) ||
            s.Address.Contains(search) ||
            s.Phones.FirstOrDefault(p => 
                 p.Number.Contains(search)) != null).ToList();
        }

        public void Add(Human human)
        {
            humans.Add(human);
        }

        public void Remove(Human human)
        {
            humans.Remove(human);
        }
    }
}
