namespace FireBaseManager
{
    public static class TeamManager
    {
        public static void CreateTeam(string key, string name)
        {
            FirebaseManager.Reference.Child("Teams").Child(key).Child("Name").SetValueAsync(name);
        }

        public static string GetTeamUserCount()
        {
            var users = FirebaseManager.Reference.Child("Users").OrderByChild("Team_ID").EqualTo(UserManager.GetTeam()).GetValueAsync().Result.GetRawJsonValue();
            return users;
        }
    }
}