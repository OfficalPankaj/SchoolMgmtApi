using SchoolAPI.DataAccess;

namespace SchoolAPI.Interface
{
    public interface IBllAboutUsOperations
    {

        IEnumerable<TblAboutUsMaster> GetAboutUsDetails();
    }
}
