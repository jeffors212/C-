using calculadora.Model;

namespace calculadora.Services;

public interface PersonService
{
    Person Create(Person person);
    
    Person FindById(long Id);

    List<Person> FindAll();

    Person Update(Person person);
    
    Void Delete(long Id);
    
    
    
}