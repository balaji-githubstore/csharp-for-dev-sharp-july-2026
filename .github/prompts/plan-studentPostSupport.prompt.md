## Plan: Add student POST support

The current dashboard already uses a simple in-memory approach for employee CRUD inside one request handler, so the student addition can follow the same pattern cleanly. The plan is to add a student model with id, name, and percentage, store incoming students in memory, and accept POST requests at /students by reading the JSON body and appending the new item.

### Steps
1. Review the existing ASP.NET Core request handling in EmployeeDashboard/Program.cs.
2. Add a student DTO with fields for id, name, and percentage.
3. Create an in-memory student list and extend the POST branch to handle /students.
4. Deserialize the request body and add the parsed student to the list.
5. Verify the behavior by running the app and submitting a sample POST request.

### Relevant files
- EmployeeDashboard/Program.cs — add the student POST logic and in-memory storage.
- EmployeeDashboard/Dtos/Employee.cs — mirror the existing DTO pattern for student data.

### Verification
1. Run the dashboard project.
2. Send a POST request to /students with JSON like:
   - id
   - name
   - percentage
3. Confirm the request is accepted and the student is stored in memory.

### Scope
- Included: POST support for student details with in-memory storage.
- Excluded: database persistence, validation rules, and any extra CRUD operations beyond the requested POST behavior.
