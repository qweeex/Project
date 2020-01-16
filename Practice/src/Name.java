public class Name {
    String fName;
    String lName;
    String pName;

    public String toString() {
        if (pName == null) {
            if (lName == null) return fName;
            else return fName + " " + lName;
        } else {
            if (lName == null){
                return  fName + " " + pName;
            }
        }
        return lName + " " + fName + " " + pName;
    }
}
