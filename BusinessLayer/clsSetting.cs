using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     public class clsSetting
    {
        static  string ChangeText(int Key, string Text)
        {
            string CopyText = "";
            for (int i = 0; i < Text.Length; i++)
            {
                CopyText += Convert.ToChar((int)Text[i] + Key);
            }
            return CopyText;
        }

        static public string Encryption(string Text)
        {
            return ChangeText(2, Text);
        }

        static public string Decryption(string Text)
        {
            return ChangeText(-2, Text);
        }


        static public bool sPermission(int Permission, clsUsers.enPermission UPermission)
        {
            if (Permission == -1)
            {
                return true;
            }
            if ((Permission & (int)UPermission ) == (int)UPermission)
            {
                return true;
            }
            return false;
        }
        static public string MessageErrorPermissionForms(string NameForm)
        {
            return ($"You don't have any permission a this Form: {NameForm}");
        }
        static public string  MessageErrorPermissionClients(string NameClientPermission)
        {
            return ($"You don't have any permission a this tools: {NameClientPermission}");
        }


        static public string NumberToText(int Number)
        {

            if (Number == 0)
            {
                return "";
            }

            if (Number >= 1 && Number <= 19)
            {
                string[] arr = { "", "One","Two","Three","Four","Five","Six","Seven",
        "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen",
          "Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };

                return arr[Number] + " ";

            }

            if (Number >= 20 && Number <= 99)
            {
                string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                return arr[Number / 10] + " " + NumberToText(Number % 10);
            }

            if (Number >= 100 && Number <= 199)
            {
                return "One Hundred " + NumberToText(Number % 100);
            }

            if (Number >= 200 && Number <= 999)
            {
                return NumberToText(Number / 100) + "Hundreds " + NumberToText(Number % 100);
            }

            if (Number >= 1000 && Number <= 1999)
            {
                return "One Thousand " + NumberToText(Number % 1000);
            }

            if (Number >= 2000 && Number <= 999999)
            {
                return NumberToText(Number / 1000) + "Thousands " + NumberToText(Number % 1000);
            }

            if (Number >= 1000000 && Number <= 1999999)
            {
                return "One Million " + NumberToText(Number % 1000000);
            }

            if (Number >= 2000000 && Number <= 999999999)
            {
                return NumberToText(Number / 1000000) + "Millions " + NumberToText(Number % 1000000);
            }

            if (Number >= 1000000000 && Number <= 1999999999)
            {
                return "One Billion " + NumberToText(Number % 1000000000);
            }
            else
            {
                return NumberToText(Number / 1000000000) + "Billions " + NumberToText(Number % 1000000000);
            }


        }

    }
}
