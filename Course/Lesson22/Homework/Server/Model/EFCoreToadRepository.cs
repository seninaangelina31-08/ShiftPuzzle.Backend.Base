using System.Collections.Generic;
using System.Linq;

namespace Homework
{

    public class EFCoreToadRepository : IToadRepository
    {
        private readonly ToadContext _context;

        public EFCoreToadRepository(ToadContext context)
        {
            _context = context;  
        }
 
        public List<Toad> GetAllToads()
        {
            return _context.Toads.ToList();
        }

        public Toad GetToadByName(string name)
        {
            return _context.Toads.FirstOrDefault(p => p.Name == name);
        }

        public void AddToad(Toad toad)
        {
            _context.Toads.Add(toad);
            _context.SaveChanges();  
        }

        public void DeleteToad(string name)
        {
            var toad = _context.Toads.FirstOrDefault(p => p.Name == name);
            if (toad != null)
            {
                _context.Toads.Remove(toad);
                _context.SaveChanges();
            }
        }
    }
}
