using System.IO;using System.Threading;using System.Threading.Tasks;
namespace MouseTrainer.Core.Assets;
public interface IAssetOpener{Task<Stream> OpenAsync(string assetName,CancellationToken ct=default);}
