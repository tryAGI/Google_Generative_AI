# Free Tier and Image Generation

This SDK works with both Free Tier and Paid Tier Gemini API projects, but Google enables features per model, not per SDK method.

## Free Tier vs Paid Tier

- Free Tier is available only for selected Gemini API models and comes with lower quota limits.
- Paid Tier requires upgrading a Google AI Studio project to billing.
- Google currently documents Paid Tier setup as linking billing in AI Studio and, for many accounts, adding a minimum prepaid balance.

## Native Image Generation Is Not Currently Free Tier

The image helper methods in this SDK default to native image output models:

- `GenerateImageAsync()`
- `EditImageAsync()`
- `GenerateImageWithReferencesAsync()`

By default they use `gemini-2.5-flash-image`.

Google's Gemini API pricing page currently marks these native image generation options as not available on the Free Tier:

- `gemini-2.5-flash-image`
- `imagen-*` models such as `imagen-4.0-generate-001`

That means there is currently no SDK-side switch that "turns on" free native image generation. If your project stays on the Gemini API Free Tier, these image output helpers should be treated as Paid Tier features.

## What You Need For Image Generation In This SDK

To call `GenerateImageAsync()`, `EditImageAsync()`, or `GenerateImageWithReferencesAsync()` successfully, make sure you have:

1. A Google AI Studio project in a supported region.
2. Billing enabled for that project.
3. A valid paid billing state for that project, such as a positive prepaid balance when Google requires prepay for your account.
4. An API key created from that Paid Tier project.
5. A model that supports native image output, such as `gemini-2.5-flash-image`.

## Common Confusion

- Google AI Studio usage can be free even though some Gemini API models are Paid Tier only.
- A Free Tier key can still use multimodal models that accept image input, such as vision-style prompts with `gemini-2.5-flash`.
- Accepting image input is not the same as returning generated image output.

## Example

```csharp
using Google.Gemini;

using var client = new GeminiClient(apiKey);

// The API key must come from a Paid Tier AI Studio project for native image output.
var result = await client.GenerateImageAsync(
    prompt: "A watercolor fox reading a map",
    imageSize: "1K");
```

## Official Google References

- [Gemini API pricing](https://ai.google.dev/gemini-api/docs/pricing)
- [Gemini API billing](https://ai.google.dev/gemini-api/docs/billing)
- [Gemini API rate limits](https://ai.google.dev/gemini-api/docs/rate-limits)
- [Available regions for Google AI Studio and Gemini API](https://ai.google.dev/gemini-api/docs/available-regions)
- [Gemini image generation docs](https://ai.google.dev/gemini-api/docs/image-generation)
