using C42_G01_OOP04.AuthenticationService;
using C42_G01_OOP04.Shape;
using System;

namespace C42_G01_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Q2
            // Question 1:
            //What is the primary purpose of an interface in C#?
            //Answer: b) To define a blueprint for a class

            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //Answer: a) private

            //Question 3:
            //Can an interface contain fields in C#?
            //Answer: b) No

            //Question 4:
            //In C#, can an interface inherit from another interface?
            //Answer: b) Yes, interfaces can inherit from multiple interfaces

            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //Answer: d) implements

            //Question 6:
            //Can an interface contain static methods in C#?
            //Answer: b) No

            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //Answer: b) No, all members are implicitly public

            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //Answer: a) To hide the interface members from outside access

            //Question 9:
            //In C#, can an interface have a constructor?
            //Answer: b) No, interfaces cannot have constructors

            //Question 10:
            //How can a C# class implement multiple interfaces?
            //Answer: c) By separating interface names with commas
            #endregion


            #region Part02

            #region Q01
            //Circle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle(5, 6);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "Ali";
            //string password = "122";
            //string role = "user";

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //bool isAuthorized = authService.AuthorizeUser(username, role);

            //Console.WriteLine($"User authenticated: {isAuthenticated}");
            //Console.WriteLine($"User authorized: {isAuthorized}");
            #endregion

            #region Q3
            INotificationService emailService = new EmailNotificationService(); 
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string emailRecipient = "Gabdo@gmail.com";
            string smsRecipient = "01254644455";
            string pushRecipient = "Gabdo@gmail.com";

            string emailMessage = " your order has been shipped and will arrive soon.";
            string smsMessage = " your verification code is 123456.";
            string pushMessage = " you have a new message in your inbox.";

            emailService.SendNotification(emailRecipient, emailMessage);
            smsService.SendNotification(smsRecipient, smsMessage);
            pushService.SendNotification(pushRecipient, pushMessage);



            #endregion

            #endregion
        }
    }
}
