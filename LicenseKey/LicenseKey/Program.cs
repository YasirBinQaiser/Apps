// See https://aka.ms/new-console-template for more information
    using System.Text;
    //Program Calls     =============================================================
    string key = GenerateLicenseKey ("123-456", "John Doe", "My Product", 1, false, false);
    Console.WriteLine (key);
    bool status = VerifyLicenseKey ("123-456", "John Doe", "My Product", 1, false, false, key );
    Console.WriteLine (status.ToString());
    status = VerifyLicenseKey ("123-456", "John Doe", "My Product", 1, false, false, "1234-1234-1234-1234-1234-1234-1234-1234" );
    Console.WriteLine (status.ToString());

    //Main API Functions =============================================================
    bool VerifyLicenseKey ( string userID,      string userName, 
                            string poductName,  int licenseType, 
                            bool isPersonal,    bool isTrial,
                            string licenseKey
                          )
        {
        return (GenerateLicenseKey (userID, userName, poductName, licenseType, isPersonal, isTrial) ==  licenseKey);  
        }

    string GenerateLicenseKey ( string userID,      string userName, 
                                string poductName,  int licenseType, 
                                bool isPersonal,    bool isTrial
                              )
        {
        string input = userID + "|" + userName.ToLower() +
                                "|" + poductName + 
                                "|" + licenseType.ToString() + 
                                "|" + isPersonal.ToString() +
                                "|" + isTrial.ToString();

        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            int i = 0;
            //Convert to string XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX format
            foreach (byte b in hashBytes) 
                {
                if (i % 2 == 0 && i != 0)
                    sb.Append ("-");                
                sb.Append($"{b:X2}");
                i++;              
                }
            return sb.ToString();    
            }           
        }





