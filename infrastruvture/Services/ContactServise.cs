using Domain.Entities;
using Infrastruvture.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastruvture.Services;

public class ContactServise:GenericGrud<Contact>
{
    public ContactServise(DataContext context) : base(context)
    {

    }
}
