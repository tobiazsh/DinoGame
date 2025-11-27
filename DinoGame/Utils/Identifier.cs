using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame.Utils
{
    public record Identifier (string nameSpace, string path)
    {
        public static Identifier Of(string nameSpace, string path)
        {
            return new Identifier(nameSpace, path);
        }
    }
}
