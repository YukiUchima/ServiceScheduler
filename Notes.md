
### Salon
	- Specialized employees
	- New employee under training
	- Customer can choose which employee with specific experience

### Models
	- Schedule
	- Employees
		- id
		- name
		- specialization code
		- Speed time to complete customer
	- Skills/Specializations
		- EmployeeId
		- Sign-in TIME
		- SEATED time (check-in)
		- FINISH time
		- total time
	
	- Cost
	- Customer
		- CustomerId
		- First
		- Last
		- Middle (optional)
		- Phone Number
		- Email (optional)

	- Appointments
		- AppointmentId
		- Time/Date
		- Service Id
		- CustomerId
		- EmployeeId
		- Check-In Time
		

#### Goal:
	- make it easy to determine wait time 
	- improve service with scheduling
	- Data collection: determine confidence of when work can be done
		- 

### Separation of Concerns:

| Layer	| Responsibility | Why It’s Used |
| ------| -------------- | ------------- |
| Model | Represents database tables (Employee, Person, Appointment).	| Encapsulates data structure.
| Repository | Handles data access (queries, CRUD operations). | Separates data logic from business logic.
| Service|Contains business logic (e.g., validate employee before adding to DB).|Centralizes business rules and promotes reusability.
| Controller|Handles HTTP requests (maps routes, returns API responses).|Separates API logic from business logic.
| Interface | Defines contracts for repositories. |	Enables dependency injection, flexibility, and testing.