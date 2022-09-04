using Rest_API_With_ASP_NET.Data.VO;

namespace Rest_API_With_ASP_NET.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
        TokenVO ValidateCredentials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
