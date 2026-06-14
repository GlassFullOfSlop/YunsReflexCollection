using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SPTarkov.Server.Core.Models.Utils;

namespace ReturnYRC;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.glassfullofslop.yunsreflexcollection";
    public override string Name { get; init; } = "YunsReflexCollection";
    public override string Author { get; init; } = "GlassFullOfSlop";
    public override List<string>? Contributors { get; init; }
    public override SemanticVersioning.Version Version { get; init; } = new("1.0.1");
    public override SemanticVersioning.Range SptVersion { get; init; } = new("~4.0.0");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }
    public override string? Url { get; init; }
    public override bool? IsBundleMod { get; init; } = true;
    public override string License { get; init; } = "MIT";
}

[Injectable(TypePriority = OnLoadOrder.PostSptModLoader)]
public class ReturnYRC(ISptLogger<ReturnYRC> logger) : IOnLoad
{
    public Task OnLoad()
    {
        logger.Success("Yun's Reflex Collection Loaded!");
        return Task.CompletedTask;
    }
}