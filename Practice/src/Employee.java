public class Employee {
    Name name;
    Department department;

    public String toString() {
        if (name.lName == department.chief.name.lName){
            return name.lName + " начальник отдела "+department.title;
        }
        return name.lName + " работает в отделе "+department.title+" начальник которого "+department.chief.name.lName;
    }
}
