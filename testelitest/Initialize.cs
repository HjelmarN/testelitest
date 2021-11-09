namespace testelitest
{
    public class Initialize
    {
        public Admin CreateAdmin()
        {
            Admin admin = new Admin();
            admin.Username = "admin1";
            admin.Password = "admin1234";

            return admin;
        }

        public void Hej()
        {

        }
    }
}