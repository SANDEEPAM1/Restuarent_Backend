namespace Restuarent_Backend.Utilities
{
    public static class GenerateCustomerId
    {
        public static string customIdGenerator(string userName, string email)
        {
            string userPart = userName.Length >= 5 ? userName.Substring(0, 5) : userName;
            string emailPart = email.Length>= 4 ? email.Substring(0, 4) : email;

            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");

            Random rand = new Random(); 
            int randomNumber = rand.Next(1000,9999);

            string CustomerId = $"{userPart}{timeStamp}{emailPart}{randomNumber}";

            return CustomerId;
        }
    }
}
