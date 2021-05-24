using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RobotTermStore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            termStoreUtils.CriarItemNaTermStore(args[0], args[1], new System.Guid(args[2]), new System.Guid(args[3]));

           


            




        }

    }
}
    