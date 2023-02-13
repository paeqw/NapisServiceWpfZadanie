namespace ClassLibrary1 { 
    public class NapisService : INapisService
    {
        private String napis;

        public NapisService(string napis)
        {
            this.napis = napis;
        }
        private string remoSpaces(string s)
        {
            String aa = "";
            char[] chars = s.ToCharArray();
            foreach (var el in chars)
            {
                if (el != ' ') aa += el.ToString();
            }
            return aa;
        }
        private string odwroc(string doOdwrocenia)
        {
            char[] a = doOdwrocenia.ToCharArray();
            char[] wyjscie = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                wyjscie[a.Length - 1 - i] = a[i];
            }
            String aa = "";
            foreach (var el in wyjscie) {
                if (el != ' ') aa += el.ToString();
            }
            return aa;
        }

        public bool CzyPalindrom()
        {   
            
            return (remoSpaces(this.napis) == odwroc(this.napis));
        }
        

        public int ileLiterWNapisie(char znak)
        {
            char[] a = this.napis.ToCharArray();
            int c = 0;
            foreach (var el in a) if (el == znak) c++;
            return c;
        }
    }
}