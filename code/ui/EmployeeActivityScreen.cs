public class EmployeeActivityScreen
{
    private EmployeeRepository repository;
    private EmployeeEventAdapter adapter;

    public void ShowActivity(List<int> ids) {
        for(var id in ids) {
            var data = GetEmployeeActivity(id);
            Show(adapter.ToString(data));
        }
    }

    public GetEmployeeActivity(int id) {
        return GetData(id);
    }

    private GetData(int id) {
        return repository.GetEvents(id);
    }
}