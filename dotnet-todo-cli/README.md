# dotnet-todo-cli
This is a .NET Core 8 CLI To-Do List application.

## Project Overview
The application consists of three main screens:
- **Home Screen**: Displays the list of to-do items organized by Category and Type.
- **Completed Tasks Screen**: Shows the list of completed tasks.
- **Task Entry/Edit Screen**: Allows users to manage task information, including creating and editing tasks.

## File Structure
- **src/Program.cs**: Entry point of the application, initializes the app and sets up the main menu.
- **src/Handlers/TodoHandler.cs**: Contains methods for CRUD operations on to-do items.
- **src/Models/TodoItem.cs**: Defines the structure of a to-do item.
- **src/Data/todos.json**: Stores the to-do items in JSON format.
- **src/UI/home.html**: HTML for the Home screen.
- **src/UI/completed.html**: HTML for the Completed Tasks screen.
- **src/UI/task.html**: HTML for the Task Entry/Edit screen.
- **src/UI/styles.css**: CSS styles for the UI, utilizing Bootstrap 5.1.
- **src/UI/app.js**: JavaScript for handling user interactions and data fetching.

## Setup Instructions
1. Clone the repository.
2. Navigate to the project directory.
3. Run the application using the command: `dotnet run`.

## Usage Guidelines
- Use the Home screen to view and manage your to-do items.
- Mark tasks as completed or edit them as needed.
- Access the Completed Tasks screen to view all completed items.
- Use the Task Entry/Edit screen to add new tasks or modify existing ones.

## Technologies Used
- .NET Core 8
- HTML, CSS, JavaScript
- Bootstrap 5.1 for styling
- JSON for data storage

## Contributing
Feel free to submit issues or pull requests for improvements and bug fixes.