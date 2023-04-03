using Content.Server.Botany.Systems;
using Content.Server.Construction;
using Content.Shared.Construction.Prototypes;
using Content.Shared.Containers.ItemSlots;
using Content.Shared.Whitelist;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Botany.Components;

[RegisterComponent]
[Access(typeof(SeedAnalyzerSystem))]
public sealed class SeedAnalyzerComponent : Component
{

    [DataField("seedSlot")]
    public ItemSlot SeedSlot = new();

    public const string SeedPacketSlotID = "seedPacketSlot";
}
