# Gemini API Free Tier

This SDK works with both Free Tier and Paid Tier Gemini API projects. The important rule is that pricing is determined by the model you use, not by the SDK method name.

## Billing And Tiers

Google's billing docs currently describe the Gemini API tiers this way:

- New accounts start on the Free Tier.
- To move to a paid tier, you set up billing in Google AI Studio.
- Some newer AI Studio users may be required to use prepaid billing during setup.
- Free Tier and Paid Tier can both be available in many supported regions.

If you need higher limits, paid-service data handling, or models that are not listed on the Free Tier, you need a Paid Tier project.

## What Is Usually Free In This SDK

The pricing page currently lists Free Tier pricing for a number of models commonly used by this SDK, including examples such as:

- `gemini-2.5-pro`
- `gemini-2.5-flash`
- `gemini-2.5-flash-lite`
- `gemini-2.5-flash-lite-preview-09-2025`
- `gemini-2.5-flash-preview-09-2025`
- `gemini-2.5-flash-preview-tts`
- `gemini-2.5-flash-native-audio-preview-12-2025`
- `gemini-embedding-001`
- `gemini-embedding-2-preview`

In practical SDK terms, the Free Tier is commonly a good fit for:

- Text and chat generation.
- Multimodal understanding where you send image, video, or audio input and get text back.
- Embeddings.
- Some speech and Live API preview models.
- Limited grounding on supported Flash and Flash-Lite families.

## Rate Limit Facts That Matter

Google's current rate-limits docs call out a few rules that matter when you're diagnosing quota problems:

- Limits are applied per project, not per API key.
- Requests-per-day quotas reset at midnight Pacific time.
- Preview and experimental models usually have tighter limits.
- Your active limits are shown in Google AI Studio and can change as your tier changes.

## How To Think About Images On The Free Tier

The easiest way to think about image-related features is:

- Image understanding can be free.
- Native image generation is a separate model family.

For example, a Free Tier project can still:

- Send an image to `gemini-2.5-flash` or another supported multimodal model.
- Ask the model to describe, classify, compare, or reason over that image.
- Use image input together with chat, tool calling, or embeddings on supported free models.

That is different from asking the API to return a newly generated image.

## What Is Usually Not Free

The pricing page currently lists native image, video, and music generation families as not available on the Free Tier. In SDK terms, that usually means these helpers should be treated as paid capabilities:

- `GenerateImageAsync()`
- `EditImageAsync()`
- `GenerateImageWithReferencesAsync()`
- `GenerateVideoAsync()`
- `GenerateVideoFromImageAsync()`
- `GenerateMusicAsync()`

Examples of model families that are currently not listed as Free Tier include:

- `gemini-2.5-flash-image`
- `imagen-*`
- `veo-*`
- `lyria-*`

## Practical SDK Guidance

If you want to stay on the Free Tier in this SDK:

1. Start with text and chat on a model listed as Free Tier.
2. Use multimodal models for image understanding instead of image output.
3. Use embeddings and selected live/audio preview models when the pricing page lists them as Free Tier.
4. Treat native image, video, and music generation as paid capabilities unless Google's pricing page explicitly says otherwise.

## Source Of Truth

Google changes model availability, pricing, and quotas over time. Use these pages as the current source of truth:

- [Gemini API pricing](https://ai.google.dev/gemini-api/docs/pricing)
- [Gemini API billing](https://ai.google.dev/gemini-api/docs/billing)
- [Gemini API rate limits](https://ai.google.dev/gemini-api/docs/rate-limits)
- [Available regions for Google AI Studio and Gemini API](https://ai.google.dev/gemini-api/docs/available-regions)
- [Gemini image generation docs](https://ai.google.dev/gemini-api/docs/image-generation)
