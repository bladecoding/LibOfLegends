namespace LibOfLegends
{
	public class ConnectionProfile
	{
		public readonly AuthenticationProfile Authentication;
		public readonly RegionProfile Region;

		public readonly string User;
		public readonly string Password;

		public ConnectionProfile(AuthenticationProfile authentication, RegionProfile region, string user, string password)
		{
			Authentication = authentication;
			Region = region;
			User = user;
			Password = password;
		}
	}
}
