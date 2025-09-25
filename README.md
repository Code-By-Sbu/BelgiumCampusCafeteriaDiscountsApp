# BelgiumCampusCafeteriaDiscountsApp
This project is a C# console application developed to help the Belgium Campus Cafeteria determine which students qualify for a high-performing student discount. The application captures student data, evaluates eligibility based on set criteria, and provides summary statistics.
Features:

Capture Student Details: Users can input student information including full name, residence status, years on campus, years at current residence, monthly allowance/salary, and average marks. Data is stored in a structured collection for easy processing. Users can continue adding student records until they choose to stop.

Determine Discount Eligibility: The application evaluates each student’s eligibility based on the following rules:

Must be a residence student who has stayed on campus for more than a year.

Must have an overall average above 85%.

Students with a monthly allowance above R1000 are automatically denied a discount.

Store and Count Results: Eligible students are stored in a separate collection. The program also counts the number of students granted and denied the discount.

Display Statistics: Provides a clear summary of the number of students who qualified or were denied the discount.

Menu-Driven Interface: Uses an Enum-based menu to allow users to easily navigate between options: Capture Details, Check Discount Qualification, Show Qualification Status, and Exit.

Purpose:

This application demonstrates C# programming skills, including method creation, collection handling, input validation, conditional logic, and enumeration usage. It emphasizes practical problem-solving by automating the eligibility check process and generating accurate summary statistics for decision-making.
