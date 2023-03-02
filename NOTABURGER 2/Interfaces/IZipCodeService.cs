using NOTABURGER_2.Models;

namespace NOTABURGER_2.Interfaces
{
    public interface IZipCodeService
    {
        Task<List<ZipModel>> GetLocation(int zip);

    }
}
