using Content.Server.Botany.Components;
using Content.Server.Construction;
using Content.Server.Fax;
using Content.Server.Popups;
using Content.Server.Power.EntitySystems;
using Content.Shared.Containers.ItemSlots;
using Content.Shared.Interaction;
using Content.Shared.Nutrition.Components;
using Content.Shared.Popups;
using Robust.Server.GameObjects;

namespace Content.Server.Botany.Systems;

public sealed class SeedAnalyzerSystem : EntitySystem
{

    [Dependency] private readonly PopupSystem _popupSystem = default!;
    [Dependency] private readonly UserInterfaceSystem _userInterfaceSystem = default!;
    [Dependency] private readonly BotanySystem _botanySystem = default!;
    [Dependency] private readonly ItemSlotsSystem _itemSlotsSystem = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SeedAnalyzerComponent, ComponentInit>(OnComponentInit);
        SubscribeLocalEvent<SeedAnalyzerComponent, ComponentRemove>(OnComponentRemove);
        SubscribeLocalEvent<SeedAnalyzerComponent, InteractUsingEvent>(OnInteractUsing);
        
    }

    private void OnComponentInit (EntityUid uid, SeedAnalyzerComponent component, ComponentInit args)
    {
        _itemSlotsSystem.AddItemSlot(uid, SeedAnalyzerComponent.SeedPacketSlotID, component.SeedSlot);
    }

    private void OnComponentRemove(EntityUid uid, SeedAnalyzerComponent component, ComponentRemove args)
    {
        _itemSlotsSystem.RemoveItemSlot(uid, component.SeedSlot);
    }

    private void OnInteractUsing(EntityUid uid, SeedAnalyzerComponent seedAnalyzer, InteractUsingEvent args)
    {

        if (!this.IsPowered(uid, EntityManager))
            return;

        /// <summary>
        /// Trying to insert something that's not a seed packet
        /// </summary>
        //if (!TryComp(args.Used, out SeedComponent? seeds))
        //{
        //    _popupSystem.PopupCursor(Loc.GetString("Debug: Wrong type of item inserted!", ("name", args.Used)),
        //        args.User, PopupType.MediumCaution);
        //    return;

        //}

    }
}
