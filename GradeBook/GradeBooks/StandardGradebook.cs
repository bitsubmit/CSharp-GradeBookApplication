using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradebook : BaseGradeBook
    {
        StandardGradebook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
