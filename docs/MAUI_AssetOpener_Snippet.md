# MAUI AssetOpener Snippet

```csharp
using MouseTrainer.Core.Assets;

public sealed class MauiAssetOpener : IAssetOpener
{
    public Task<Stream> OpenAsync(string assetName, CancellationToken ct = default)
        => FileSystem.OpenAppPackageFileAsync(assetName);
}
```

```csharp
var missing = await AssetVerifier.VerifyRequiredAudioAsync(new MauiAssetOpener());
if (missing.Count > 0) { /* fail fast / disable audio with banner */ }
```
