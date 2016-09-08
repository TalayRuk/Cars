using System.Collections.Generic;
//namespace can be anything doesn't have to be .Objects (this is conventional)
//as long as input the same namespace in HomeModule at very top
namespace Dealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _instances = new List<Car> {};


    public Car (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

  }

}
