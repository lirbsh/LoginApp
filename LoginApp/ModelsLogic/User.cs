using LoginApp.Models;

namespace LoginApp.ModelsLogic
{
    class User : UserModel
    {
        public override bool Login()
        {
            return true;
        }
    }
}
