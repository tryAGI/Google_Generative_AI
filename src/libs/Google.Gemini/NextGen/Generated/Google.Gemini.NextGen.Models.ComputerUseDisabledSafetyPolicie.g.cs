
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum ComputerUseDisabledSafetyPolicie
    {
        /// <summary>
        ///
        /// </summary>
        AccountCreation,
        /// <summary>
        ///
        /// </summary>
        CommunicationTool,
        /// <summary>
        ///
        /// </summary>
        DataModification,
        /// <summary>
        ///
        /// </summary>
        FinancialTransactions,
        /// <summary>
        ///
        /// </summary>
        LegalTermsAndAgreements,
        /// <summary>
        ///
        /// </summary>
        SensitiveDataModification,
        /// <summary>
        ///
        /// </summary>
        UserConsentManagement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseDisabledSafetyPolicieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseDisabledSafetyPolicie value)
        {
            return value switch
            {
                ComputerUseDisabledSafetyPolicie.AccountCreation => "account_creation",
                ComputerUseDisabledSafetyPolicie.CommunicationTool => "communication_tool",
                ComputerUseDisabledSafetyPolicie.DataModification => "data_modification",
                ComputerUseDisabledSafetyPolicie.FinancialTransactions => "financial_transactions",
                ComputerUseDisabledSafetyPolicie.LegalTermsAndAgreements => "legal_terms_and_agreements",
                ComputerUseDisabledSafetyPolicie.SensitiveDataModification => "sensitive_data_modification",
                ComputerUseDisabledSafetyPolicie.UserConsentManagement => "user_consent_management",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseDisabledSafetyPolicie? ToEnum(string value)
        {
            return value switch
            {
                "account_creation" => ComputerUseDisabledSafetyPolicie.AccountCreation,
                "communication_tool" => ComputerUseDisabledSafetyPolicie.CommunicationTool,
                "data_modification" => ComputerUseDisabledSafetyPolicie.DataModification,
                "financial_transactions" => ComputerUseDisabledSafetyPolicie.FinancialTransactions,
                "legal_terms_and_agreements" => ComputerUseDisabledSafetyPolicie.LegalTermsAndAgreements,
                "sensitive_data_modification" => ComputerUseDisabledSafetyPolicie.SensitiveDataModification,
                "user_consent_management" => ComputerUseDisabledSafetyPolicie.UserConsentManagement,
                _ => null,
            };
        }
    }
}