
using ShatibyApi.Models.Domain;

namespace ShatibyApi.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
