# PDFFromRazor

PDFFromRazor is a sample project that demonstrates how to use Playwright together with Razor Pages to generate PDF files in .NET. This project was created to illustrate the integration between these technologies to create PDFs from dynamically rendered HTML pages.

## Features

- Use Playwright to render Razor Pages as PDFs.
- Support for dynamic data passed to views.
- Simple and straightforward project for learning and adaptation.

## Prerequisites

- .NET 6.0 or higher.

## How to Use

### Step 1: Clone the Repository

Clone this repository to your local machine:

```bash
git clone https://github.com/rcarubbi/PDFFromRazor.git
cd PDFFromRazor
```

### Step 2: Install Browsers

If Playwright browsers are not installed, uncomment the following lines in the code to install them:

```csharp
// Run once to install the browsers
Microsoft.Playwright.Program.Main(new[] { "install" });
return;
```

Run the project once with these lines uncommented, then comment them back after the browsers are installed.

### Step 3: Run the Project

Compile and run the project using the .NET CLI or Visual Studio:

```bash
dotnet run
```

### Step 4: Generate a PDF

The project includes endpoints or scripts to generate a PDF from a Razor Page. Check the code to adjust the template or the data provided.

Example of a Razor Page:

```html
<!-- Pages/Example.cshtml -->
<!DOCTYPE html>
<html>
<head>
    <title>PDF Example</title>
</head>
<body>
    <h1>Hello, @Model.Name!</h1>
    <p>This PDF was generated using Playwright and Razor Pages.</p>
</body>
</html>
```

Use Playwright in the code to render this page and save it as a PDF.

### Step 5: Customize

Adapt the Razor Pages and scripts to meet your specific PDF generation needs.

## Examples

Check the repository code for practical examples of how Playwright is used to generate PDFs from Razor Pages.

## Contributing

Contributions are welcome! Follow these steps to contribute:

1. Fork the repository.
2. Create a branch for your feature or bug fix:
   ```bash
   git checkout -b my-feature
   ```
3. Commit your changes:
   ```bash
   git commit -m "Description of my feature"
   ```
4. Push your branch to the remote repository:
   ```bash
   git push origin my-feature
   ```
5. Open a Pull Request in the original repository.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/rcarubbi/PDFFromRazor/blob/main/LICENSE) file for more information.

## Contact

If you have any questions or suggestions, feel free to open an issue in the [issues section](https://github.com/rcarubbi/PDFFromRazor/issues) or send an email to [rcarubbi@gmail.com](mailto:rcarubbi@gmail.com).
