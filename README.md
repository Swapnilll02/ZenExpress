# ZenExpress

ZenExpress is an online courier service application built using ASP.NET MVC and C#. It allows users to conveniently book shipments, choose from different delivery options, and track their delivery details. The application provides a streamlined and user-friendly interface for efficient and flexible courier service management.

## Features

- **User-Friendly Shipment Booking**: Simple form to enter shipment details, including sender and receiver information, pickup date, package weight, and items to deliver.
- **Flexible Delivery Options**: Users can choose between "One Day Delivery" and "Standard Delivery" options, with automatic pricing updates.
- **Cost Calculator**: Real-time calculation of the total amount based on package weight and delivery type.
- **Secure UPI Payment**: Users can complete payment using UPI, with validation for transaction ID.
- **Responsive Design**: Styled with Bootstrap for a clean and responsive design that works on all devices.

## Project Structure

The project follows the MVC architecture, organized into:

- **Models**: Contains `Shipment` class which defines the shipment properties and validation rules.
- **Views**: Contains Razor views for `Ship`, `Summary`, and the main pages.
- **Controllers**: `ShipmentController` handles routing for shipment-related actions, such as displaying the booking form and processing the shipment details.
