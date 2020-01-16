public class Human {
    Name name;
    int height;
    Human father;
    public String toString(){
        if (name.lName == null && father!=null){
            if (father.name.lName != null){
                name.lName = father.name.lName;
                if (name.pName == null){
                    return "Человек с именем "+name.fName + " " + name.lName+" и ростом "+this.height;
                }
                else return "Человек с именем "+name.fName + " " + name.lName+ name.pName +" и ростом "+this.height;
            }
        }
        if (name.pName == null && father!=null){
            if (father.name.fName != null){
                name.pName = father.name.fName + "ович";
                if (name.lName == null){
                    return "Человек с именем "+name.fName + " " + name.pName+" и ростом "+this.height;
                } else return "Человек с именем "+name.fName + " " + name.lName+ " " + name.pName + " и ростом "+this.height;
            }
        }
        if (name.pName == null) {
            if (name.lName == null) return "Человек с именем "+name.fName+" и ростом "+this.height;
            else return "Человек с именем "+name.fName + " " + name.lName+" и ростом "+this.height;
        } else {
            if (name.lName == null){
                return  "Человек с именем "+name.fName + " " + name.pName+" и ростом "+this.height;
            }
        }
        return "Человек с именем "+name.lName + " " + name.fName + " " + name.pName+" и ростом "+this.height;
    }
}
