using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.BaseTypes
{
    public class StringGenerator : IGenerator
    {
        public Type GeneratorType => typeof(string);
        static Random random = new Random();
        public object Create()
        {
            int length = random.Next(1,16);
            StringBuilder builder = new StringBuilder();
            CharGenerator chr = new CharGenerator();
            for(int i = 0; i < length; i++)
            {
                builder.Append(chr.Create());
            }
            return builder.ToString();
        }
    }
}