using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using SubRenamer.Model;

namespace SubRenamer.Services;

public class ClipboardService : IClipboardService
{
    private readonly Window _target;

    public ClipboardService(Window target)
    {
        _target = target;
    }

    public async Task CopyToClipboard(string content)
    {
        var dataObject = new DataObject();
        dataObject.Set(DataFormats.Text, content);
        await _target.Clipboard?.SetDataObjectAsync(dataObject);
    }
}