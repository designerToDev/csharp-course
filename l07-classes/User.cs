public class User {
    private string firstName;
    private string lastName;
    private string email;
    private string startDate;

    public string getFirstName() {
        return firstName;
    }

    public void setFirstName( string name) {
        if (!string.IsNullOrEmpty(name)); {
            firstName = name;
        }
    }
    public string getLasttName() {
        return lastName;
    }

    public void setLastName( string name) {
        lastName = name;
    }
    public string getEmail() {
        return email;
    }

    public void setEmail( string inEmail) {
        this.email = inEmail;
    }
    public string getStartDate() {
        return startDate;
    }
}
