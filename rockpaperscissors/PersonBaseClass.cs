using System;

namespace rockpaperscissors
{
    public class PersonBaseClass
    {
        private string _firstName;
        public string FirstName {

            get {
                return _firstName;
            }
            set{

                if(value.Length<2) {
                    throw new InvalidOperationException("your name should be at least 2 characters long");
                    
                }

                _firstName=value;

            }
        }

       

    }
}