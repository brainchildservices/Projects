using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Aneesh myName=new Aneesh();
            myName.FirstName="Aneesh";
            myName.MiddleName="";
            myName.LastName="S";
            Console.WriteLine(myName.FullName);
        }
    }
    public class Aneesh
    {
        private string firstName="";
        private string middleName="";
        private string lastName="";
        private string fullName;
        public string FullName
        {
            get
            {
                fullName=firstName+middleName+lastName;
                return fullName;
            }
        }
        //Read-Only Property
        public string FirstName
        {
            set
            {
                firstName=value;
            }
        }
        public string MiddleName
        {
            set
            {
                if(middleName=="")
                middleName=value;
                else
                middleName=" "+value;
            }
        }
        public string LastName
        {
            set
            {
                lastName=" "+value;
            }
        }
    }
}
