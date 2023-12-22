using Bogus;
using DataGridViewCore1.Models;

namespace DataGridViewCore1.Classes;
internal class BogusOperations
{
    public static List<Human> People(int count = 15)
    {

        Faker<Human> fakePerson = new Faker<Human>()
            .RuleFor(p => p.FirstName, f => f.Person.FirstName)
            .RuleFor(p => p.LastName, f => f.Person.LastName);

        return fakePerson.Generate(count);

    }
}
