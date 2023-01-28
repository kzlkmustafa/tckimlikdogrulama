using tckimlikdogrulama.Model;

namespace tckimlikdogrulama.Service
{
    public class SignupDal
    {
        Context c = new Context();
        public void Insert(signupModel signupModel)
        {
                c.Add(signupModel);
                c.SaveChanges();
        }


    }
}
