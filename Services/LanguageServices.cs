namespace RadzenRTL.Services 
{
    public class LanguageServices
    {

        private string direction;
        private string language;

        public string getLRD() { return direction; }

        public string getLanguage() { return language; }

        public void setLanguage(string _language) { 
            language = _language;
            if (language == "ar") { direction = "RTL"; } else { direction = "LTR"; }
        }

    }
}