using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
   public static class Validation
    {





        public static bool notEmpty(string testSubject) {

            bool _notEmpty = true;

            string regex = @"";

            if (regex.Equals(testSubject)) {

                _notEmpty = false;
                Console.WriteLine("error");

            }

            return _notEmpty;

        }

        public static bool emptyString(string testString) {

            bool empty = false;

            if (string.IsNullOrEmpty(testString))
            {
                empty = true;
            }
            return empty;
        }

     

    }
}
