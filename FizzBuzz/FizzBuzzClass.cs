using System;

namespace FizzBuzz
{

    public class FizzBuzzClass
    {
          public String Execute(int[] data)
          {
              String str = "";
              String delim = ",";
              for (int i = 0; i < data.Length; i++)
              {
                  if (i == 0)
                  {
                      str = Process(data[i]);
                  }
                  else { 
                      str = str + delim + Process(data[i]);
                  }
              }

              return str;

          }
        

          public string Process(int num)
          {
              if (dividedBy3(num) && dividedBy5(num))
              {
                  return "FizzBuzz";
              }
              if (dividedBy3(num))
              {
                  return "Fizz";
              }
              if (dividedBy5(num))
              {
                  return "Buzz";
              }

              return num.ToString();
          }

          public Boolean dividedBy3(int num)
          {
              return num % 3 == 0;
          }
          public Boolean dividedBy5(int num)
          {
              return num % 5 == 0;
          }

      

       
    }
}
