using System.ComponentModel.DataAnnotations;

namespace Property_Agreement_Preparation.Models
{
    public class AgreementGenerationViewModel
    {
        /// <summary>
        /// Word template file uploaded by user (.docx, .doc, .dotx, .rtf)
        /// Contains mail merge fields for property agreement
        /// </summary>
        [Display(Name = "Agreement Template File")]
        public IFormFile? TemplateFile { get; set; }

        /// <summary>
        /// Access database file uploaded by user (.mdb, .accdb)
        /// Contains property, owner, transaction tables
        /// </summary>
        [Display(Name = "Property Database File")]
        [Required(ErrorMessage = "Database file is required")]
        public IFormFile? DatabaseFile { get; set; }

        /// <summary>
        /// Database table relationships for mail merge
        /// Format: "Properties.PropertyID = Owners.PropertyID, Properties.PropertyID = Transactions.PropertyID"
        /// Comma-separated relationship commands
        /// </summary>
        [Display(Name = "Database Relationships")]
        public string? Relationships { get; set; }

        /// <summary>
        /// Type of agreement generation
        /// Options: "single" - Generate one combined agreement, "multiple" - Generate separate agreements per property
        /// </summary>
        [Display(Name = "Agreement Type")]
        [Required]
        public string AgreementType { get; set; } = "single";

        /// <summary>
        /// Output document format
        /// Options: "docx" - Editable Word document, "pdf" - PDF with optional digital signatures
        /// </summary>
        [Display(Name = "Output Format")]
        [Required]
        public string OutputFormat { get; set; } = "docx";

        /// <summary>
        /// Enable or disable digital signature feature (only applicable for PDF output)
        /// </summary>
        [Display(Name = "Enable Digital Signature")]
        public bool EnableDigitalSign { get; set; } = false;

        /// <summary>
        /// Optional custom signature image file
        /// Supported formats: .png, .jpg, .jpeg, .gif, .bmp
        /// If not provided, default signature will be used
        /// </summary>
        [Display(Name = "Signature Image File")]
        public IFormFile? SignatureImage { get; set; }

        /// <summary>
        /// Comma-separated keywords to identify signature placement locations in document
        /// Default: "Sign, WITNESS, AuthorizedSign, Signature"
        /// Signature will be placed above these keywords
        /// </summary>
        [Display(Name = "Signature Keywords")]
        public string? SignatureKeywords { get; set; } = "SellerSign, Signature";

    }
}
