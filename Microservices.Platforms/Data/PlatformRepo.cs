namespace Microservices.Platforms.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private AppDbContext context;

        public PlatformRepo(AppDbContext cntxt)
        {
            context = cntxt;
        }

        public void CreatePlatform(PlatformRepo platform)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlatformRepo> GetAllPlatforms()
        {
            return context.Platforms.ToList();
        }

        public PlatformRepo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (context.SaveChanges() >= 0);
        }
    }
}
