using Microsoft.AspNetCore.Mvc;

namespace WebApIDemo.Controllers.Models
{
    public class MembersRepository : IMembers
    {

        List<Member> listmembers=new List<Member>
        {
            new Member{Id=1,FirstName="Bill",LastName="Gates",City="New York"},
            new Member{Id=2,FirstName="Till",LastName="Gates",City="Mumbai"},
            new Member{Id=3,FirstName="Mill",LastName="Gates",City="London"},
            new Member{Id=4,FirstName="Jill",LastName="Gates",City="Pune"},
            new Member{Id=5,FirstName="Nill",LastName="Gates",City="Banglore"},

        };
        public Member GetMember(int id)
        {
            return listmembers.FirstOrDefault(x=>x.Id==id);
           
        }
     
        public List<Member> GetMembers()
        {
            return listmembers;
        }
    }
}
