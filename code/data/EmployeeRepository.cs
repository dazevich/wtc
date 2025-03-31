interface EmployeeRepository 
{
    public void SaveEvent(int id, EmployeeEvent empEvent);

    public void GetEvents(int id);
}