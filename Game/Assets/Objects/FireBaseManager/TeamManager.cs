namespace Objects.FireBaseManager
{
    public static class TeamManager
    {
        public static void CreateTeam(string key, string name)
        {
            FirebaseManager.Reference.Child("Teams").Child(key).Child("Name").SetValueAsync(name);
        }
    }
}