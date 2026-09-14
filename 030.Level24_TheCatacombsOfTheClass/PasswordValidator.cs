using System;
using System.Collections.Generic;
using System.Text;

/*
 ======================== Boss Battle    The Password Validator    100 XP ======================================
   The fifth and final pedestal describes a class that represents a concept more abstract than the first four:
   a password validator. You must create a class that can determine if a password is valid (meets the rules
   defined for a legitimate password). The pedestal initially doesn’t describe any rules, but as you brush the
   dust off the pedestal, it vibrates for a moment, and the following rules appear:
   • Passwords must be at least 6 letters long and no more than 13 letters long.
   • Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
   • Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.

   That last rule seems random, and you wonder if the pedestal is just tormenting you with obscure rules.
   You ponder for a moment about how to decide if a character is uppercase, lowercase, or a number, but
   while scratching your head, you notice a piece of folded parchment on the ground near your feet. You
   pick it up, unfold it, and read it:

   foreach with a string lets you get its characters!
   > foreach (char letter in word) { ... }
   char has static methods to categorize letters!
   > char.IsUpper('A'), char.IsLower('a'), char.IsDigit('0')
   That might be useful information! You are grateful to whoever left it behind. It is signed simply “A.”

Objectives:
   • Define a new PasswordValidator class that can be given a password and determine if the
   password follows the rules above.
   • Make your main method loop forever, asking for a password and reporting whether the password is
   allowed using an instance of the PasswordValidator class.

 */

namespace Level24_TheCatacombsOfTheClass
{
    internal static class PasswordValidator
    {
        /// <summary>
        /// Passwords must be at least 6 letters long and no more than 13 letters long.
        /// Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
        /// Passwords cannot contain a capital T or an ampersand (&).
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Check(string password)
        {
            // iteration helpers
            int lowerChar = 0;
            int upperChar = 0;
            int digit = 0;


            //Length validation, password must be between 6 and 13 letters
            if (password.Length < 6 || password.Length > 13)
            {
                return false;
            }

            //Loop through the password and iterate any uppers, lower and digit.
            //Check if the password contains forbidden characters (capital T or ampersand (&)) and return false if it does.
            foreach (char c in password)
            {
                if (c == 'T' || c == '&')
                {
                    return false;
                }

                if (char.IsLower(c))
                {
                    lowerChar++;
                }

                else if (char.IsUpper(c))
                {
                    upperChar++;
                }

                else if (char.IsDigit(c))
                {
                    digit++;
                }
            }

            //check for password validation
            return (lowerChar > 0 && upperChar > 0 && digit > 0);
        }
    }
}