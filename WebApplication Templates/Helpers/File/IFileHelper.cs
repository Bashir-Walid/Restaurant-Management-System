namespace WebApplication_Templates.Helpers.File
{
    public interface IFileHelper
    {
        string SaveImge(IFormFile File, string foledrName, string OldmageName = null);
        string SaveDoc(IFormFile File, string folderName, string OldImageName = null);
    }
}
