using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Task
    {
        public int Id { get; set; }
        public string emailAdress { get; set; }
        
        public virtual void initialize()
        {
            throw new NotImplementedException();
        }
    }
}
