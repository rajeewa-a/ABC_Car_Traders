# ABC_Car_Traders
Standalone Windows application for car sale business using C#, .NET Framework, and Windows Forms.

## Functionality
**Admin-**
 - Login
 - Manage Car Details
 - Manage Car Part Details
 - Manage Customer Details
 - Manage Customer Orders
 - Generate Reports
 
 
**Customer-**
 - Register
 - Login
 - Search Cars
 - Search Car Parts
 - Order Cars/Car Parts
 - View Order

## Development Environment

 - Visual Studio 2019
 - .NET Framework 4.7.2
 - Microsoft SQL Server 2017

## Database Configuration
Edit the connection string in DAL/app.config to match your database setup.

    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
        <configSections>
        </configSections>
        <connectionStrings>
            <add name="DAL.Properties.Settings.ABC_Car_TradersConnectionString"
                connectionString="Data Source=DESKTOP-MPDGLCC\SQLEXPRESS;Initial Catalog=ABC_Car_Traders;Integrated Security=True"
                providerName="System.Data.SqlClient" />
        </connectionStrings>
    </configuration>
  
## Screenshots
![login](https://user-images.githubusercontent.com/70063725/170936606-878d289c-8813-4c3e-b1d5-6c245b58768f.PNG)
![register](https://user-images.githubusercontent.com/70063725/170936624-769c6d50-4ba3-403a-89c1-3e679918ca24.PNG)
![admin_updcar](https://user-images.githubusercontent.com/70063725/170936709-6a71153f-06f2-491f-a55c-cb6ca104bc38.PNG)
![admin_updpart](https://user-images.githubusercontent.com/70063725/170936723-b6908e11-af1e-429c-ab9e-04517b1b17fc.PNG)
![admin_addcar](https://user-images.githubusercontent.com/70063725/170936726-50918b1b-b9cb-44a6-9881-c5d49e100de8.PNG)
![admin_addpart](https://user-images.githubusercontent.com/70063725/170936733-bcd61df2-1da1-4a79-a904-10e84381dcd0.PNG)
![admin_cust](https://user-images.githubusercontent.com/70063725/170936737-41455857-d5f5-4f8e-b14a-30a820e4a0fa.PNG)
![admin_dash](https://user-images.githubusercontent.com/70063725/170936746-39b5a56c-f6ec-479e-8576-f711898ff65f.PNG)
![admin_order](https://user-images.githubusercontent.com/70063725/170936750-c3c10f73-b8a6-42bd-903d-0487428a7059.PNG)
![admin_report](htt![cust_part](https://user-images.githubusercontent.com/70063725/170936794-d7eb1137-a4fc-4aae-be1d-2228030dc5db.PNG)
![cust_car](https://user-images.githubusercontent.com/70063725/170936815-e502acd4-f4dc-446c-892c-dd11a9bce3ca.PNG)
![cust_carorder](https://user-images.githubusercontent.com/70063725/170936819-0495335f-b702-46cf-aea8-4c4192e0652a.PNG)
![cust_order](https://user-images.githubusercontent.com/70063725/170936826-2eedcb38-d573-4bac-99b5-42ae6a43fcc4.PNG)
