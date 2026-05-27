# Syncfusion ASP.NET Core – Property Agreement Document Generation Demo

This repository contains a complete showcase sample demonstrating how to build an **Automated Property Agreement Document Generation System** using **Syncfusion DocIO**, **Syncfusion PDF**, and **Syncfusion Smart Data Extractor** libraries in an ASP.NET Core MVC application. The sample illustrates how real estate professionals can streamline property agreement creation by merging Access database data with Word templates, supporting both single and bulk document generation with watermarks and digital signature capabilities.

---

## 📁 Project Structure

```
├── Controllers/
│   └── HomeController.cs
├── Models/
│   └── AgreementGenerationViewModel.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   └── Shared/
├── wwwroot/
│   ├── Data/
│   │   ├── Template.docx
│   │   └── PropertyDatabase.mdb
│   ├── PDF.pfx
│   ├── Signature.png
│   └── Watermark.png
└── README.md
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022 or VS Code
- A valid **Syncfusion License Key** (or use the free Community License)

### 1. Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/DocIO-Property-Agreement-Preparation
cd Policy-Document-Preparation
```

### 2. Install Dependencies

Restore all NuGet packages:

```bash
dotnet restore
```

### 3. Add Syncfusion License Key

In your `Program.cs`, register your Syncfusion license:

```csharp
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
```

### 4. Run the Application

```bash
dotnet run
```

Open your browser and navigate to:
```
https://localhost:5001
```

---

## 📋 How to Use

### Basic Workflow

1. **Upload Template Document**
   - Upload your Word template (.docx, .doc, .rtf) with merge fields
   - Drag & drop supported
   - Or use default template provided

2. **Upload Database File**
   - Upload Access database (.mdb or .accdb) containing property data
   - Or use default database file
   - Database tables will be automatically detected

3. **Configure Data Relationships**
   - Define table relationships if using multiple tables (optional)
   - Format: TableName | Relationship
   - Example: Buyers | SellerID = %Sellers.SellerID%

4. **Select Agreement Type**
   - **Single Agreement** – Generate one document
   - **Multiple Agreements** – Generate separate documents for each record

5. **Choose Output Format**
   - **DOCX** – Editable Word document
   - **PDF** – Distribution-ready format

6. **Configure Extra Features**
   - **Watermark** (Optional)
      - **Text Watermark** – Add custom text (e.g., "CONFIDENTIAL")
      - **Picture Watermark** – Upload watermark image
      - Applied to all pages
   - **Separate Files** – Generate individual files per policy (ZIP archive)
   - **Digital Signature** *(PDF only)* 
     - Upload your signature image (PNG, JPG, etc.)
     - Enter keywords where signatures should appear (e.g., "SellerSign, BuyerSign")
     - Signatures will automatically appear above those keywords in the PDF

7. **Generate Documents**
   - Click "Generate Documents" button
   - Download automatically starts
   - Single file or ZIP archive based on selection

---

## 🎯 Use Cases

### Property Agreement Scenarios

- **Purchase Agreement Generation** – Create personalized property purchase agreements from template and database
- **Bulk Agreement Generation** – Generate multiple property agreements in a single operation
- **Lease Agreement Creation** – Merge property data with lease templates
- **Property Transfer Documents** – Produce property transfer agreements with dynamic data
- **Rental Agreement Preparation** – Generate rental agreements with tenant and property information

---

## 🔗 Resources

- [Syncfusion DocIO Getting Started](https://help.syncfusion.com/document-processing/word/word-library/net/getting-started)
- [Mail Merge](https://help.syncfusion.com/document-processing/word/word-library/net/working-with-mailmerge)
- [Word to PDF Conversion](https://help.syncfusion.com/document-processing/word/conversions/word-to-pdf/overview)
- [Watermark](https://help.syncfusion.com/document-processing/word/word-library/net/applying-watermark)
- [Smart Data Extractor](https://help.syncfusion.com/document-processing/data-extraction/smart-data-extractor/overview)

---

## 📣 Try It Out

Clone the repository, run the sample, and discover how Syncfusion DocIO can revolutionize property agreement document generation in your real estate operations.

### Customization

This sample application is provided as a reference implementation and can be freely customized to suit your specific business requirements.

You can modify the templates, database sources, merge logic, watermarks, signatures, and output formats based on your use case. If you have any questions, need clarification, or require assistance while customizing this sample, please feel free to contact our [Syncfusion Support Team](https://support.syncfusion.com/support/tickets/create) for guidance.

---

## 📄 License and Copyright

> This is a commercial product and requires a paid license for possession or use. Syncfusion® licensed software, including this component, is subject to the terms and conditions of Syncfusion®. To acquire a license, visit https://www.syncfusion.com/account/downloads.

Are you already a Syncfusion user? You can download the product setup [here](https://www.syncfusion.com/account/downloads). If you're not yet a Syncfusion user, you can download a [30-day free trial](https://www.syncfusion.com/downloads).

---

## 📞 Support

For technical support and questions:
- [Syncfusion Support Portal](https://support.syncfusion.com/support/tickets/create)
- [Documentation](https://help.syncfusion.com/)
- [Community Forums](https://www.syncfusion.com/forums)

---