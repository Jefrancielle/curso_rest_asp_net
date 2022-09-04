using Rest_API_With_ASP_NET.Data.VO;
using Rest_API_With_ASP_NET.Model;


namespace Rest_API_With_ASP_NET.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);
        bool RevokeToken(string username);
        User RefreshUserInfo(User user);

    }
}
