using NinjaTurtlesApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTurtlesApp.Web.Interfaces
{
    interface INinjaTurtle
    {
        NinjaTurtle GetTurtle(int id);
        void CreateTurtle(string name, string color, string description, string pictureLg, string pictureSm, string personality, string weapons);
      
        List<NinjaTurtle> GetAllTurtles();
        void DeleteTurtle(int id);
    
        void EditTurtle(int id,string name, string color, string description, string pictureLg, string pictureSm, string personality, string weapons);
   
    }
}
