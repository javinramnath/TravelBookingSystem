The Travel Booking System is a web application built using ASP.NET Core MVC that allows users to browse travel destinations, book trips, and manage bookings. It also includes an admin panel for managing travel offers and a basic user account system.

This project demonstrates a full-stack MVC architecture with database integration using Entity Framework Core.

- User Features
User registration and login
Browse available travel destinations
View destination details
Book trips
View booking history
- Admin Features
Add new travel destinations
View all destinations
Manage travel offers
- Destination Features
View list of destinations
View individual destination details
Pricing display

Controllers/
    HomeController.cs
    AccountController.cs
    DestinationsController.cs
    BookingsController.cs
    AdminController.cs

Models/
    User.cs
    Destination.cs
    Booking.cs
    Review.cs

Views/
    Home/
    Account/
    Destinations/
    Bookings/
    Admin/
    Shared/
