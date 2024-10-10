Requirements:
1.	Employee Model:

o	Design a robust employee model with the following properties:

        Employee ID: Auto-generated unique identifier.
        Full Name: String, required.
        Position: String, required.
        Department: String, required.
        Email Address: String, required, must follow valid email format.
        Date of Joining: DateTime, required.

2.	Features:

 o Home Page:

    	Display a paginated list of employees with sorting options (e.g., by name, department).
    	Provide a button to navigate to the Add Employee page.
    	Each employee entry should have action buttons to edit and delete the record, along with a visual indication (e.g., a badge) for new employees who joined within the last 30 days.
o	Add Employee Page:

    	A responsive form to add a new employee. All fields (except Employee ID) should be required.
    	Implement client-side validation using Data Annotations to provide immediate feedback.
    	On successful submission, the new employee should be added to the list, and the user should be redirected to the home page with a success message.
o	Edit Employee Page:

    	A form pre-populated with the existing employee's details for editing.
    	On submission, the updated details should be validated, saved, and the user should be redirected to the home page with a confirmation message.
o	Delete Confirmation:

    	Implement a modal confirmation dialog before deleting an employee. The dialog should clearly show the employee's name and a warning message.
4.	Validation:

o	Enforce comprehensive validation on all forms:

    	Required fields must not be empty.
    	The email address must be valid.
    	The phone number should follow a specified pattern (e.g., 10-digit numbers).
    	Date of joining cannot be a future date.
5.	Data Persistence:

    	Initially, use an in-memory list to store employee data.
    	Optional: For an advanced learning experience, implement a data access layer using Entity Framework Core to connect the application to a relational database (e.g., SQLite, SQL Server) and perform CRUD operations.
6.	UI/UX:

    	Utilize Bootstrap or a similar front-end framework to enhance the application's aesthetics and responsiveness.
    	Implement a consistent navigation bar for easy access to Home, Add Employee, and Edit Employee pages.
    	Ensure accessibility features are included to support users with disabilities (e.g., screen reader compatibility).
7.	Bonus Features (Optional):

    	Search Functionality: Allow users to filter employees by name, department, or position with real-time updates to the displayed list.
    	Pagination: Implement pagination to handle large datasets effectively, providing options for users to select the number of entries displayed per page.
    	Sorting: Allow users to sort the employee list by different fields (e.g., name, position) to facilitate easier navigation.
    	Export to CSV: Provide an option to export the employee list to a CSV file for offline access or reporting purposes.

