// email and password

namespace App;

interface IUser; 

{
public bool TryLogin(string username, string password);
public bool IsRole(Role role);

public Role GetRole();

}

enum Role
{
  None, 
  User,
  Guest,


}