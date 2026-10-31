using System.Collections.Generic;

class carDAO
{
    public Dictionary<int, List<Car>> carDictionary = new Dictionary<int, List<Car>>();
    public List<Car> carList(int target)
    {
        if (carDictionary.ContainsKey(target))
            return carDictionary[target];
        else return new List<Car>();
    }
}