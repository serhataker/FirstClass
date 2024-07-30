using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Person
    {

        private string name;
        private DateTime birthDay;
        private string surname;

        public string Name


        {
            get  {return name; }

            set {
                name = value;
            }
        }

        public DateTime BirthDay
        {

            get { return birthDay; }

            set
            {
                DateTime minDate = new DateTime(1900, 1, 1);

                if (value>minDate)
                {
                    birthDay = value;
                }
            }

           
                
                
                
        }
        public string Surname 
        
        {
            get { return surname; 
            } set
                

            {surname=value; 
            }
        
        
        }
    } 

}