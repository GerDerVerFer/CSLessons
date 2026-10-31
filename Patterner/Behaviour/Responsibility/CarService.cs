class CarService
{
    carDAO DAO;

    public CarService()
    {
        DAO = new carDAO();
    }
    public void saveCar(Car target, int userID)
    {
        if (!DAO.carDictionary.ContainsKey(userID))
            DAO.carDictionary.Add(userID, new System.Collections.Generic.List<Car>());

        DAO.carDictionary[userID].Add(target);
    }
}