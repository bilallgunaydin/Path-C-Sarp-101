using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace ConsolePhoneDirectoryApplication
{
    class Person
    {
        static List<Person> _personlist;
        
        static Person()
        {
            _personlist=new List<Person>
            {
                new Person{ Name="Veronica", Surname="Velazquez", PhoneNumber="0641-272-79-21"},
                new Person{ Name="Jermaine", Surname="Mcintosh", PhoneNumber="0369-638-40-01"},
                new Person{ Name="Kenyon", Surname="Puckett", PhoneNumber="0441-675-38-76"},
                new Person{ Name="Camden", Surname="Bradford", PhoneNumber="0963-275-62-87"},
                new Person{ Name="Curran", Surname="Soto", PhoneNumber="0799-446-05-04"}
            };
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }
        

        public static bool AddPerson(string name, string surname, string phoneNumber)
        {
                if(!string.IsNullOrWhiteSpace(name) && (!string.IsNullOrWhiteSpace(surname) && (!string.IsNullOrWhiteSpace(phoneNumber))))
                {
                    Person person=new Person();
                    person.Name=name;
                    person.Surname=surname;
                    person.PhoneNumber=phoneNumber;
                    _personlist.Add(person);
                    return true;
                }
                else
                    return false;
        }

        public static List<Person> GetAll()
        {
            return _personlist;
        }        

        public static bool Remove(Person item)
        {
            if(item!=null)
            {
                 _personlist.Remove(item);
                return true;
            }

            else
                return false;
            
        }

        public static Person Update(string name, string surname, string phonenumber, Person person)
        {
            bool success=PhoneFormatControl(phonenumber);
            if(!string.IsNullOrWhiteSpace(name) && (!string.IsNullOrWhiteSpace(surname) && (!string.IsNullOrWhiteSpace(phonenumber))) && (person!=null) && (success))
            {
                person.Name=name;
                person.Surname=surname;
                person.PhoneNumber=phonenumber;
                return person;
            }
            else
                return null;
        }

        public static Person GetPerson(string name)
        {
            foreach (var item in Person.GetAll())
            {
                if(name==item.Name || name==item.Surname)
                  return item;
            }
            return null;

        }

        public static void GetList()
        {
            Console.WriteLine("------- Kişi Listesi -------\n");
            foreach (var item in Person.GetAll())
            {
                Console.WriteLine("İsim: "+item.Name);
                Console.WriteLine("Soyisim: "+item.Surname);
                Console.WriteLine("Numara: "+item.PhoneNumber);
                Console.WriteLine("-");
            }
        }

        public static List<Person> GetListforNameorSurname(string nameorsurname)
        {
            List<Person> personlist=new List<Person>();
            foreach (var item in Person.GetAll())
            {   
                if(nameorsurname==item.Name || nameorsurname==item.Surname)
                {   
                    personlist.Add(item);
                }
            }
            return personlist;
        }

        public static void GetListForAlphabet(int alphabetType)
        {
            List<Person> sortedList=Person.GetAll().OrderBy(n=>n.Name).ToList();
            
            if(alphabetType==1)
            {
                foreach (var item in sortedList)
                {
                Console.WriteLine("İsim:"+item.Name);
                Console.WriteLine("Soyisim:"+item.Surname);
                Console.WriteLine("Telefon Numarası:"+item.PhoneNumber);
                Console.WriteLine("-");
                }
            }
            else if(alphabetType==2)
            {
                sortedList.Reverse();
                 foreach (var item in sortedList)
                {
                Console.WriteLine("İsim:"+item.Name);
                Console.WriteLine("Soyisim:"+item.Surname);
                Console.WriteLine("Telefon Numarası:"+item.PhoneNumber);
                Console.WriteLine("-");
                }
            }
        }
        public static List<Person> GetListforNumber(string searchPhoneNumber)
        {
            List<Person> personlist=new List<Person>();
            foreach (var item in Person.GetAll())
            {   
                if(searchPhoneNumber==item.PhoneNumber)
                {   
                    personlist.Add(item);
                }
            }
            return personlist;
        }

        public static bool PhoneFormatControl(string phonenumber)
        {
            string phoneControl=@"^(0(\d{3})-(\d{3})-(\d{2})-(\d{2}))$";
            Match check=Regex.Match(phonenumber,phoneControl,RegexOptions.IgnoreCase);
            return check.Success;
        }
    }
}

