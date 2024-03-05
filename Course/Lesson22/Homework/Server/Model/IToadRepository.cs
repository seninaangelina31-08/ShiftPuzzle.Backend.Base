namespace Homework
{
    public interface IToadRepository
    { 
        List<Toad> GetAllToads();
        Toad GetToadByName(string name);
        void AddToad(Toad toad);
        void DeleteToad(string name);
    }
}