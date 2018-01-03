using Common.Structures.HttpBasicAuthentication;
using static DevOps.VersionControl.Functions.GetGitHubApiCredentials.GitHubApiCredentials;

namespace Metaproject.Users.CDorst.GitHubAccessToken
{
    public static class GitHubCredentials
    {
        private const string cdorst = nameof(cdorst);

        public static BasicAuthenticationCredentials CDorst => GetCredentials(cdorst);
    }
}
