namespace Games_Pro.Service
{
    public interface IGameService
    {
        IEnumerable<Game> GetAll();
        Game? GetById(int id);
        Task<Game?> Update(EditGameFormViewModel model);
        Task Create(CreateGameFormViewModel model);
        bool Delete(int id);




    }
}
