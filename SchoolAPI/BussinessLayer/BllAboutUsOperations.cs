using SchoolAPI.DataAccess;
using SchoolAPI.Interface;

namespace SchoolAPI.BussinessLayer
{
    public class BllAboutUsOperations : IBllAboutUsOperations
    {
        private readonly DB_SchoolMgmtContext _context;
        public BllAboutUsOperations(DB_SchoolMgmtContext context)
        {
            _context = context;

        }
        public IEnumerable<TblAboutUsMaster> GetAboutUsDetails()
        {
            var aboutuslist = _context.TblAboutUsMasters
                                    .Where(x => x.IsActive == true)
                                    .Select(x => new TblAboutUsMaster()
                                    {
                                        AboutUsHeading = x.AboutUsHeading,
                                        AboutsFileName = x.AboutsFileName,
                                        AboutsFilePath = x.AboutsFilePath,
                                    })
                                    .ToList(); // Execute the query and materialize the data
            return aboutuslist;
        }



    }
}
