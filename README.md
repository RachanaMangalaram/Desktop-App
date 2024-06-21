# Desktop App
## Description
This is a Windows Desktop Application created using Visual Studio and Visual Basic. The app allows users to create new submissions and view existing submissions. It has the following features:

## Features

● A main form with two buttons: "View Submissions" and "Create New Submission".

● A "View Submissions" form that displays submitted entries with "Previous" and "Next" buttons to navigate through them.

● A "Create New Submission" form with fields for Name, Email, Phone Number, and GitHub repo link, along with a stopwatch that can be paused and resumed.

Each button has a keyboard shortcut for ease of use.

## Installation and Setup

1 **Install Visual Studio**
   Ensure that Visual Studio is installed on your Windows machine. You can download it from [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/).

2 **Clone the Repository**
   Clone this repository to your local machine.

3.**Open the Project**
   Open Visual Studio and navigate to `File > Open > Project/Solution`. Open the `.sln` file located in the cloned repository.

4.**Build the Project**
   Build the project by navigating to `Build > Build Solution` or by pressing `Ctrl+Shift+B`.

   ## Usage

1.**Run the Application**
   Start the application by pressing `F5` or navigating to `Debug > Start Debugging`.

2.**View Submissions**
   - Click the "View Submissions" button or press the assigned keyboard shortcut `Ctrl+V`
   - Use the "Previous" and "Next" buttons to navigate through the submissions.
   - Previous shortcut `Ctrl+P`
   - Next shortcut `Ctrl+N`

3.**Create New Submission**
   - Click the "Create New Submission" button or press the assigned keyboard shortcut `Ctrl+N`
   - Fill in the fields for Name, Email, Phone Number, and GitHub repo link.
   - Use the stopwatch to track time by pausing and resuming it.
   - Toogle stopwatch shortcut `Ctrl+T`
   - Press `Ctrl+S` or click the "Submit" button to submit the form.
     
 ## Backend Integration

The app communicates with a backend server to save and retrieve submissions. Ensure the backend server is running and the API endpoints are correctly configured in the app settings.
