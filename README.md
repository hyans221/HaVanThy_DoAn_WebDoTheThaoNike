# Nike Sportswear E-Commerce Website

## Key Features

### 1. User Interface Design
- **Modern Layout**: The application utilizes a responsive design powered by Bootstrap, ensuring a consistent experience across devices.
- **Dynamic Components**: Integrates jQuery for enhanced interactivity and Font Awesome for intuitive icons.
- **Reusable Layouts**: Uses Layoutpage to maintain a consistent design across all pages.

### 2. Core Functionalities

#### 2.1 Home Page
- **Overview Display**: Showcases the latest products, featured items, and promotional offers.
- **Interactive Banners**: Includes dynamic banners highlighting current deals and new arrivals.

#### 2.2 Product Listing Page
- **Product Filtering**: Allows users to filter products by categories such as footwear, apparel, and accessories.
- **Sorting and Pagination**: Sort products by price, popularity, or ratings with easy-to-navigate pagination controls.
- **Advanced Search**: Provides a search bar for quickly finding specific products.

#### 2.3 User Authentication
- **Registration and Login**: Enables users to create accounts or log in using existing credentials.
- **Secure Authentication**: Implements security measures such as password hashing and input validation.

#### 2.4 Shopping and Checkout
- **Shopping Cart**: Users can add products to their cart, view items, and adjust quantities before checkout.
- **Checkout Process**: Simplified checkout with multiple payment options, ensuring a smooth purchase experience.
- **Order Tracking**: Users can view order history and track the status of their purchases.

### 3. Admin Panel

#### 3.1 Role Management
- **Admin and User Roles**: Role-based access ensures that only Admins can access sensitive functionalities.
- **Restricted Access**: Admin controls are secured to prevent unauthorized access.

#### 3.2 User Management
- **User CRUD Operations**: Admins can view, add, delete, and update user details.
- **Access Control**: Manage user roles and permissions directly from the admin panel.

#### 3.3 Product Management
- **Product CRUD Operations**: Full control over product inventory, including the ability to add, edit, and remove products.
- **Category Management**: Organize products into relevant categories for easier browsing.

#### 3.4 Order Management
- **Order Overview**: View and manage all customer orders, update order statuses, and handle returns or exchanges.
- **Sales Analytics**: Analyze sales performance through detailed reports and statistics.

#### 3.5 API Integration
- **Product API**: Publish a GET API endpoint for fetching product data, allowing integration with other platforms or third-party tools.
- **AJAX Implementation**: Use AJAX to fetch data from the API and dynamically display product lists on the admin site.

## Database Design

The system uses a **Code-First** approach for database management, which allows for easy updates and migrations.

![Database Diagram](https://github.com/user-attachments/assets/b9d668ac-a524-40e7-af1d-4b55f7a32254)


## Screenshots of Key Functionalities

### Home Page
![Home Page](images/home_page.png)

### Product Listing
![Product Listing](images/product_listing.png)

### Shopping Cart
![Shopping Cart](images/shopping_cart.png)

### Admin Dashboard
![Admin Dashboard](images/admin_dashboard.png)

### User Management
![User Management](images/user_management.png)

### Product Management
![Product Management](images/product_management.png)

### Order Management
![Order Management](images/order_management.png)

## Technology Stack

- **Frontend**: 
  - HTML, CSS, Bootstrap: Provides a responsive and attractive user interface.
  - JavaScript, jQuery: Adds interactivity and enhances user experience.
  - Font Awesome: Offers a wide range of icons for intuitive design.

- **Backend**: 
  - ASP.NET MVC: For building a scalable and maintainable backend.
  - Entity Framework (Code First): Simplifies database interactions and allows for seamless migrations.

- **Database**:
  - SQL Server: Manages data storage with robust security and performance.

## System Quality Requirements

- **Performance**: Optimized to handle high traffic with minimal loading times.
- **Security**: Secure authentication, role-based access, and data validation ensure data integrity and protection.
- **Scalability**: The system is designed to be easily scalable to accommodate future expansions.

## Future Enhancements

- **Mobile Optimization**: Enhance mobile responsiveness for a better shopping experience on smartphones.
- **Advanced Search Filters**: Add more detailed filters like brand, color, size, and price range.
- **Customer Reviews**: Implement a feature for customers to leave reviews and ratings for products.
- **Loyalty Program**: Introduce a rewards system to incentivize repeat purchases.

