using PlatformService.Model;

namespace PlatformService.Data;

public interface IPlatformRepo
{
    bool saveChanges();
    IEnumerable<Platform> getAllPlatforms();
    Platform GetPlatformById(int id);
    void CreatePlatform(Platform plat);
}