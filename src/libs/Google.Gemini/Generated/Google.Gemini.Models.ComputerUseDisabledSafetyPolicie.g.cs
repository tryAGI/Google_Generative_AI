
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerUseDisabledSafetyPolicie
    {
        /// <summary>
        /// Safety policy for account creation.
        /// </summary>
        AccountCreation,
        /// <summary>
        /// Safety policy for communication tools (e.g. Gmail, Chat, Meet).
        /// </summary>
        CommunicationTool,
        /// <summary>
        /// Safety policy for data modification.
        /// </summary>
        DataModification,
        /// <summary>
        /// Safety policy for financial transactions.
        /// </summary>
        FinancialTransactions,
        /// <summary>
        /// Safety policy for legal terms and agreements.
        /// </summary>
        LegalTermsAndAgreements,
        /// <summary>
        /// Unspecified safety policy.
        /// </summary>
        SafetyPolicyUnspecified,
        /// <summary>
        /// Safety policy for sensitive data modification.
        /// </summary>
        SensitiveDataModification,
        /// <summary>
        /// Safety policy for user consent management.
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
                ComputerUseDisabledSafetyPolicie.AccountCreation => "ACCOUNT_CREATION",
                ComputerUseDisabledSafetyPolicie.CommunicationTool => "COMMUNICATION_TOOL",
                ComputerUseDisabledSafetyPolicie.DataModification => "DATA_MODIFICATION",
                ComputerUseDisabledSafetyPolicie.FinancialTransactions => "FINANCIAL_TRANSACTIONS",
                ComputerUseDisabledSafetyPolicie.LegalTermsAndAgreements => "LEGAL_TERMS_AND_AGREEMENTS",
                ComputerUseDisabledSafetyPolicie.SafetyPolicyUnspecified => "SAFETY_POLICY_UNSPECIFIED",
                ComputerUseDisabledSafetyPolicie.SensitiveDataModification => "SENSITIVE_DATA_MODIFICATION",
                ComputerUseDisabledSafetyPolicie.UserConsentManagement => "USER_CONSENT_MANAGEMENT",
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
                "ACCOUNT_CREATION" => ComputerUseDisabledSafetyPolicie.AccountCreation,
                "COMMUNICATION_TOOL" => ComputerUseDisabledSafetyPolicie.CommunicationTool,
                "DATA_MODIFICATION" => ComputerUseDisabledSafetyPolicie.DataModification,
                "FINANCIAL_TRANSACTIONS" => ComputerUseDisabledSafetyPolicie.FinancialTransactions,
                "LEGAL_TERMS_AND_AGREEMENTS" => ComputerUseDisabledSafetyPolicie.LegalTermsAndAgreements,
                "SAFETY_POLICY_UNSPECIFIED" => ComputerUseDisabledSafetyPolicie.SafetyPolicyUnspecified,
                "SENSITIVE_DATA_MODIFICATION" => ComputerUseDisabledSafetyPolicie.SensitiveDataModification,
                "USER_CONSENT_MANAGEMENT" => ComputerUseDisabledSafetyPolicie.UserConsentManagement,
                _ => null,
            };
        }
    }
}