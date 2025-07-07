// This file contains JavaScript code for fetching data from the JSON file, posting new to-do tasks, and handling user interactions on the UI.

const apiUrl = './Data/todos.json';

async function fetchTodos() {
    const response = await fetch(apiUrl);
    const todos = await response.json();
    return todos;
}

async function displayTodos() {
    const todos = await fetchTodos();
    const todoList = document.getElementById('todo-list');
    todoList.innerHTML = '';

    todos.forEach(todo => {
        const listItem = document.createElement('li');
        listItem.textContent = `${todo.title} - ${todo.status}`;
        const completeButton = document.createElement('button');
        completeButton.textContent = 'Complete';
        completeButton.onclick = () => completeTodo(todo.id);
        listItem.appendChild(completeButton);
        todoList.appendChild(listItem);
    });
}

async function completeTodo(id) {
    const todos = await fetchTodos();
    const todo = todos.find(t => t.id === id);
    if (todo) {
        todo.status = 'Completed';
        await saveTodos(todos);
        displayTodos();
    }
}

async function saveTodos(todos) {
    await fetch(apiUrl, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(todos)
    });
}

document.addEventListener('DOMContentLoaded', displayTodos);