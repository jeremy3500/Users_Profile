using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Profile
{
    public class Utils
    {
        private static Usuario myUser;

        internal static Usuario MyUser { get => myUser; set => myUser = value; }
    }
}
