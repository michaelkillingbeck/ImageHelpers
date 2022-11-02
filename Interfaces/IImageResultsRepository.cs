namespace Image_Colour_Swap.Interfaces;

public interface IImageResultsRepository<T>
{
    Task<T> LoadPagedResults(string nextPage);
    Task<T> LoadResults(string id);
    Task<bool> SaveResults(T results);
}