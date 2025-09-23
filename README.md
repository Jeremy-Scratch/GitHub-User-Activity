# GitHub User Activity 📝
A simple command-line interface (CLI) using the GitHub API built with C# and .NET 9.0. This tool allows you to get the recents events made by a GitHub user.

The project manage the Github user as input.

# ✨ Key Features

• Fetch recent GitHub user activity (commits, create, watch events).

• Readable and friendly Events list

• Authenticated requests with GitHub personal access token (optional).

# 🛠️ Tech Stack

• C#: The main programming language.

• .NET 9.0 SDK: The framework used to build the application.

• IDE: Developed using Visual Studio Code.

PROJECT LINK     https://roadmap.sh/projects/github-user-activity

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/Jeremy-Scratch/GitHub-User-Activity.git
   cd GitHub-User-Activity

2. Restore required packages:

    ```bash
    dotnet restore

## Usage

1. Build the project:

    ```bash
    dotnet build

2. Run the application with a GitHub username:

    ```bash
    dotnet run 
    <your-github-username>
    ```

    Example:

    ```bash
    dotnet run
    john-doe
