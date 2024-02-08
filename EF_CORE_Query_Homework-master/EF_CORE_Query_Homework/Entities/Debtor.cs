

namespace EF_CORE_Query_Homework.Entities;

public class Debtor
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDay { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Debt { get; set; }
    public Debtor() 
    {
    
    }
    public Debtor(int ıd, string fullName, DateTime birthDay, string phone, string email, string address, int debt)
    {
        Id = ıd;
        FullName = fullName;
        BirthDay = birthDay;
        Phone = phone;
        Email = email;
        Address = address;
        Debt = debt;
    }
    public override string ToString()
    {
        return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}";
    }
}
