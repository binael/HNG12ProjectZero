namespace HNG12StageZero
{
    public class StageZero
    {
        public string Email { get; set; }
        public string Current_datetime { get; set; }
        public string Github_url { get; set; }

        public StageZero()
        {
            Email = "nbinael@yahoo.com";
            DateTime today = DateTime.UtcNow;
            Current_datetime = today.ToString("yyyy-MM-ddTHH-mm-ssZ");
            Github_url = "https://github.com/binael/HNG12ProjectZero";
        }
    }
}
