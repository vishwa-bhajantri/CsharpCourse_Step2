namespace Interfacebasics
{
    interface interface1
    {
        int age {  get; set; }
        string name {  get; set; }
        int getAge();
        string getName();
        void getMessage();

        void getEmployeeById(int empId);
    }

    interface interface3
    {
        void getEmpByLocation(string location);
  
    }

    interface interface2 : interface1, interface3
    {
        int getEmpList();
    }
}