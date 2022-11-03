using System.Collections.ObjectModel;

namespace SAP.MVVC {
    public class UserViewModel {
        public ObservableCollection<User> Users { get; set; }
        public User CurrentUser { get; set; }

        public UserViewModel() {
            Users = new ObservableCollection<User>() {
                new User{UserId = 1,FirstName="Raj",LastName="Beniwal",City="Delhi",State="DEL",Country="INDIA"},
                new User{UserId=2,FirstName="Mark",LastName="henry",City="New York", State="NY", Country="USA"},
                new User{UserId=3,FirstName="Mahesh",LastName="Chand",City="Philadelphia", State="PHL", Country="USA"},
                new User{UserId=4,FirstName="Vikash",LastName="Nanda",City="Noida", State="UP", Country="INDIA"},
                new User{UserId=5,FirstName="Harsh",LastName="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
            };
        }

        public void AddUser() {
            int value = Users.Count + 1;
            Users.Add(new User { UserId = value, FirstName = "TestUser" + value, LastName = "TestUserLastname", City = "Irgendwo", Country = "Aserbaidschan", State = "NCY" });
        }
    }
}
