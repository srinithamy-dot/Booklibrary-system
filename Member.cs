namespace Booklibrary_system
{
    public class Member
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Member(string memberId, string name, string phone)
        {
            MemberId = memberId;
            Name = name;
            Phone = phone;
        }
    }
}