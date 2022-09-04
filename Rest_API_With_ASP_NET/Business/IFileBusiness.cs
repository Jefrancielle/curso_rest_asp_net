using Microsoft.AspNetCore.Http;
using Rest_API_With_ASP_NET.Data.VO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rest_API_With_ASP_NET.Business
{
    public interface IFileBusiness
    {
        Task<FileDetailVO> SaveFileToDisk(IFormFile file);
        Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> files);
        byte[] GetFile(string fileName);
    }
}
