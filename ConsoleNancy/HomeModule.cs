using System.Collections;
using System.Collections.Generic;
using Nancy;

namespace ConsoleNancy
{
	public class HomeModule : NancyModule
	{
		public HomeModule ()
		{
            Get["/"] = _ => Response.AsJson(GetPeopleList());
		}

	    private static IEnumerable<Person> GetPeopleList()
	    {
	        return new List<Person>
	        {
	            new Person("John Doe", 21),
                new Person("John Doe", 21),
	        };
	    }
	}

    public class Person
    {
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}

