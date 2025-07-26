using OOP_Session03.BuiltiIterface;
using OOP_Session03.InterfaceEx1;
using OOP_Session03.InterfaceEx2;
using OOP_Session03.P01Ex1;
using OOP_Session03.P02Ex2;
using OOP_Session03.P02Ex3;

namespace OOP_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // P1:
            #region 1. What is the primary purpose of an interface in C#:
            // b) To define a blueprint for a class
            #endregion
            #region 2. Which of the following is NOT a valid access modifier for interface members in C#:
            // a) private
            #endregion
            #region 3. Can an interface contain fields in C#:
            // b) No
            #endregion
            #region 4. In C#, can an interface inherit from another interface:
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region 5. Which keyword is used to implement an interface in a class in C#:
            //  d) implements 
            #endregion
            #region 6. Can an interface contain static methods in C#:
            // a) Yes
            #endregion
            #region 7. In C#, can an interface have explicit access modifiers for its members:
            // b) No, all members are implicitly public
            #endregion
            #region 8. What is the purpose of an explicit interface implementation in C#:
            // a) To hide the interface members from outside access
            #endregion
            #region 9. In C#, can an interface have a constructor:
            // b) No, interfaces cannot have constructors
            #endregion
            #region 10. How can a C# class implement multiple interfaces:
            // c) By separating interface names with commas
            #endregion

            // P2:
            #region 1. Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces,ICircle and IRectangle,that inherit from IShape.Implement these interfaces in classes Circle and Rectangle.Test your implementation by creating instances of both classes and displaying their shape information:
            //Circle circle = new Circle() { Radious = 5 };
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle() { Width = 5, Length = 5 };
            //rectangle.DisplayShapeInfo();
            #endregion
            #region 2. In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //bool IsAuthenticateUser = authenticationService.AuthenticateUser("Rawan", "rawan0012");
            //bool IsAuthorizeUser = authenticationService.AuthorizeUser("Sara", "fRONT");
            //Console.WriteLine($"Rawan is {(IsAuthenticateUser ? "AuthenticateUser" : "Not AuthenticateUser")}");
            //Console.WriteLine($"Sara is {(IsAuthorizeUser ? "AuthorizeUser" : "Not AuthorizeUser")}");
            #endregion
            #region 3. we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters:
            INotificationService notificationService01 = new EmailNotificationService();
            INotificationService notificationService02 = new SmsNotificationService();
            INotificationService notificationService03 = new PushNotificationService();
            notificationService01.SendNotification("rawan@gmail.com", "This is Messaage");
            notificationService02.SendNotification("01278563210", "Hi,Mentor");
            notificationService03.SendNotification("rawan hosny", " A Messaage");
            #endregion
        }
    }
}
