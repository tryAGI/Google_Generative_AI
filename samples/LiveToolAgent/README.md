# LiveToolAgent

A voice agent demo that uses the Gemini Live API with function calling to answer questions about weather, time, and math.

## Features

- Three built-in tools: `get_weather`, `get_time`, `calculate`
- Automatic tool call handling with result display
- Tool call cancellation support
- Output transcription and token usage tracking
- Auto-reconnect via `ResilientLiveSession`

## Setup

1. Set your API key:
   ```bash
   export GOOGLE_GEMINI_API_KEY="your-api-key"
   ```

2. Run the app:
   ```bash
   dotnet run --project samples/LiveToolAgent/LiveToolAgent.csproj
   ```

3. Try these prompts:
   - "What's the weather in Tokyo?"
   - "What time is it in London?"
   - "What's 42 times 17?"
   - "Is it warmer in Paris or Berlin?"

## How It Works

1. You type a message
2. The model decides which tool(s) to call based on your question
3. The app executes the tool and sends results back to the model
4. The model generates a natural language response incorporating the tool results

## Tools

| Tool | Description | Example |
|------|-------------|---------|
| `get_weather` | Simulated weather data for any city | "What's the weather in Tokyo?" |
| `get_time` | Real current time in any IANA timezone | "What time is it in America/New_York?" |
| `calculate` | Basic math (+, -, *, /) | "What's 100 divided by 7?" |

**Note:** Weather data is simulated (deterministic based on city name). In a real app, replace with an actual weather API.
