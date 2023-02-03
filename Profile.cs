using System;

namespace DatingProfile
{ 
  public class Profile{
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
    }

    public Profile(string name, int age, string city, string country){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = "they/them";
    }

    public void SetHobbies(string[] hobbies){
      this.hobbies  = hobbies;
    }


    public string ViewProfile(){
      string temp = "";
      foreach (string hobby in hobbies){
        temp += hobby +", ";
      }
      
      return $"Name: " + this.name + "\n Age: " + this.age  + "\n City: " + this.city + "\n Country: " + this.country + "\n Pronouns: " + this.pronouns +"\n Hobbies: " + temp ;
    }
  }
}
