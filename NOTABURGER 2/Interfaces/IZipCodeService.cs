using NOTABURGER_2.Models;

namespace NOTABURGER_2.Interfaces
{
    public interface IZipCodeService
    {
        Task<ZipModel> GetLocation(int zip);

    }
}
