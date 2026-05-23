using System.Runtime.CompilerServices;

// Test assembly is signed with the same strong-name key (src/key.snk),
// so its public key matches the one below. Required for InternalsVisibleTo
// to grant access to a strong-named friend assembly.
[assembly: InternalsVisibleTo("Google.Gemini.IntegrationTests, PublicKey=" +
    "0024000004800000940000000602000000240000525341310004000001000100" +
    "a15c0239e6083b7f1e31b6b61bac5e07e24a11b4e404d04247d9c19c423af2cc" +
    "b7695d3ab0cbc8f5fd2262ed133e2229eaef079f4eb4305a9de21d65c7b0e609" +
    "88f418d85410a3f94d6bd6f05e35b477e3dbc165cbdb1c0f4891a0792d7c7a11" +
    "55b46e4c8a43cf76836dd7c19870d6b86946156ebb2b96c7f5b8644a706c95d9")]
