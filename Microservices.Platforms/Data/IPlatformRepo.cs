namespace Microservices.Platforms.Data
{
    public interface IPlatformRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<PlatformRepo> GetAllPlatforms();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PlatformRepo GetById(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="platform"></param>
        void CreatePlatform(PlatformRepo platform);
    }
}
