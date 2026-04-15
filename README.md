[![Hero](https://private-user-images.githubusercontent.com/552074/571913829-404db53f-f515-4a3a-bb18-f145dc34cedb.png?jwt=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NzYyNjk4NzQsIm5iZiI6MTc3NjI2OTU3NCwicGF0aCI6Ii81NTIwNzQvNTcxOTEzODI5LTQwNGRiNTNmLWY1MTUtNGEzYS1iYjE4LWYxNDVkYzM0Y2VkYi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjYwNDE1JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI2MDQxNVQxNjEyNTRaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1kMTcwYjQ1ZmJmM2E5ZDI2NzU5MDdiNzBlZmRhZTBkODlkODY0NjE2Zjc1ZDU5NDk2ODc3ZjNlNTEzYjg0MTM1JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZyZXNwb25zZS1jb250ZW50LXR5cGU9aW1hZ2UlMkZwbmcifQ.jZimtapSMjTp9Lgaisr5g8gjUm5C8CLE1eq_2NAHgdU)

Welcome to the hub for [Avalonia Pro](https://avaloniaui.net/pricing) bug reports, feature requests, and community discussions.

This repository doesn't contain the source code for our Pro controls and tooling, but it does contain the source for a beautiful demo app. It's where you come to talk to us and to each other about everything related to the Avalonia Pro product suite, including the WebView, DevTools, TreeDataGrid and more.

## Try It Out
The demo app in this repository lets you try Avalonia Pro with minimal effort. Because the demo includes components like Virtual Keyboard, you'll need either an Enterprise licence key or a free trial to run it.

<p align="center">
  <img src="https://github.com/user-attachments/assets/4e299f7d-b2f0-41ba-a5c3-2a6ba3d1d867" alt="Avalonia Pro Sample App"/>
</p>

**[Start a Free Trial](https://portal.avaloniaui.net/avalonia)**

Once you have your key, make sure you place it in an environment variable called `AVALONIA_LICENSE_KEY`, or open `AvaloniaProDemo.csproj` and replace the placeholder:

```xml 
<ItemGroup>
    <!-- Enterprise or Trial key required. -->
    <AvaloniaUILicenseKey Include="$(AVALONIA_LICENSE_KEY)" />
</ItemGroup>
```

## How to Use This Repository

### Found a Bug?
[Open an issue](../../issues/new/choose) with as much detail as you can. The impacted component or tool, version, your OS, and clear steps to reproduce the problem all make a huge difference in how quickly we can help.

### Got a Feature Request?
We genuinely want to hear it. [Start a discussion](../../discussions/categories/ideas) in the Ideas category and let the community weigh in. The most popular and impactful requests directly shape our roadmap.

## Enterprise Customers
If you're on an Enterprise plan, you have access to private ticket support. You can still participate here, of course, but for anything sensitive or specific to your environment, open a ticket through your dedicated [support channel](https://portal.avaloniaui.net/avalonia).

## Before You Post
Please search existing issues and discussions first to see if someone has already raised the same topic. Duplicates slow things down for everyone, and adding your voice to an existing thread actually gives it more weight.

### Why We Use Public Issues
We ask all non-Enterprise customers to raise issues and questions here rather than through private channels. 

The reason is simple: if you've hit a problem, chances are someone else has too. By keeping the conversation public, every answer we give helps the whole community, not just one person. It means our responses have the greatest possible impact, and you'll often find your question has already been answered.

## Billing, Accounts, and Licences
For anything related to your account, billing, or licence management, please use our customer portal rather than opening an issue here. 
This repository is for product and technical discussions only.

**[Open a Support Ticket](https://portal.avaloniaui.net/help)**

## Avalonia Framework
This repository is specifically for **Avalonia Pro** (the commercial tooling and components). If you've found a bug or have a question about the open-source Avalonia framework itself, head over to the main [Avalonia repository](https://github.com/AvaloniaUI/Avalonia).

## Code of Conduct
We expect everyone here to be respectful and constructive. Please review our [Code of Conduct](https://github.com/AvaloniaUI/.github/blob/main/CODE_OF_CONDUCT.md) before participating.
