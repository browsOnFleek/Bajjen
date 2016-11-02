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

            string regex = @"/^$|\s +/";

            if (regex.Equals(testSubject)) {

                _notEmpty = false;

            }

            return _notEmpty;

        }
    }
}
