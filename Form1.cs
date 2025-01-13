using _10_AracKiralama_WF.Context;
using _10_AracKiralama_WF.Entities;

namespace _10_AracKiralama_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            // 1. MARKALAR VE MODELLER
            SeedBrandsAndModels(context);

            // 2. KULLANICILAR
            SeedUsers(context);

            // 3. ARAÇLAR
            SeedCars(context);

            // 4. MÜÞTERÝLER VE PROFÝLLER
            SeedCustomersAndProfiles(context);

            // 5. KÝRALAMALAR
            SeedRents(context);
        }

        private void SeedBrandsAndModels(AppDbContext context)
        {
            // Mevcut Brand ve Model verileriniz aynen kalacak
            // context.Add(new Brand { BrandName = "Audi" }); vs...
        }

        private void SeedUsers(AppDbContext context)
        {
            var users = new List<User>
    {
        new User
        {
            Email = "admin@rentacar.com",
            Password = "admin123",
            FullName = "Admin User",
            PhoneNum = "5551112233",
            Role = Enums.Role.Admin
        },
        new User
        {
            Email = "john.doe@email.com",
            Password = "123456",
            FullName = "John Doe",
            PhoneNum = "5551234567",
            Role = Enums.Role.User
        },
        new User
        {
            Email = "ahmet.yilmaz@email.com",
            Password = "123456",
            FullName = "Ahmet Yýlmaz",
            PhoneNum = "5559876543",
            Role = Enums.Role.User
        }
    };

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        private void SeedCars(AppDbContext context)
        {
            var cars = new List<Car>
    {
        // Audi Araçlarý
        new Car
        {
            Chassis = "AUD123A4",
            FuelType = Enums.FuelType.Diesel,
            ExaminationLastDate = new DateTime(2024, 3, 15),
            HasInsurance = true,
            InsuranceLastDate = new DateTime(2024, 12, 31),
            SeatCount = 5,
            Kilometer = 25000,
            Year = 2021,
            ModelID = 2, // A4
            LicansePlate = "34AUD001",
            Color = Enums.Color.Black,
            IsRented = false,
            Price = 1500
        },
        // BMW Araçlarý
        new Car
        {
            Chassis = "BMW12345",
            FuelType = Enums.FuelType.Gas,
            ExaminationLastDate = new DateTime(2024, 6, 15),
            HasInsurance = true,
            InsuranceLastDate = new DateTime(2024, 12, 31),
            SeatCount = 5,
            Kilometer = 15000,
            Year = 2022,
            ModelID = 11, // 3 Serisi
            LicansePlate = "34BMW001",
            Color = Enums.Color.White,
            IsRented = false,
            Price = 2000
        },
        // Mercedes Araçlarý
        new Car
        {
            Chassis = "MERC98765",
            FuelType = Enums.FuelType.Hybrid,
            ExaminationLastDate = new DateTime(2024, 8, 20),
            HasInsurance = true,
            InsuranceLastDate = new DateTime(2024, 12, 31),
            SeatCount = 5,
            Kilometer = 5000,
            Year = 2023,
            ModelID = 21, // C Serisi
            LicansePlate = "34MRC001",
            Color = Enums.Color.Brown,
            IsRented = false,
            Price = 2500
        }
    };

            context.Cars.AddRange(cars);
            context.SaveChanges();
        }

        private void SeedCustomersAndProfiles(AppDbContext context)
        {
            var customers = new List<Customer>
    {
        new Customer
        {
            Name = "John",
            Surname = "Doe",
            CitizenID = "12345678901",
            BirthDate = new DateTime(1990, 1, 1),
            PhoneNumber = "5551234567",
            LisanceType = "B",
            LicenceYear = new DateTime(2015, 1, 1),
            UserID = 2,
            CustomerProfile = new CustomerProfile
            {
                Name = "John Doe",
                BloodType = Enums.BloodType.ABPositive,
                RelativeName = "Jane Doe",
                RelativeType = "Eþ",
                RelativePhoneNumber = "5551112233"
            }
        },
        new Customer
        {
            Name = "Ahmet",
            Surname = "Yýlmaz",
            CitizenID = "98765432100",
            BirthDate = new DateTime(1985, 5, 15),
            PhoneNumber = "5559876543",
            LisanceType = "B",
            LicenceYear = new DateTime(2010, 1, 1),
            UserID = 3,
            CustomerProfile = new CustomerProfile
            {
                Name = "Ahmet Yýlmaz",
                BloodType = Enums.BloodType.APositive,
                RelativeName = "Ayþe Yýlmaz",
                RelativeType = "Eþ",
                RelativePhoneNumber = "5552223344"
            }
        }
    };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private void SeedRents(AppDbContext context)
        {
            var rents = new List<Rent>
    {
        new Rent
        {
            CustomerID = 1,
            CarID = 1,
            StartRentDate = DateTime.Now.AddDays(-10),
            EndRentDate = DateTime.Now.AddDays(-5)
        },
        new Rent
        {
            CustomerID = 2,
            CarID = 2,
            StartRentDate = DateTime.Now,
            EndRentDate = DateTime.Now.AddDays(5)
        }
    };

            context.Rents.AddRange(rents);
            context.SaveChanges();
        }
    }
}
