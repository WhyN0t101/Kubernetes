# Contributing to Custom Kubernetes Manager

Thank you for considering contributing to this project!

## How to Contribute

### Reporting Bugs

If you find a bug, please create an issue with:
- Clear description of the problem
- Steps to reproduce
- Expected vs actual behavior
- Environment details (Visual Studio version, .NET version, Kubernetes version)
- Screenshots if applicable

### Suggesting Features

Feature requests are welcome! Please create an issue with:
- Clear description of the proposed feature
- Use case and benefits
- Potential implementation approach (if applicable)

## Development Setup

1. Fork the repository
2. Clone your fork
3. Open `Kubernetes.sln` in Visual Studio 2022
4. Restore NuGet packages
5. Build the solution
6. Ensure you have access to a Kubernetes cluster for testing

## Code Guidelines

### C# Code Style
- Follow standard C# coding conventions
- Use meaningful variable and method names
- Add XML documentation comments for public APIs
- Keep methods focused and concise

### Windows Forms
- Follow Windows Forms best practices
- Ensure UI remains responsive during operations
- Handle exceptions gracefully with user-friendly error messages

### Kubernetes Integration
- Use async/await for all Kubernetes API calls
- Handle API errors appropriately
- Test against multiple Kubernetes versions when possible

## Testing

- Test your changes with a local Kubernetes cluster (Docker Desktop or Minikube)
- Verify functionality with different namespace contexts
- Ensure existing features are not broken
- Test error handling scenarios

## Commit Messages

Write clear, concise commit messages:
- Use present tense ("Add feature" not "Added feature")
- Keep first line under 50 characters
- Add detailed description if needed

## Pull Request Process

1. Update README.md if needed
2. Ensure the solution builds successfully
3. Test your changes thoroughly
4. Create a Pull Request with:
   - Clear description of changes
   - Link to related issues
   - Testing performed
   - Screenshots for UI changes

## Questions?

Feel free to create an issue with your question or reach out to the maintainers.

Thank you for contributing!
