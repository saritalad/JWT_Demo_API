namespace WebApIDemo.Controllers.Models
{
    public interface IMembers
    {

        List<Member> GetMembers();
        Member GetMember(int id);
    }
}
